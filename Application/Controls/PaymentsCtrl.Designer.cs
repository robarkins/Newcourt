using Newcourt.Data;
namespace Newcourt.Controls
{
    partial class PaymentsCtrl
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
                SavePaymentStaging();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsCtrl));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.luBankAccounts = new System.Windows.Forms.ComboBox();
            this.bsBankAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.lblBank = new System.Windows.Forms.Label();
            this.bsSupplierTypes = new System.Windows.Forms.BindingSource(this.components);
            this.grpSuppliers = new System.Windows.Forms.GroupBox();
            this.grdRecords = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRecords = new System.Windows.Forms.BindingSource(this.components);
            this.ucToolStrip1 = new Newcourt.Controls.UCToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.cmsRecords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).BeginInit();
            this.grpSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).BeginInit();
            this.ucToolStrip1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.cmsRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.lblPaymentDate);
            this.grpOptions.Controls.Add(this.dtPaymentDate);
            this.grpOptions.Controls.Add(this.luBankAccounts);
            this.grpOptions.Controls.Add(this.lblBank);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOptions.Location = new System.Drawing.Point(0, 0);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(918, 59);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(238, 28);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(77, 13);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(332, 26);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(121, 20);
            this.dtPaymentDate.TabIndex = 5;
            // 
            // luBankAccounts
            // 
            this.luBankAccounts.DataSource = this.bsBankAccounts;
            this.luBankAccounts.DisplayMember = "BankAccountCode";
            this.luBankAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.luBankAccounts.FormattingEnabled = true;
            this.luBankAccounts.Location = new System.Drawing.Point(58, 25);
            this.luBankAccounts.Name = "luBankAccounts";
            this.luBankAccounts.Size = new System.Drawing.Size(121, 21);
            this.luBankAccounts.TabIndex = 4;
            this.luBankAccounts.ValueMember = "BankAccountCode";
            // 
            // bsBankAccounts
            // 
            this.bsBankAccounts.DataSource = typeof(Newcourt.Data.Data_BankAccount);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(8, 28);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(35, 13);
            this.lblBank.TabIndex = 3;
            this.lblBank.Text = "Bank:";
            // 
            // bsSupplierTypes
            // 
            this.bsSupplierTypes.DataSource = typeof(Newcourt.Data.Data_SupplierType);
            // 
            // grpSuppliers
            // 
            this.grpSuppliers.Controls.Add(this.grdRecords);
            this.grpSuppliers.Controls.Add(this.ucToolStrip1);
            this.grpSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSuppliers.Location = new System.Drawing.Point(0, 59);
            this.grpSuppliers.Name = "grpSuppliers";
            this.grpSuppliers.Size = new System.Drawing.Size(918, 200);
            this.grpSuppliers.TabIndex = 1;
            this.grpSuppliers.TabStop = false;
            this.grpSuppliers.Text = "Suppliers";
            // 
            // grdRecords
            // 
            this.grdRecords.AllowUserToAddRows = false;
            this.grdRecords.AllowUserToDeleteRows = false;
            this.grdRecords.AllowUserToResizeRows = false;
            this.grdRecords.AutoGenerateColumns = false;
            this.grdRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.supplierTypeCodeDataGridViewTextBoxColumn,
            this.PaymentAmount,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.address4DataGridViewTextBoxColumn,
            this.address5DataGridViewTextBoxColumn});
            this.grdRecords.ContextMenuStrip = this.cmsRecords;
            this.grdRecords.DataSource = this.bsRecords;
            this.grdRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRecords.Location = new System.Drawing.Point(3, 41);
            this.grdRecords.MultiSelect = false;
            this.grdRecords.Name = "grdRecords";
            this.grdRecords.RowHeadersVisible = false;
            this.grdRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRecords.Size = new System.Drawing.Size(912, 156);
            this.grdRecords.TabIndex = 0;
            this.grdRecords.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecords_CellEnter);
            this.grdRecords.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdRecords_DataError);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 40F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierTypeCodeDataGridViewTextBoxColumn
            // 
            this.supplierTypeCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "SupplierTypeCode";
            this.supplierTypeCodeDataGridViewTextBoxColumn.FillWeight = 10F;
            this.supplierTypeCodeDataGridViewTextBoxColumn.HeaderText = "Supplier Type";
            this.supplierTypeCodeDataGridViewTextBoxColumn.Name = "supplierTypeCodeDataGridViewTextBoxColumn";
            this.supplierTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.PaymentAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.PaymentAmount.FillWeight = 10F;
            this.PaymentAmount.HeaderText = "Amount";
            this.PaymentAmount.Name = "PaymentAmount";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.Visible = false;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.Visible = false;
            // 
            // address3DataGridViewTextBoxColumn
            // 
            this.address3DataGridViewTextBoxColumn.DataPropertyName = "Address3";
            this.address3DataGridViewTextBoxColumn.HeaderText = "Address3";
            this.address3DataGridViewTextBoxColumn.Name = "address3DataGridViewTextBoxColumn";
            this.address3DataGridViewTextBoxColumn.Visible = false;
            // 
            // address4DataGridViewTextBoxColumn
            // 
            this.address4DataGridViewTextBoxColumn.DataPropertyName = "Address4";
            this.address4DataGridViewTextBoxColumn.HeaderText = "Address4";
            this.address4DataGridViewTextBoxColumn.Name = "address4DataGridViewTextBoxColumn";
            this.address4DataGridViewTextBoxColumn.Visible = false;
            // 
            // address5DataGridViewTextBoxColumn
            // 
            this.address5DataGridViewTextBoxColumn.DataPropertyName = "Address5";
            this.address5DataGridViewTextBoxColumn.HeaderText = "Address5";
            this.address5DataGridViewTextBoxColumn.Name = "address5DataGridViewTextBoxColumn";
            this.address5DataGridViewTextBoxColumn.Visible = false;
            // 
            // bsRecords
            // 
            this.bsRecords.DataSource = typeof(Newcourt.Data.Data_PaymentStaging);
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnDelete});
            this.ucToolStrip1.Location = new System.Drawing.Point(3, 16);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Size = new System.Drawing.Size(912, 25);
            this.ucToolStrip1.TabIndex = 1;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCreateFile);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 259);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(918, 32);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFile.Location = new System.Drawing.Point(836, 4);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "xml";
            this.dlgSaveFile.Filter = "XML file | *.xml";
            // 
            // cmsRecords
            // 
            this.cmsRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDelete});
            this.cmsRecords.Name = "cmsRecords";
            this.cmsRecords.Size = new System.Drawing.Size(108, 26);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelete.Image")));
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(107, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // PaymentsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSuppliers);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.pnlBottom);
            this.Name = "PaymentsCtrl";
            this.Size = new System.Drawing.Size(918, 291);
            this.Tag = "SEPA Payments Wizard";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).EndInit();
            this.grpSuppliers.ResumeLayout(false);
            this.grpSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).EndInit();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.cmsRecords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.BindingSource bsSupplierTypes;
        private System.Windows.Forms.GroupBox grpSuppliers;
        private System.Windows.Forms.DataGridView grdRecords;
        private System.Windows.Forms.BindingSource bsRecords;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox luBankAccounts;
        private System.Windows.Forms.BindingSource bsBankAccounts;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private UCToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address5DataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsRecords;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}
