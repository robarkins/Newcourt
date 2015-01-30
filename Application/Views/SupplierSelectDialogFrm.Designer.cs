namespace Newcourt.Views
{
    partial class SupplierSelectDialogFrm
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
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.luSupplierType = new System.Windows.Forms.ComboBox();
            this.bsSupplierTypes = new System.Windows.Forms.BindingSource(this.components);
            this.lblSupplierType = new System.Windows.Forms.Label();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.grpSuppliers = new System.Windows.Forms.GroupBox();
            this.grdSuppliers = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSuppliers = new System.Windows.Forms.BindingSource(this.components);
            this.btnMarkAll = new System.Windows.Forms.Button();
            this.btnUnmarkAll = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).BeginInit();
            this.grpSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpSuppliers);
            this.pnlContent.Controls.Add(this.grpFilters);
            this.pnlContent.Size = new System.Drawing.Size(852, 230);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnUnmarkAll);
            this.pnlBottom.Controls.Add(this.btnMarkAll);
            this.pnlBottom.Size = new System.Drawing.Size(852, 32);
            this.pnlBottom.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlBottom.Controls.SetChildIndex(this.btnSave, 0);
            this.pnlBottom.Controls.SetChildIndex(this.btnMarkAll, 0);
            this.pnlBottom.Controls.SetChildIndex(this.btnUnmarkAll, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(689, 5);
            this.btnSave.Text = "Add";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(770, 5);
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnRefresh);
            this.grpFilters.Controls.Add(this.luSupplierType);
            this.grpFilters.Controls.Add(this.lblSupplierType);
            this.grpFilters.Controls.Add(this.txtSearchKeyword);
            this.grpFilters.Controls.Add(this.lblSearchKeyword);
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilters.Location = new System.Drawing.Point(0, 0);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(852, 53);
            this.grpFilters.TabIndex = 0;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(770, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // luSupplierType
            // 
            this.luSupplierType.DataSource = this.bsSupplierTypes;
            this.luSupplierType.DisplayMember = "SupplierTypeCode";
            this.luSupplierType.FormattingEnabled = true;
            this.luSupplierType.Location = new System.Drawing.Point(402, 23);
            this.luSupplierType.Name = "luSupplierType";
            this.luSupplierType.Size = new System.Drawing.Size(121, 21);
            this.luSupplierType.TabIndex = 3;
            this.luSupplierType.ValueMember = "SupplierTypeCode";
            this.luSupplierType.Leave += new System.EventHandler(this.luSupplierType_Leave);
            // 
            // bsSupplierTypes
            // 
            this.bsSupplierTypes.DataSource = typeof(Newcourt.Data.Data_SupplierType);
            // 
            // lblSupplierType
            // 
            this.lblSupplierType.AutoSize = true;
            this.lblSupplierType.Location = new System.Drawing.Point(310, 26);
            this.lblSupplierType.Name = "lblSupplierType";
            this.lblSupplierType.Size = new System.Drawing.Size(75, 13);
            this.lblSupplierType.TabIndex = 2;
            this.lblSupplierType.Text = "Supplier Type:";
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(117, 23);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(160, 20);
            this.txtSearchKeyword.TabIndex = 1;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Location = new System.Drawing.Point(8, 26);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(88, 13);
            this.lblSearchKeyword.TabIndex = 0;
            this.lblSearchKeyword.Text = "Search Keyword:";
            // 
            // grpSuppliers
            // 
            this.grpSuppliers.Controls.Add(this.grdSuppliers);
            this.grpSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSuppliers.Location = new System.Drawing.Point(0, 53);
            this.grpSuppliers.Name = "grpSuppliers";
            this.grpSuppliers.Size = new System.Drawing.Size(852, 177);
            this.grpSuppliers.TabIndex = 1;
            this.grpSuppliers.TabStop = false;
            this.grpSuppliers.Text = "Suppliers";
            // 
            // grdSuppliers
            // 
            this.grdSuppliers.AllowUserToAddRows = false;
            this.grdSuppliers.AllowUserToDeleteRows = false;
            this.grdSuppliers.AllowUserToResizeRows = false;
            this.grdSuppliers.AutoGenerateColumns = false;
            this.grdSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.supplierTypeCodeDataGridViewTextBoxColumn,
            this.Selected,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.address4DataGridViewTextBoxColumn,
            this.address5DataGridViewTextBoxColumn});
            this.grdSuppliers.DataSource = this.bsSuppliers;
            this.grdSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSuppliers.Location = new System.Drawing.Point(3, 16);
            this.grdSuppliers.Name = "grdSuppliers";
            this.grdSuppliers.RowHeadersVisible = false;
            this.grdSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSuppliers.Size = new System.Drawing.Size(846, 158);
            this.grdSuppliers.TabIndex = 0;
            this.grdSuppliers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdSuppliers_CellFormatting);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 30F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierTypeCodeDataGridViewTextBoxColumn
            // 
            this.supplierTypeCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "SupplierTypeCode";
            this.supplierTypeCodeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.supplierTypeCodeDataGridViewTextBoxColumn.HeaderText = "Supplier Type";
            this.supplierTypeCodeDataGridViewTextBoxColumn.Name = "supplierTypeCodeDataGridViewTextBoxColumn";
            // 
            // Selected
            // 
            this.Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Selected.FillWeight = 5F;
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
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
            // bsSuppliers
            // 
            this.bsSuppliers.DataSource = typeof(Newcourt.Data.Data_Supplier);
            // 
            // btnMarkAll
            // 
            this.btnMarkAll.Location = new System.Drawing.Point(11, 5);
            this.btnMarkAll.Name = "btnMarkAll";
            this.btnMarkAll.Size = new System.Drawing.Size(75, 23);
            this.btnMarkAll.TabIndex = 2;
            this.btnMarkAll.Text = "Mark All";
            this.btnMarkAll.UseVisualStyleBackColor = true;
            this.btnMarkAll.Click += new System.EventHandler(this.btnMarkAll_Click);
            // 
            // btnUnmarkAll
            // 
            this.btnUnmarkAll.Location = new System.Drawing.Point(92, 5);
            this.btnUnmarkAll.Name = "btnUnmarkAll";
            this.btnUnmarkAll.Size = new System.Drawing.Size(75, 23);
            this.btnUnmarkAll.TabIndex = 3;
            this.btnUnmarkAll.Text = "Unmark All";
            this.btnUnmarkAll.UseVisualStyleBackColor = true;
            this.btnUnmarkAll.Click += new System.EventHandler(this.btnUnmarkAll_Click);
            // 
            // SupplierSelectDialogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 262);
            this.Name = "SupplierSelectDialogFrm";
            this.Text = "Add Suppliers to Payment File";
            this.pnlContent.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).EndInit();
            this.grpSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.GroupBox grpSuppliers;
        private System.Windows.Forms.DataGridView grdSuppliers;
        private System.Windows.Forms.Label lblSupplierType;
        private System.Windows.Forms.ComboBox luSupplierType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bsSupplierTypes;
        private System.Windows.Forms.BindingSource bsSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address5DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMarkAll;
        private System.Windows.Forms.Button btnUnmarkAll;
    }
}