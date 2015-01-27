using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Newcourt.Controls
{
    public partial class MasterBrowseCtrl : UserControl
    {
        private BackgroundWorker bw = new BackgroundWorker();

        public MasterBrowseCtrl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRecords();
        }

        private void grdRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        protected virtual void AddRecord()
        {
            Utils.ShowInformation("Develop functionality to Add a Record.");
        }

        protected virtual void EditRecord()
        {
            Utils.ShowInformation("Develop functionality to Edit a Record.");
        }

        protected virtual void DeleteRecord()
        {
            Utils.ShowInformation("Develop functionality to Delete a Record.");
        }

        protected virtual void RefreshRecords()
        {
            Utils.ShowInformation("Develop functionality to Refresh Records.");
        }        
    }
}
