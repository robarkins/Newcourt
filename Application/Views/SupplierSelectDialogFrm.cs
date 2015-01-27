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
        public SupplierSelectDialogFrm()
        {
            InitializeComponent();

            try
            {
                bsSupplierTypes.DataSource = Data_SupplierType.GetSupplierTypes();
                bsSuppliers.DataSource = Data_Supplier.GetSuppliers();

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
                bsSuppliers.DataSource = Data_Supplier.SearchSuppliers(txtSearchKeyword.Text.Trim(), luSupplierType.Text.Trim());
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }
    }
}
