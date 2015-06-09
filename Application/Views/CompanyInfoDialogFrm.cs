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
    public partial class CompanyInfoDialogFrm : MasterDialogFrm
    {
        public CompanyInfoDialogFrm()
        {
            InitializeComponent();

            try
            {
                if (!Global.IsAdmin) {
                  chkHideSupplierFields.Enabled = false;
                }

                Data_SystemParameters systemParams = Data_SystemParameters.GetSystemParameters();

                if (systemParams != null)
                {
                    BindControls(systemParams);
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void BindControls(Data_SystemParameters systemParams)
        {
            txtDatabaseVersion.Text = systemParams.DatabaseVersion;
            txtCompanyName.Text = systemParams.CompanyName;
            txtAddress1.Text = systemParams.Address1;
            txtAddress2.Text = systemParams.Address2;
            txtAddress3.Text = systemParams.Address3;
            txtAddress4.Text = systemParams.Address4;
            txtAddress5.Text = systemParams.Address5;
            txtPhone.Text = systemParams.Phone;
            txtVatRegNo.Text = systemParams.VatRegNo;
            txtSepaFileCount.Text = systemParams.SepaFileCount.ToString().PadLeft(6, '0');
            chkHideSupplierFields.Checked = systemParams.HideSensitiveSupplierFields;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                Utils.ShowInformation("You must enter a Company Name!");
                txtCompanyName.Focus();
            }
            else
            {
                Global.CompanyName = txtCompanyName.Text.Trim();
                Data_SystemParameters.SaveSystemParameters(new Data_SystemParameters()
                {
                    CompanyName = txtCompanyName.Text.Trim(),
                    Address1 = txtAddress1.Text.Trim(),
                    Address2 = txtAddress2.Text.Trim(),
                    Address3 = txtAddress3.Text.Trim(),
                    Address4 = txtAddress4.Text.Trim(),
                    Address5 = txtAddress5.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    VatRegNo = txtVatRegNo.Text.Trim(),
                    HideSensitiveSupplierFields = chkHideSupplierFields.Checked
                });

                Global.RefreshGlobalVariables();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
