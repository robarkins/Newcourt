﻿using Newcourt.Controls;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            try
            {
                if (!Global.IsAdmin)
                {
                    ddbUsers.Visible = false;
                }

                SetCompanyName();
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void AddTab(UserControl userControl)
        {
            try
            {
                TabPage tabPage = new TabPage();


                tabPage.Text = userControl.Tag.ToString();

                for (int i = 0; i <= tcMain.TabPages.Count - 1; i++)
                {
                    if (tcMain.TabPages[i].Text == tabPage.Text)
                    {
                        tcMain.SelectedTab = tcMain.TabPages[i];
                        return;
                    }
                }

                userControl.Dock = DockStyle.Fill;
                tabPage.Controls.Add(userControl);
                tcMain.TabPages.Add(tabPage);
                tcMain.SelectedTab = tcMain.TabPages[tcMain.TabPages.Count - 1];
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void btnSupplierAccounts_Click(object sender, EventArgs e)
        {
            AddTab(new SupplierBrowseCtrl());
        }

        private void btnSupplierTypes_Click(object sender, EventArgs e)
        {
            AddTab(new SupplierTypeBrowseCtrl());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            AddTab(new PaymentsCtrl());
        }

        private void btnBankAccounts_Click(object sender, EventArgs e)
        {
            AddTab(new BankAccountBrowseCtrl());
        }

        private void paymentEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new PaymentEnquiryCtrl());
        }

        private void btnUserAccounts_Click(object sender, EventArgs e)
        {
            AddTab(new UserBrowseCtrl());
        }

        private void btnPaymentDetail_Click(object sender, EventArgs e)
        {
            AddTab(new PaymentDetailReportCtrl());
        }

        private void btnSupplierList_Click(object sender, EventArgs e) {
          AddTab(new SupplierListReportCtrl());
        }

        private void btnSupplierListBank_Click(object sender, EventArgs e) {
          AddTab(new SupplierListWithBankReportCtrl());
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            if (new CompanyInfoDialogFrm().ShowDialog() == DialogResult.OK)
            {
                SetCompanyName();
            }
        }


        private void btnBankIdentifierCodes_Click(object sender, EventArgs e) {
          AddTab(new BankIdentifierCodesCtrl());
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcMain.TabPages.Count > 0)
                {
                    TabPage test = tcMain.SelectedTab;
                    test.Controls[0].Dispose();
                    tcMain.TabPages.Remove(tcMain.SelectedTab);
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void SetCompanyName()
        {
            try
            {
                this.Text = Global.CompanyName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
