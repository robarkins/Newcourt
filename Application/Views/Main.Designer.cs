namespace Newcourt.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.tcMain = new System.Windows.Forms.TabControl();
      this.cmsTabControl = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.btnCloseTab = new System.Windows.Forms.ToolStripMenuItem();
      this.ucToolStrip1 = new Newcourt.Controls.UCToolStrip();
      this.ddbSystem = new System.Windows.Forms.ToolStripDropDownButton();
      this.btnSystemParams = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ddbBank = new System.Windows.Forms.ToolStripDropDownButton();
      this.btnBankAccounts = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ddbSuppliers = new System.Windows.Forms.ToolStripDropDownButton();
      this.btnSupplierAccounts = new System.Windows.Forms.ToolStripMenuItem();
      this.btnSupplierTypes = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ddbPayments = new System.Windows.Forms.ToolStripDropDownButton();
      this.sEPAPaymentsWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.paymentEnquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnPaymentDetail = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.ddbUsers = new System.Windows.Forms.ToolStripDropDownButton();
      this.btnUserAccounts = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsTabControl.SuspendLayout();
      this.ucToolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tcMain
      // 
      this.tcMain.ContextMenuStrip = this.cmsTabControl;
      this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tcMain.Location = new System.Drawing.Point(0, 39);
      this.tcMain.Name = "tcMain";
      this.tcMain.SelectedIndex = 0;
      this.tcMain.Size = new System.Drawing.Size(1172, 528);
      this.tcMain.TabIndex = 1;
      // 
      // cmsTabControl
      // 
      this.cmsTabControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCloseTab});
      this.cmsTabControl.Name = "cmsTabControl";
      this.cmsTabControl.Size = new System.Drawing.Size(127, 26);
      // 
      // btnCloseTab
      // 
      this.btnCloseTab.Name = "btnCloseTab";
      this.btnCloseTab.Size = new System.Drawing.Size(126, 22);
      this.btnCloseTab.Text = "Close Tab";
      this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
      // 
      // ucToolStrip1
      // 
      this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbSystem,
            this.toolStripSeparator1,
            this.ddbBank,
            this.toolStripSeparator2,
            this.ddbSuppliers,
            this.toolStripSeparator4,
            this.ddbPayments,
            this.toolStripSeparator5,
            this.ddbUsers});
      this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
      this.ucToolStrip1.Name = "ucToolStrip1";
      this.ucToolStrip1.Size = new System.Drawing.Size(1172, 39);
      this.ucToolStrip1.TabIndex = 0;
      this.ucToolStrip1.Text = "ucToolStrip1";
      // 
      // ddbSystem
      // 
      this.ddbSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSystemParams});
      this.ddbSystem.Image = ((System.Drawing.Image)(resources.GetObject("ddbSystem.Image")));
      this.ddbSystem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.ddbSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ddbSystem.Name = "ddbSystem";
      this.ddbSystem.Size = new System.Drawing.Size(123, 36);
      this.ddbSystem.Text = "System Setup";
      // 
      // btnSystemParams
      // 
      this.btnSystemParams.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemParams.Image")));
      this.btnSystemParams.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnSystemParams.Name = "btnSystemParams";
      this.btnSystemParams.Size = new System.Drawing.Size(200, 30);
      this.btnSystemParams.Text = "Company Information";
      this.btnSystemParams.Click += new System.EventHandler(this.btnCompanyInfo_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
      // 
      // ddbBank
      // 
      this.ddbBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBankAccounts});
      this.ddbBank.Image = ((System.Drawing.Image)(resources.GetObject("ddbBank.Image")));
      this.ddbBank.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.ddbBank.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ddbBank.Name = "ddbBank";
      this.ddbBank.Size = new System.Drawing.Size(78, 36);
      this.ddbBank.Text = "Bank";
      // 
      // btnBankAccounts
      // 
      this.btnBankAccounts.Name = "btnBankAccounts";
      this.btnBankAccounts.Size = new System.Drawing.Size(153, 22);
      this.btnBankAccounts.Text = "Bank Accounts";
      this.btnBankAccounts.Click += new System.EventHandler(this.btnBankAccounts_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
      // 
      // ddbSuppliers
      // 
      this.ddbSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSupplierAccounts,
            this.btnSupplierTypes});
      this.ddbSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("ddbSuppliers.Image")));
      this.ddbSuppliers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.ddbSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ddbSuppliers.Name = "ddbSuppliers";
      this.ddbSuppliers.Size = new System.Drawing.Size(100, 36);
      this.ddbSuppliers.Text = "Suppliers";
      // 
      // btnSupplierAccounts
      // 
      this.btnSupplierAccounts.Name = "btnSupplierAccounts";
      this.btnSupplierAccounts.Size = new System.Drawing.Size(170, 22);
      this.btnSupplierAccounts.Text = "Supplier Accounts";
      this.btnSupplierAccounts.Click += new System.EventHandler(this.btnSupplierAccounts_Click);
      // 
      // btnSupplierTypes
      // 
      this.btnSupplierTypes.Name = "btnSupplierTypes";
      this.btnSupplierTypes.Size = new System.Drawing.Size(170, 22);
      this.btnSupplierTypes.Text = "Supplier Types";
      this.btnSupplierTypes.Click += new System.EventHandler(this.btnSupplierTypes_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
      // 
      // ddbPayments
      // 
      this.ddbPayments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEPAPaymentsWizardToolStripMenuItem,
            this.toolStripSeparator3,
            this.paymentEnquiryToolStripMenuItem,
            this.toolStripSeparator6,
            this.reportsToolStripMenuItem});
      this.ddbPayments.Image = ((System.Drawing.Image)(resources.GetObject("ddbPayments.Image")));
      this.ddbPayments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.ddbPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ddbPayments.Name = "ddbPayments";
      this.ddbPayments.Size = new System.Drawing.Size(104, 36);
      this.ddbPayments.Text = "Payments";
      // 
      // sEPAPaymentsWizardToolStripMenuItem
      // 
      this.sEPAPaymentsWizardToolStripMenuItem.Name = "sEPAPaymentsWizardToolStripMenuItem";
      this.sEPAPaymentsWizardToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
      this.sEPAPaymentsWizardToolStripMenuItem.Text = "SEPA Payments Wizard";
      this.sEPAPaymentsWizardToolStripMenuItem.Click += new System.EventHandler(this.btnPayments_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
      // 
      // paymentEnquiryToolStripMenuItem
      // 
      this.paymentEnquiryToolStripMenuItem.Name = "paymentEnquiryToolStripMenuItem";
      this.paymentEnquiryToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
      this.paymentEnquiryToolStripMenuItem.Text = "Payment Enquiry";
      this.paymentEnquiryToolStripMenuItem.Click += new System.EventHandler(this.paymentEnquiryToolStripMenuItem_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(192, 6);
      // 
      // reportsToolStripMenuItem
      // 
      this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPaymentDetail});
      this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
      this.reportsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
      this.reportsToolStripMenuItem.Text = "Reports";
      // 
      // btnPaymentDetail
      // 
      this.btnPaymentDetail.Name = "btnPaymentDetail";
      this.btnPaymentDetail.Size = new System.Drawing.Size(154, 22);
      this.btnPaymentDetail.Text = "Payment Detail";
      this.btnPaymentDetail.Click += new System.EventHandler(this.btnPaymentDetail_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
      // 
      // ddbUsers
      // 
      this.ddbUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUserAccounts});
      this.ddbUsers.Image = ((System.Drawing.Image)(resources.GetObject("ddbUsers.Image")));
      this.ddbUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ddbUsers.Name = "ddbUsers";
      this.ddbUsers.Size = new System.Drawing.Size(64, 36);
      this.ddbUsers.Text = "Users";
      // 
      // btnUserAccounts
      // 
      this.btnUserAccounts.Name = "btnUserAccounts";
      this.btnUserAccounts.Size = new System.Drawing.Size(152, 22);
      this.btnUserAccounts.Text = "User Accounts";
      this.btnUserAccounts.Click += new System.EventHandler(this.btnUserAccounts_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1172, 567);
      this.Controls.Add(this.tcMain);
      this.Controls.Add(this.ucToolStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Irish College of English";
      this.cmsTabControl.ResumeLayout(false);
      this.ucToolStrip1.ResumeLayout(false);
      this.ucToolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Controls.UCToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ddbSuppliers;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripMenuItem btnSupplierAccounts;
        private System.Windows.Forms.ToolStripMenuItem btnSupplierTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTabControl;
        private System.Windows.Forms.ToolStripMenuItem btnCloseTab;
        private System.Windows.Forms.ToolStripDropDownButton ddbSystem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnSystemParams;
        private System.Windows.Forms.ToolStripDropDownButton ddbBank;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnBankAccounts;
        private System.Windows.Forms.ToolStripDropDownButton ddbPayments;
        private System.Windows.Forms.ToolStripMenuItem sEPAPaymentsWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem paymentEnquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton ddbUsers;
        private System.Windows.Forms.ToolStripMenuItem btnUserAccounts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPaymentDetail;
    }
}

