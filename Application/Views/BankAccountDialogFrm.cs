using Newcourt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newcourt.Views
{
    public partial class BankAccountDialogFrm : MasterDialogFrm
    {
        private Common.FormMode formMode;

        public BankAccountDialogFrm(Common.FormMode formMode, Data_BankAccount bankAccount)
        {
            InitializeComponent();

            try
            {
                this.formMode = formMode;

                if (formMode != Common.FormMode.Add)
                {
                    BindControls(bankAccount);

                    if (formMode == Common.FormMode.View)
                    {
                        Utils.DisableAllControls(this);
                        this.Text = String.Format("View Bank Account {0}", bankAccount.BankAccountCode);
                        return;
                    }

                    this.Text = String.Format("Edit Bank Account {0}", bankAccount.BankAccountCode);
                    txtCode.ReadOnly = true;
                    txtName.Focus();
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void BindControls(Data_BankAccount bankAccount)
        {
            txtCode.Text = bankAccount.BankAccountCode;
            txtName.Text = bankAccount.BankAccountName;
            txtBIC.Text = bankAccount.BIC;
            txtIBAN.Text = bankAccount.IBAN;
            txtOIN.Text = bankAccount.OIN;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtCode.Text))
                {
                    Utils.ShowInformation("You must eneter a Bank Account Code!");
                    txtCode.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtName.Text))
                {
                    Utils.ShowInformation("You must eneter a Bank Account Name!");
                    txtName.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtBIC.Text))
                {
                    Utils.ShowInformation("You must eneter a BIC!");
                    txtBIC.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtIBAN.Text))
                {
                    Utils.ShowInformation("You must eneter an IBAN!");
                    txtIBAN.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtOIN.Text))
                {
                    Utils.ShowInformation("You must eneter a Originator Id!");
                    txtOIN.Focus();
                }
                else
                {

                    if (formMode == Common.FormMode.Add)
                    {
                        if (!ValidateCode(txtCode.Text.Trim()))
                        {
                            if (Utils.AskQuestion(String.Format("Bank Account {0} already exists! Do you want to overwrite?", txtCode.Text.Trim())) == DialogResult.No)
                            {
                                txtCode.Focus();
                                return;
                            }
                        }
                    }

                    Data_BankAccount.SaveBankAccount(new Data_BankAccount()
                    {
                        BankAccountCode = txtCode.Text.Trim(),
                        BankAccountName = txtName.Text.Trim(),
                        BIC = txtBIC.Text.Trim(),
                        IBAN = txtIBAN.Text.Trim(),
                        OIN = txtOIN.Text.Trim()
                    });

                    DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private bool ValidateCode(String bankAccountCode)
        {
            try
            {
                Data_BankAccount record = Data_BankAccount.GetBankAccount(txtCode.Text.Trim());
                return record == null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
