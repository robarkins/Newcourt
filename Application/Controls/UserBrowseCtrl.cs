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
    public partial class UserBrowseCtrl : MasterBrowseCtrl
    {
        public UserBrowseCtrl()
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

        private void GetRecords()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                bsRecords.DataSource = Data_User.GetUsers();
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

        protected override void AddRecord()
        {
            try
            {
                UserDialogFrm frm = new UserDialogFrm(Common.FormMode.Add, null);
                
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
                Data_User user = Utils.GetCurrentRecord<Data_User>(bsRecords);

                if (user != null)
                {
                    UserDialogFrm frm = new UserDialogFrm(Common.FormMode.Edit, user);
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        GetRecords();
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
    }
}
