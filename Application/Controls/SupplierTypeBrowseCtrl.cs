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
    public partial class SupplierTypeBrowseCtrl : MasterBrowseCtrl
    {
        public SupplierTypeBrowseCtrl()
        {
            InitializeComponent();

            try 
            {
                GetRecords();
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void AddRecord()
        {
            try
            {
                SupplierTypeDialogFrm frm = new SupplierTypeDialogFrm(Common.FormMode.Add, null);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GetRecords();
                }
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void EditRecord()
        {
            try
            {
                Data_SupplierType record = Utils.GetCurrentRecord<Data_SupplierType>(bsRecords);

                if (record != null)
                {
                    Data_SupplierType supplierType = Data_SupplierType.GetSupplierType(record.SupplierTypeCode);

                    if (supplierType != null)
                    {
                        SupplierTypeDialogFrm frm = new SupplierTypeDialogFrm(Common.FormMode.Edit, supplierType);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            GetRecords();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void DeleteRecord()
        {
            try
            {
                Data_SupplierType supplierType = Utils.GetCurrentRecord<Data_SupplierType>(bsRecords);

                if (supplierType != null)
                {
                    if (Utils.AskQuestion(String.Format("Are you sure you want to delete Supplier Type {0}", supplierType.SupplierTypeCode)) == DialogResult.Yes)
                    {
                        if (Data_SupplierType.DeleteSupplierType(supplierType.SupplierTypeCode))
                        {
                            GetRecords();
                        }
                        else
                        {
                            Utils.ShowError(String.Format(Global.FKVIOLATIONMSG, "Supplier Type", supplierType.SupplierTypeCode));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void RefreshRecords()
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

        private void GetRecords()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                bsRecords.DataSource = Data_SupplierType.GetSupplierTypes();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
