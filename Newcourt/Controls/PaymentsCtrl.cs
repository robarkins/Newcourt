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
                bsBankAccounts.DataSource = Data_BankAccounts.GetBankAccounts();
                
                luSupplierTypes.SelectedIndex = -1;

                GetRecords();
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void GetRecords()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                String supplierTypeCode = String.Empty;

                if (luSupplierTypes.SelectedValue != null)
                {
                    supplierTypeCode = luSupplierTypes.SelectedValue.ToString();
                }

                bsRecords.DataSource = Data_Supplier.GetSuppliers(supplierTypeCode);
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

        private void luSupplierTypes_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(luSupplierTypes.Text))
                {
                    String type = luSupplierTypes.Text.Trim();

                    List<Data_SupplierType> supplierTypes = bsSupplierTypes.DataSource as List<Data_SupplierType>;

                    if (supplierTypes != null)
                    {
                        if (!supplierTypes.Exists(a => a.SupplierTypeCode == type))
                        {
                            luSupplierTypes.Text = String.Empty;
                            luSupplierTypes.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
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
                        int bankAccountId = 0;

                        if (!int.TryParse(luBankAccounts.SelectedValue.ToString(), out bankAccountId))
                        {
                            throw new Exception("Bank Account ID is not a valid Int32 value!");
                        }

                        foreach (var i in suppliers)
                        {
                            if (i.PaymentAmount != null)
                            {
                                payments.Add(new Data_Payment()
                                {
                                    SupplierID = i.SupplierID,
                                    BankAccountID = bankAccountId,
                                    Username = Global.Username,
                                    Amount = i.PaymentAmount ?? 0
                                });
                            }
                        }

                        Data_Payment.SavePayments(payments);

                        String xml = Data_Procedures.GenerateSEPAPaymentsXML(bankAccountId, dtPaymentDate.Value, Global.Username);
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
    }
}
