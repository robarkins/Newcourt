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
    public partial class SupplierTypeDialogFrm : MasterDialogFrm
    {
        private Common.FormMode formMode;

        public SupplierTypeDialogFrm(Common.FormMode mode, Data_SupplierType supplierType)
        {
            InitializeComponent();

            formMode = mode;

            if (mode == Common.FormMode.Edit)
            {
                this.Text = String.Format("Edit Supplier Type {0}", supplierType.SupplierTypeCode);
                txtCode.ReadOnly = true;

                txtCode.Text = supplierType.SupplierTypeCode;
                txtName.Text = supplierType.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text.Trim() == String.Empty)
                {
                    Utils.ShowInformation("You must enter a Supplier Type Code!");
                    txtCode.Focus();
                }
                else
                {
                    if (formMode == Common.FormMode.Add)
                    {
                        if (!ValidateCode(txtCode.Text.Trim()))
                        {
                            if (Utils.AskQuestion(String.Format("Supplier Type Code {0} aleady exists! Do you want to overwrite?", txtCode.Text.Trim())) == DialogResult.No)
                            {
                                txtCode.Focus();
                                return;
                            }
                        }
                    }

                    Data_SupplierType.SaveSupplierType(new Data_SupplierType()
                    {
                        SupplierTypeCode = txtCode.Text.Trim(),
                        Name = txtName.Text.Trim()
                    });

                    DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private bool ValidateCode(String supplierTypeCode)
        {
            try
            {
                Data_SupplierType type = Data_SupplierType.GetSupplierType(supplierTypeCode);

                return type == null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
