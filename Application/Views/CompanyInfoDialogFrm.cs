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
    public partial class CompanyInfoDialogFrm : MasterDialogFrm
    {
        public CompanyInfoDialogFrm()
        {
            InitializeComponent();

            try
            {
                Data_SystemParameters systemParams = Data_SystemParameters.GetSystemParameters();

                if (systemParams != null)
                {
                    BindControls(systemParams);
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void BindControls(Data_SystemParameters systemParams)
        {
            txtDatabaseVersion.Text = systemParams.DatabaseVersion;
            txtCompanyName.Text = systemParams.CompanyName;
            txtAddress1.Text = systemParams.Address1;
            txtAddress2.Text = systemParams.Address2;
            txtAddress3.Text = systemParams.Address3;
            txtAddress4.Text = systemParams.Address4;
            txtAddress5.Text = systemParams.Address5;
            txtPhone.Text = systemParams.Phone;
            txtSepaFileCount.Text = systemParams.SepaFileCount.ToString().PadLeft(6, '0');
        }
    }
}
