namespace Newcourt.Controls
{
    partial class PaymentEnquiryCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentEnquiryCtrl));
            this.ucToolStrip1 = new Newcourt.Controls.UCToolStrip();
            this.btnViewSupplier = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewBankAccount = new System.Windows.Forms.ToolStripButton();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.luSuppliers = new System.Windows.Forms.ComboBox();
            this.bsSuppliers = new System.Windows.Forms.BindingSource(this.components);
            this.lblSupplierType = new System.Windows.Forms.Label();
            this.luSupplierTypes = new System.Windows.Forms.ComboBox();
            this.bsSupplierTypes = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentDateFrom = new System.Windows.Forms.Label();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDateTo = new System.Windows.Forms.Label();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bsRecords = new System.Windows.Forms.BindingSource(this.components);
            this.luUsers = new System.Windows.Forms.ComboBox();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.luBankAccount = new System.Windows.Forms.ComboBox();
            this.bsBankAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOptions.SuspendLayout();
            this.grpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
            this.pnlToolStrip.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.lblBankAccount);
            this.grpOptions.Controls.Add(this.luBankAccount);
            this.grpOptions.Controls.Add(this.lblUsername);
            this.grpOptions.Controls.Add(this.luUsers);
            this.grpOptions.Controls.Add(this.btnRefresh);
            this.grpOptions.Controls.Add(this.dtDateTo);
            this.grpOptions.Controls.Add(this.lblPaymentDateTo);
            this.grpOptions.Controls.Add(this.dtDateFrom);
            this.grpOptions.Controls.Add(this.lblPaymentDateFrom);
            this.grpOptions.Controls.Add(this.luSupplierTypes);
            this.grpOptions.Controls.Add(this.lblSupplierType);
            this.grpOptions.Controls.Add(this.luSuppliers);
            this.grpOptions.Controls.Add(this.lblSupplier);
            this.grpOptions.Size = new System.Drawing.Size(1189, 81);
            // 
            // grpRecords
            // 
            this.grpRecords.Controls.Add(this.panel1);
            this.grpRecords.Location = new System.Drawing.Point(0, 81);
            this.grpRecords.Size = new System.Drawing.Size(1189, 471);
            this.grpRecords.Controls.SetChildIndex(this.pnlToolStrip, 0);
            this.grpRecords.Controls.SetChildIndex(this.panel1, 0);
            this.grpRecords.Controls.SetChildIndex(this.grdRecords, 0);
            // 
            // grdRecords
            // 
            this.grdRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.grdRecords.DataSource = this.bsRecords;
            this.grdRecords.Location = new System.Drawing.Point(3, 45);
            this.grdRecords.Size = new System.Drawing.Size(1183, 394);
            // 
            // pnlToolStrip
            // 
            this.pnlToolStrip.Controls.Add(this.ucToolStrip1);
            this.pnlToolStrip.Size = new System.Drawing.Size(1183, 29);
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewSupplier,
            this.toolStripSeparator1,
            this.btnViewBankAccount});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Size = new System.Drawing.Size(1183, 29);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // btnViewSupplier
            // 
            this.btnViewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSupplier.Image")));
            this.btnViewSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewSupplier.Name = "btnViewSupplier";
            this.btnViewSupplier.Size = new System.Drawing.Size(98, 26);
            this.btnViewSupplier.Text = "View Supplier";
            this.btnViewSupplier.Click += new System.EventHandler(this.btnViewSupplier_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // btnViewBankAccount
            // 
            this.btnViewBankAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBankAccount.Image")));
            this.btnViewBankAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewBankAccount.Name = "btnViewBankAccount";
            this.btnViewBankAccount.Size = new System.Drawing.Size(129, 26);
            this.btnViewBankAccount.Text = "View Bank Account";
            this.btnViewBankAccount.Click += new System.EventHandler(this.btnViewBankAccount_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(8, 28);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier:";
            // 
            // luSuppliers
            // 
            this.luSuppliers.DataSource = this.bsSuppliers;
            this.luSuppliers.DisplayMember = "Name";
            this.luSuppliers.FormattingEnabled = true;
            this.luSuppliers.Location = new System.Drawing.Point(77, 25);
            this.luSuppliers.Name = "luSuppliers";
            this.luSuppliers.Size = new System.Drawing.Size(121, 21);
            this.luSuppliers.TabIndex = 0;
            this.luSuppliers.ValueMember = "SupplierID";
            this.luSuppliers.Leave += new System.EventHandler(this.luSuppliers_Leave);
            // 
            // bsSuppliers
            // 
            this.bsSuppliers.DataSource = typeof(Newcourt.Data.Data_Supplier);
            // 
            // lblSupplierType
            // 
            this.lblSupplierType.AutoSize = true;
            this.lblSupplierType.Location = new System.Drawing.Point(302, 28);
            this.lblSupplierType.Name = "lblSupplierType";
            this.lblSupplierType.Size = new System.Drawing.Size(75, 13);
            this.lblSupplierType.TabIndex = 2;
            this.lblSupplierType.Text = "Supplier Type:";
            // 
            // luSupplierTypes
            // 
            this.luSupplierTypes.DataSource = this.bsSupplierTypes;
            this.luSupplierTypes.DisplayMember = "SupplierTypeCode";
            this.luSupplierTypes.FormattingEnabled = true;
            this.luSupplierTypes.Location = new System.Drawing.Point(401, 25);
            this.luSupplierTypes.Name = "luSupplierTypes";
            this.luSupplierTypes.Size = new System.Drawing.Size(121, 21);
            this.luSupplierTypes.TabIndex = 1;
            this.luSupplierTypes.ValueMember = "SupplierTypeCode";
            this.luSupplierTypes.Leave += new System.EventHandler(this.luSupplierTypes_Leave);
            // 
            // bsSupplierTypes
            // 
            this.bsSupplierTypes.DataSource = typeof(Newcourt.Data.Data_SupplierType);
            // 
            // lblPaymentDateFrom
            // 
            this.lblPaymentDateFrom.AutoSize = true;
            this.lblPaymentDateFrom.Location = new System.Drawing.Point(619, 28);
            this.lblPaymentDateFrom.Name = "lblPaymentDateFrom";
            this.lblPaymentDateFrom.Size = new System.Drawing.Size(33, 13);
            this.lblPaymentDateFrom.TabIndex = 4;
            this.lblPaymentDateFrom.Text = "Date:";
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFrom.Location = new System.Drawing.Point(677, 25);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(121, 20);
            this.dtDateFrom.TabIndex = 2;
            this.dtDateFrom.Value = new System.DateTime(2015, 2, 2, 0, 0, 0, 0);
            // 
            // lblPaymentDateTo
            // 
            this.lblPaymentDateTo.AutoSize = true;
            this.lblPaymentDateTo.Location = new System.Drawing.Point(819, 28);
            this.lblPaymentDateTo.Name = "lblPaymentDateTo";
            this.lblPaymentDateTo.Size = new System.Drawing.Size(16, 13);
            this.lblPaymentDateTo.TabIndex = 6;
            this.lblPaymentDateTo.Text = "to";
            // 
            // dtDateTo
            // 
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Location = new System.Drawing.Point(851, 25);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(121, 20);
            this.dtDateTo.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1055, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 24);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bsRecords
            // 
            this.bsRecords.DataSource = typeof(Newcourt.Data.Data_Payment);
            // 
            // luUsers
            // 
            this.luUsers.DataSource = this.bsUsers;
            this.luUsers.DisplayMember = "Username";
            this.luUsers.FormattingEnabled = true;
            this.luUsers.Location = new System.Drawing.Point(77, 52);
            this.luUsers.Name = "luUsers";
            this.luUsers.Size = new System.Drawing.Size(121, 21);
            this.luUsers.TabIndex = 4;
            this.luUsers.ValueMember = "Username";
            this.luUsers.Leave += new System.EventHandler(this.luUsers_Leave);
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = typeof(Newcourt.Data.Data_User);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(32, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "User:";
            // 
            // luBankAccount
            // 
            this.luBankAccount.DataSource = this.bsBankAccounts;
            this.luBankAccount.DisplayMember = "BankAccountCode";
            this.luBankAccount.FormattingEnabled = true;
            this.luBankAccount.Location = new System.Drawing.Point(401, 52);
            this.luBankAccount.Name = "luBankAccount";
            this.luBankAccount.Size = new System.Drawing.Size(121, 21);
            this.luBankAccount.TabIndex = 5;
            this.luBankAccount.ValueMember = "BankAccountCode";
            this.luBankAccount.Leave += new System.EventHandler(this.luBankAccount_Leave);
            // 
            // bsBankAccounts
            // 
            this.bsBankAccounts.DataSource = typeof(Newcourt.Data.Data_BankAccount);
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(302, 55);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(78, 13);
            this.lblBankAccount.TabIndex = 12;
            this.lblBankAccount.Text = "Bank Account:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 29);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(5, 10);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(97, 13);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount: 0.00";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentID";
            this.dataGridViewTextBoxColumn1.FillWeight = 9F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.FillWeight = 13F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.FillWeight = 13F;
            this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn4.FillWeight = 13F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SupplierTypeCode";
            this.dataGridViewTextBoxColumn5.FillWeight = 13F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Supplier Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BankAccountCode";
            this.dataGridViewTextBoxColumn6.FillWeight = 13F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Bank Account";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn7.FillWeight = 13F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TimeProcessed";
            this.dataGridViewTextBoxColumn8.FillWeight = 13F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn9.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // PaymentEnquiryCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PaymentEnquiryCtrl";
            this.Size = new System.Drawing.Size(1189, 552);
            this.Tag = "Payment Enquiry";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
            this.pnlToolStrip.ResumeLayout(false);
            this.pnlToolStrip.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UCToolStrip ucToolStrip1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox luSuppliers;
        private System.Windows.Forms.BindingSource bsSuppliers;
        private System.Windows.Forms.Label lblSupplierType;
        private System.Windows.Forms.ComboBox luSupplierTypes;
        private System.Windows.Forms.BindingSource bsSupplierTypes;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.Label lblPaymentDateFrom;
        private System.Windows.Forms.Label lblPaymentDateTo;
        private System.Windows.Forms.DateTimePicker dtDateTo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bsRecords;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox luUsers;
        private System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.ComboBox luBankAccount;
        private System.Windows.Forms.BindingSource bsBankAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripButton btnViewSupplier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnViewBankAccount;
    }
}
