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
    public partial class LoginDialogFrm : MasterDialogFrm
    {
        private int loginAttemps;

        public LoginDialogFrm()
        {
            InitializeComponent();
            loginAttemps = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
#if DEBUG
                DialogResult = DialogResult.OK;
                Global.InitGlobalVariables("Admin");
#else
                Cursor.Current = Cursors.WaitCursor;
                bool validUser = Data_User.UserLogin(txtUsername.Text.Trim(), txtPassword.Text);

                if (validUser)
                {
                    Global.InitGlobalVariables(txtUsername.Text.Trim());
                    DialogResult = DialogResult.OK;
                }
                else
                {  
                    String errorMsg = "Incorrect Username or Password!";
                    loginAttemps++;

                    if (loginAttemps == 3)
                    {
                        Utils.ShowError(String.Format("{0} System will now close.", errorMsg));
                        Application.Exit();
                    }

                    Utils.ShowError(errorMsg);
                    txtUsername.Focus();
                }
#endif
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
