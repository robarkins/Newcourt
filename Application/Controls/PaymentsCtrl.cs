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
    public partial class PaymentsCtrl : UserControl, IDisposable
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
                List<Data_Supplier> suppliers = bsRecords.DataSource as List<Data_Supplier>;

                if (suppliers.Sum(a => a.PaymentAmount) == 0)
                {
                    Utils.ShowInformation("No payments entered!");
                    return;
                }

                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    
                    List<Data_Payment> payments = new List<Data_Payment>();

                    if (suppliers != null)
                    {
                        String bankAccountCode = luBankAccounts.SelectedValue.ToString();

                        foreach (var i in suppliers)
                        {
                            if (i.PaymentAmount != null)
                            {
                                payments.Add(new Data_Payment()
                                {
                                    SupplierID = i.SupplierID,
                                    BankAccountCode = bankAccountCode,
                                    Username = Global.Username,
                                    Amount = i.PaymentAmount ?? 0
                                });
                            }
                        }

                        Data_Payment.SavePayments(payments);

                        String xml = Data_Procedures.GenerateSEPAPaymentsXML(bankAccountCode, dtPaymentDate.Value, Global.Username);
                        using (StreamWriter sw = new StreamWriter(dlgSaveFile.FileName))
                        {
                            sw.WriteLine(xml);
                        }

                        Utils.ShowInformation("SEPA Payment file created!");
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

    }
}
