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
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.luBankAccounts = new System.Windows.Forms.ComboBox();
            this.bsBankAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.lblBank = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.luSupplierTypes = new System.Windows.Forms.ComboBox();
            this.bsSupplierTypes = new System.Windows.Forms.BindingSource(this.components);
            this.lblSupplierTypes = new System.Windows.Forms.Label();
            this.grpSuppliers = new System.Windows.Forms.GroupBox();
            this.grdRecords = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPSVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAddress3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAddress4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAddress5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRecords = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).BeginInit();
            this.grpSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.lblPaymentDate);
            this.grpOptions.Controls.Add(this.dtPaymentDate);
            this.grpOptions.Controls.Add(this.luBankAccounts);
            this.grpOptions.Controls.Add(this.lblBank);
            this.grpOptions.Controls.Add(this.btnRefresh);
            this.grpOptions.Controls.Add(this.luSupplierTypes);
            this.grpOptions.Controls.Add(this.lblSupplierTypes);
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
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(837, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // luSupplierTypes
            // 
            this.luSupplierTypes.DataSource = this.bsSupplierTypes;
            this.luSupplierTypes.DisplayMember = "SupplierTypeCode";
            this.luSupplierTypes.FormattingEnabled = true;
            this.luSupplierTypes.Location = new System.Drawing.Point(609, 26);
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
            // lblSupplierTypes
            // 
            this.lblSupplierTypes.AutoSize = true;
            this.lblSupplierTypes.Location = new System.Drawing.Point(511, 30);
            this.lblSupplierTypes.Name = "lblSupplierTypes";
            this.lblSupplierTypes.Size = new System.Drawing.Size(80, 13);
            this.lblSupplierTypes.TabIndex = 0;
            this.lblSupplierTypes.Text = "Supplier Types:";
            // 
            // grpSuppliers
            // 
            this.grpSuppliers.Controls.Add(this.grdRecords);
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
            this.supplierIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.supplierTypeCodeDataGridViewTextBoxColumn,
            this.PaymentAmount,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.address4DataGridViewTextBoxColumn,
            this.address5DataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.pPSVatDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.bankAddress1DataGridViewTextBoxColumn,
            this.bankAddress2DataGridViewTextBoxColumn,
            this.bankAddress3DataGridViewTextBoxColumn,
            this.bankAddress4DataGridViewTextBoxColumn,
            this.bankAddress5DataGridViewTextBoxColumn,
            this.bankAccNumberDataGridViewTextBoxColumn,
            this.sortCodeDataGridViewTextBoxColumn,
            this.bICDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.supplierTypeNameDataGridViewTextBoxColumn});
            this.grdRecords.DataSource = this.bsRecords;
            this.grdRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRecords.Location = new System.Drawing.Point(3, 16);
            this.grdRecords.Name = "grdRecords";
            this.grdRecords.RowHeadersVisible = false;
            this.grdRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdRecords.Size = new System.Drawing.Size(912, 181);
            this.grdRecords.TabIndex = 0;
            this.grdRecords.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecords_CellEnter);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.PaymentAmount.DataPropertyName = "PaymentAmount";
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
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Visible = false;
            // 
            // pPSVatDataGridViewTextBoxColumn
            // 
            this.pPSVatDataGridViewTextBoxColumn.DataPropertyName = "PPSVat";
            this.pPSVatDataGridViewTextBoxColumn.HeaderText = "PPSVat";
            this.pPSVatDataGridViewTextBoxColumn.Name = "pPSVatDataGridViewTextBoxColumn";
            this.pPSVatDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAddress1DataGridViewTextBoxColumn
            // 
            this.bankAddress1DataGridViewTextBoxColumn.DataPropertyName = "BankAddress1";
            this.bankAddress1DataGridViewTextBoxColumn.HeaderText = "BankAddress1";
            this.bankAddress1DataGridViewTextBoxColumn.Name = "bankAddress1DataGridViewTextBoxColumn";
            this.bankAddress1DataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAddress2DataGridViewTextBoxColumn
            // 
            this.bankAddress2DataGridViewTextBoxColumn.DataPropertyName = "BankAddress2";
            this.bankAddress2DataGridViewTextBoxColumn.HeaderText = "BankAddress2";
            this.bankAddress2DataGridViewTextBoxColumn.Name = "bankAddress2DataGridViewTextBoxColumn";
            this.bankAddress2DataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAddress3DataGridViewTextBoxColumn
            // 
            this.bankAddress3DataGridViewTextBoxColumn.DataPropertyName = "BankAddress3";
            this.bankAddress3DataGridViewTextBoxColumn.HeaderText = "BankAddress3";
            this.bankAddress3DataGridViewTextBoxColumn.Name = "bankAddress3DataGridViewTextBoxColumn";
            this.bankAddress3DataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAddress4DataGridViewTextBoxColumn
            // 
            this.bankAddress4DataGridViewTextBoxColumn.DataPropertyName = "BankAddress4";
            this.bankAddress4DataGridViewTextBoxColumn.HeaderText = "BankAddress4";
            this.bankAddress4DataGridViewTextBoxColumn.Name = "bankAddress4DataGridViewTextBoxColumn";
            this.bankAddress4DataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAddress5DataGridViewTextBoxColumn
            // 
            this.bankAddress5DataGridViewTextBoxColumn.DataPropertyName = "BankAddress5";
            this.bankAddress5DataGridViewTextBoxColumn.HeaderText = "BankAddress5";
            this.bankAddress5DataGridViewTextBoxColumn.Name = "bankAddress5DataGridViewTextBoxColumn";
            this.bankAddress5DataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAccNumberDataGridViewTextBoxColumn
            // 
            this.bankAccNumberDataGridViewTextBoxColumn.DataPropertyName = "BankAccNumber";
            this.bankAccNumberDataGridViewTextBoxColumn.HeaderText = "BankAccNumber";
            this.bankAccNumberDataGridViewTextBoxColumn.Name = "bankAccNumberDataGridViewTextBoxColumn";
            this.bankAccNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // sortCodeDataGridViewTextBoxColumn
            // 
            this.sortCodeDataGridViewTextBoxColumn.DataPropertyName = "SortCode";
            this.sortCodeDataGridViewTextBoxColumn.HeaderText = "SortCode";
            this.sortCodeDataGridViewTextBoxColumn.Name = "sortCodeDataGridViewTextBoxColumn";
            this.sortCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // bICDataGridViewTextBoxColumn
            // 
            this.bICDataGridViewTextBoxColumn.DataPropertyName = "BIC";
            this.bICDataGridViewTextBoxColumn.HeaderText = "BIC";
            this.bICDataGridViewTextBoxColumn.Name = "bICDataGridViewTextBoxColumn";
            this.bICDataGridViewTextBoxColumn.Visible = false;
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            this.iBANDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierTypeNameDataGridViewTextBoxColumn
            // 
            this.supplierTypeNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierTypeName";
            this.supplierTypeNameDataGridViewTextBoxColumn.HeaderText = "SupplierTypeName";
            this.supplierTypeNameDataGridViewTextBoxColumn.Name = "supplierTypeNameDataGridViewTextBoxColumn";
            this.supplierTypeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsRecords
            // 
            this.bsRecords.DataSource = typeof(Newcourt.Data.Data_Supplier);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblSupplierTypes;
        private System.Windows.Forms.ComboBox luSupplierTypes;
        private System.Windows.Forms.BindingSource bsSupplierTypes;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpSuppliers;
        private System.Windows.Forms.DataGridView grdRecords;
        private System.Windows.Forms.BindingSource bsRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPSVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAddress3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAddress4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAddress5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox luBankAccounts;
        private System.Windows.Forms.BindingSource bsBankAccounts;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
    }
}
