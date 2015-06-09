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

            try
            {
                Object username = Utils.GetRegistryValue(Common.KEY_USERLOGIN);

                if (username != null)
                {
                    txtUsername.Text = username.ToString();
                }

                loginAttemps = 0;
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
#if DEBUG
                DialogResult = DialogResult.OK;
                int test = loginAttemps;
                Global.InitGlobalVariables("Admin", true, "Irish School of English", false);
#else
                Cursor.Current = Cursors.WaitCursor;
                Data_User user = Data_User.GetUser(txtUsername.Text.Trim(), txtPassword.Text);

                if (user != null)
                {
                    if (!VerifyDatabaseVersion())
                    {
                        Utils.ShowError("The database is out of date for the current system. System load cannot continue. Please contact your administrator.");
                        Application.Exit();
                    }

                    //String companyName = Data_SystemParameters.GetCompanyName();
                    Data_SystemParameters systemParams = Data_SystemParameters.GetSystemParameters();
                    Global.InitGlobalVariables(user.Username, user.IsAdmin, systemParams.CompanyName, systemParams.HideSensitiveSupplierFields);
                    Utils.SaveRegistryValue(Common.KEY_USERLOGIN, txtUsername.Text);
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

        private bool VerifyDatabaseVersion()
        {
            try
            {
                return Data_SystemParameters.GetDatabaseVersion() == Global.DBVERSION;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
