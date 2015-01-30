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
    public partial class SupplierSelectDialogFrm : MasterDialogFrm
    {
        private List<Data_Supplier> suppliers;
        public SupplierSelectDialogFrm()
        {
            InitializeComponent();

            try
            {
                bsSupplierTypes.DataSource = Data_SupplierType.GetSupplierTypes();

                suppliers = Data_Supplier.GetSuppliersWithPaymentStagingCheck(Global.Username);
                bsSuppliers.DataSource = suppliers;

                luSupplierType.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void luSupplierType_Leave(object sender, EventArgs e)
        {
            String type = luSupplierType.Text.Trim();

            if (String.IsNullOrEmpty(type))
            {
                try
                {
                    List<Data_SupplierType> supplierTypes = bsSupplierTypes.DataSource as List<Data_SupplierType>;

                    if (supplierTypes != null)
                    {
                        if (!supplierTypes.Exists(a => a.SupplierTypeCode == type))
                        {
                            luSupplierType.Text = String.Empty;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Utils.ShowException(ex);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                suppliers = Data_Supplier.SearchSuppliers(Global.Username, txtSearchKeyword.Text.Trim(), luSupplierType.Text.Trim());
                bsSuppliers.DataSource = suppliers;
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<Data_PaymentStaging> staging = new List<Data_PaymentStaging>();

                foreach(DataGridViewRow i in grdSuppliers.Rows)
                {
                    DataGridViewCheckBoxCell cell = i.Cells["Selected"] as DataGridViewCheckBoxCell;

                    bool isSelected = Convert.ToBoolean(cell.Value);

                    if (isSelected)
                    {
                        Data_Supplier supplier = i.DataBoundItem as Data_Supplier;

                        if (supplier != null)
                        {
                            staging.Add(new Data_PaymentStaging()
                            {
                                Username = Global.Username,
                                SuppplierId = supplier.SupplierID,
                                Amount = 0
                            });
                        }
                    }
                }

                Data_PaymentStaging.SavePaymentStaging(Global.Username, staging);
                DialogResult = DialogResult.OK;
                
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void grdSuppliers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (suppliers[e.RowIndex].PaymentExists)
                {
                    grdSuppliers.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#ff3333");
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            SelectRows(true);
        }

        private void SelectRows(bool value)
        {
            foreach(DataGridViewRow i in grdSuppliers.Rows)
            {
                DataGridViewCheckBoxCell check = i.Cells["Selected"] as DataGridViewCheckBoxCell;

                if (!check.ReadOnly)
                {
                    check.Value = value;
                }
            }
        }

        private void btnUnmarkAll_Click(object sender, EventArgs e)
        {
            SelectRows(false);
        }

    }
}
