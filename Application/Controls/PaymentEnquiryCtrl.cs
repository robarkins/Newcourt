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
using Newcourt.Views;

namespace Newcourt.Controls
{
    public partial class PaymentEnquiryCtrl : MasterEnquiryCtrl
    {
        public PaymentEnquiryCtrl()
        {
            InitializeComponent();

            try
            {
                bsSuppliers.DataSource = Data_Supplier.GetSuppliers();
                bsSupplierTypes.DataSource = Data_SupplierType.GetSupplierTypes();
                bsUsers.DataSource = Data_User.GetUsers();
                bsBankAccounts.DataSource = Data_BankAccount.GetBankAccounts();

                luSuppliers.SelectedIndex = -1;
                luSupplierTypes.SelectedIndex = -1;
                luUsers.SelectedIndex = -1;
                luBankAccount.SelectedIndex = -1;

                dtDateFrom.Value = DateTime.Parse(String.Format("01/01/{0}", DateTime.Now.Year));
                dtDateTo.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void luSuppliers_Leave(object sender, EventArgs e)
        {
            try
            {
                List<Data_Supplier> suppliers = bsSuppliers.DataSource as List<Data_Supplier>;

                if (suppliers != null)
                {
                    String text = luSuppliers.Text.Trim();

                    if (!suppliers.Exists(a => a.Name == text))
                    {
                        luSuppliers.Text = String.Empty;
                        luSuppliers.SelectedIndex = -1;
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void luSupplierTypes_Leave(object sender, EventArgs e)
        {
            try
            {
                List<Data_SupplierType> supplierTypes = bsSupplierTypes.DataSource as List<Data_SupplierType>;

                if (supplierTypes != null)
                {
                    String text = luSupplierTypes.Text.Trim();

                    if (!supplierTypes.Exists(a => a.SupplierTypeCode == text))
                    {
                        luSupplierTypes.Text = String.Empty;
                        luSupplierTypes.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void luUsers_Leave(object sender, EventArgs e)
        {
            try
            {
                List<Data_User> users = bsUsers.DataSource as List<Data_User>;

                if (users != null)
                {
                    String text = luUsers.Text.Trim();

                    if (!users.Exists(a => a.Username == text))
                    {
                        luUsers.Text = String.Empty;
                        luUsers.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void luBankAccount_Leave(object sender, EventArgs e)
        {
            try
            {
                List<Data_BankAccount> bankAccounts = bsBankAccounts.DataSource as List<Data_BankAccount>;

                if (bankAccounts != null)
                {
                    String text = luBankAccount.Text.Trim();

                    if (!bankAccounts.Exists(a => a.BankAccountCode == text))
                    {
                        luBankAccount.Text = String.Empty;
                        luBankAccount.SelectedIndex = -1;
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
                
                int supplierId = 0;

                if (luSuppliers.Text.Trim() != String.Empty)
                {
                    if (!int.TryParse(luSuppliers.SelectedValue.ToString(), out supplierId))
                    {
                        throw new Exception("SupplierId is not a valid Integer type!");
                    }
                }

                String supplierTypeCode = luSupplierTypes.Text.Trim();
                String bankAccountCode = luBankAccount.Text.Trim();
                DateTime fromDate = dtDateFrom.Value.Date;
                DateTime toDate = dtDateTo.Value.Date.AddDays(1);
                String username = luUsers.Text.Trim();

                List<Data_Payment> payments = Data_Payment.GetPayments(username, supplierId, supplierTypeCode, bankAccountCode, fromDate, toDate);

                if (payments != null)
                {
                    bsRecords.DataSource = payments;
                    lblTotalAmount.Text = String.Format("Total Amount: {0: 0.00}", payments.Sum(a => a.Amount));
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Payment payment = Utils.GetCurrentRecord<Data_Payment>(bsRecords);

                if (payment != null)
                {
                    Data_Supplier supplier = Data_Supplier.GetSupplier(payment.SupplierID);

                    if (supplier != null)
                    {
                        SupplierDialogFrm frm = new SupplierDialogFrm(Common.FormMode.View, supplier);
                        frm.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnViewBankAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Payment payment = Utils.GetCurrentRecord<Data_Payment>(bsRecords);

                if (payment != null)
                {
                    Data_BankAccount bankAccount = Data_BankAccount.GetBankAccount(payment.BankAccountCode);

                    if (bankAccount != null)
                    {
                        BankAccountDialogFrm frm = new BankAccountDialogFrm(Common.FormMode.View, bankAccount);
                        frm.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

    }
}
