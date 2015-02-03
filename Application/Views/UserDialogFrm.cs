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
    public partial class UserDialogFrm : MasterDialogFrm
    {
        private Common.FormMode formMode;

        public UserDialogFrm(Newcourt.Common.FormMode formMode, Data_User user)
        {
            InitializeComponent();

            this.formMode = formMode;
            if (formMode == Common.FormMode.Edit)
            {
                this.Text = String.Format("Edit User {0}", user.Username);
                BindControls(user);

                if (user.Username == "Admin")
                {
                    Utils.DisableAllControls(this);
                }
            }
        }

        private void BindControls(Data_User user)
        {
            try
            {
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                chkAdmin.Checked = user.IsAdmin;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMode == Common.FormMode.Add && !ValidateUser(txtUsername.Text.Trim()))
                {
                    if(Utils.AskQuestion(String.Format("User {0} already exists! Do you want to overwrite?", txtUsername.Text.Trim())) == DialogResult.No)
                    {
                        txtUsername.Focus();
                        return;
                    }
                }

                Data_User.SaveUser(new Data_User()
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    IsAdmin = chkAdmin.Checked
                });

                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private bool ValidateUser(String username)
        {
            try
            {
                Data_User user = Data_User.GetUserByUsername(username);

                return user == null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
