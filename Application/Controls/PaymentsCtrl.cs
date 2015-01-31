using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newcourt.Data;
using System.IO;
using Newcourt.Views;

namespace Newcourt.Controls
{
    public partial class PaymentsCtrl : UserControl
    {
        public PaymentsCtrl()
        {
            InitializeComponent();

            try
            {
                bsSupplierTypes.DataSource = Data_SupplierType.GetSupplierTypes();
                bsBankAccounts.DataSource = Data_BankAccount.GetBankAccounts();
                GetRecords();
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void grdRecords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(grdRecords.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(luBankAccounts.Text))
                {
                    Utils.ShowInformation("You must select a Bank Account!");
                    luBankAccounts.Focus();
                }
                else if (String.IsNullOrWhiteSpace(dtPaymentDate.Text))
                {
                    Utils.ShowInformation("You must select a Payment Date!");
                    dtPaymentDate.Focus();
                }
                else
                {
                    List<Data_PaymentStaging> suppliers = bsRecords.DataSource as List<Data_PaymentStaging>;

                    if (suppliers.Count == 0)
                    {
                        Utils.ShowInformation("No Suppliers have been selected for payment!");
                        return;
                    }

                    if (suppliers.Sum(a => a.Amount) == 0)
                    {
                        Utils.ShowInformation("No payments entered!");
                        return;
                    }

                    String sepaFileCount = (Data_SystemParameters.GetSepaFileCount() + 1).ToString().PadLeft(6, '0');
                    dlgSaveFile.FileName = String.Format("SEPA-{0:ddMMyyyy}-{1}", DateTime.Now, sepaFileCount);
                    if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        List<Data_Payment> payments = new List<Data_Payment>();

                        if (suppliers != null)
                        {
                            String bankAccountCode = luBankAccounts.SelectedValue.ToString();

                            foreach (var i in suppliers)
                            {
                                if (i.Amount != 0)
                                {
                                    payments.Add(new Data_Payment()
                                    {
                                        SupplierID = i.SuppplierId,
                                        BankAccountCode = bankAccountCode,
                                        Username = Global.Username,
                                        Amount = i.Amount
                                    });
                                }
                            }

                            SavePaymentStaging();
                            String xml = Data_Procedures.GenerateSEPAPaymentsXML(bankAccountCode, dtPaymentDate.Value, Global.Username);
                            using (StreamWriter sw = new StreamWriter(dlgSaveFile.FileName))
                            {
                                sw.WriteLine(xml);
                            }

                            bsRecords.DataSource = null;
                            Utils.ShowInformation("SEPA Payment file created!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierSelectDialogFrm frm = new SupplierSelectDialogFrm();
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetRecords();
            }
        }

        private void GetRecords()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                bsRecords.DataSource = Data_PaymentStaging.GetPaymentStagingByUsername(Global.Username);
                
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void SavePaymentStaging()
        {
            try
            {
                List<Data_PaymentStaging> payments = bsRecords.DataSource as List<Data_PaymentStaging>;

                if (payments != null)
                {
                    Data_PaymentStaging.SavePaymentStaging(Global.Username, payments);
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFromPaymentStaging();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            DeleteFromPaymentStaging();
        }

        private void DeleteFromPaymentStaging()
        {
            try
            {
                Data_PaymentStaging payment = Utils.GetCurrentRecord<Data_PaymentStaging>(bsRecords);

                if (payment != null)
                {
                    Data_PaymentStaging.DeleteFromPaymentStaging(payment.Username, payment.SuppplierId);
                    GetRecords();
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void grdRecords_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            Utils.ShowError("The value entered is not a valid Decimal!");
        }

    }
}
