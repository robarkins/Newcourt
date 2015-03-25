using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newcourt.Views;
using Newcourt.Data;

namespace Newcourt.Controls
{
    public partial class SupplierBrowseCtrl : MasterBrowseCtrl
    {
        public SupplierBrowseCtrl()
        {
            InitializeComponent();

            GetRecords();
        }

        protected override void AddRecord()
        {
            try
            {
                SupplierDialogFrm frm = new SupplierDialogFrm(Common.FormMode.Add, null);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GetRecords();
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void EditRecord()
        {
            try
            {
                Data_Supplier record = Utils.GetCurrentRecord<Data_Supplier>(bsRecords);

                if (record != null)
                {
                    Data_Supplier supplier = Data_Supplier.GetSupplier(record.SupplierID);

                    if (supplier != null)
                    {
                        SupplierDialogFrm frm = new SupplierDialogFrm(Common.FormMode.Edit, supplier);

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

        protected override void DeleteRecord()
        {
            try
            {
                Data_Supplier supplier = Utils.GetCurrentRecord<Data_Supplier>(bsRecords);

                if (supplier != null)
                {
                    if (Utils.AskQuestion(String.Format("Are you sure you want to delete supplier {0}?", supplier.SupplierID)) == DialogResult.Yes)
                    {
                        Data_Supplier.DeleteSupplier(supplier.SupplierID);
                        GetRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void GetRecords()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                bsRecords.DataSource = Data_Supplier.GetSortableSuppliers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void grdRecords_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
          DataGridViewColumn newColumn = grdRecords.Columns[e.ColumnIndex];
          DataGridViewColumn oldColumn = grdRecords.SortedColumn;
          ListSortDirection direction;

          if (oldColumn != null) {
            if (oldColumn == newColumn && grdRecords.SortOrder == SortOrder.Ascending) {
              direction = ListSortDirection.Descending;
            } else {
              direction = ListSortDirection.Ascending;
              oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
          } else {
            direction = ListSortDirection.Ascending;
          }

          grdRecords.Sort(newColumn, direction);
          newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void grdRecords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
          foreach (DataGridViewColumn column in grdRecords.Columns) {
            column.SortMode = DataGridViewColumnSortMode.Programmatic;
          }
        }
    }
}
