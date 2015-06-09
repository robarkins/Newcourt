namespace Newcourt.Controls {
  partial class SupplierBrowseCtrl {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierBrowseCtrl));
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.txtSearchTerm = new System.Windows.Forms.TextBox();
      this.lblSearchKeyword = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
      this.grpRecords.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
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
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
      this.grdRecords.Location = new System.Drawing.Point(3, 53);
      this.grdRecords.Size = new System.Drawing.Size(520, 178);
      this.grdRecords.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdRecords_ColumnHeaderMouseClick);
      this.grdRecords.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdRecords_DataBindingComplete);
      // 
      // grpRecords
      // 
      this.grpRecords.Controls.Add(this.panel1);
      this.grpRecords.Text = "Supplier Records";
      this.grpRecords.Controls.SetChildIndex(this.panel1, 0);
      this.grpRecords.Controls.SetChildIndex(this.grdRecords, 0);
      // 
      // bsRecords
      // 
      this.bsRecords.DataSource = typeof(Newcourt.Data.Data_Supplier);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierID";
      this.dataGridViewTextBoxColumn1.FillWeight = 8F;
      this.dataGridViewTextBoxColumn1.HeaderText = "Supplier ID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierTypeCode";
      this.dataGridViewTextBoxColumn2.HeaderText = "SupplierTypeCode";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Visible = false;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn3.FillWeight = 15F;
      this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Surname";
      this.dataGridViewTextBoxColumn4.FillWeight = 15F;
      this.dataGridViewTextBoxColumn4.HeaderText = "Surname";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Address1";
      this.dataGridViewTextBoxColumn5.HeaderText = "Address1";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Visible = false;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "Address2";
      this.dataGridViewTextBoxColumn6.HeaderText = "Address2";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Visible = false;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Address3";
      this.dataGridViewTextBoxColumn7.HeaderText = "Address3";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.Visible = false;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "Address4";
      this.dataGridViewTextBoxColumn8.HeaderText = "Address4";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.Visible = false;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "Address5";
      this.dataGridViewTextBoxColumn9.HeaderText = "Address5";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.Visible = false;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone";
      this.dataGridViewTextBoxColumn10.HeaderText = "Phone";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.Visible = false;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "Mobile";
      this.dataGridViewTextBoxColumn11.HeaderText = "Mobile";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.Visible = false;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "PPSVat";
      this.dataGridViewTextBoxColumn12.HeaderText = "PPSVat";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.Visible = false;
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "BankName";
      this.dataGridViewTextBoxColumn13.HeaderText = "BankName";
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.Visible = false;
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "BankAddress1";
      this.dataGridViewTextBoxColumn14.HeaderText = "BankAddress1";
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewTextBoxColumn14.Visible = false;
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.DataPropertyName = "BankAddress2";
      this.dataGridViewTextBoxColumn15.HeaderText = "BankAddress2";
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      this.dataGridViewTextBoxColumn15.Visible = false;
      // 
      // dataGridViewTextBoxColumn16
      // 
      this.dataGridViewTextBoxColumn16.DataPropertyName = "BankAddress3";
      this.dataGridViewTextBoxColumn16.HeaderText = "BankAddress3";
      this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
      this.dataGridViewTextBoxColumn16.Visible = false;
      // 
      // dataGridViewTextBoxColumn17
      // 
      this.dataGridViewTextBoxColumn17.DataPropertyName = "BankAddress4";
      this.dataGridViewTextBoxColumn17.HeaderText = "BankAddress4";
      this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
      this.dataGridViewTextBoxColumn17.Visible = false;
      // 
      // dataGridViewTextBoxColumn18
      // 
      this.dataGridViewTextBoxColumn18.DataPropertyName = "BankAddress5";
      this.dataGridViewTextBoxColumn18.HeaderText = "BankAddress5";
      this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
      this.dataGridViewTextBoxColumn18.Visible = false;
      // 
      // dataGridViewTextBoxColumn19
      // 
      this.dataGridViewTextBoxColumn19.DataPropertyName = "BankAccNumber";
      this.dataGridViewTextBoxColumn19.HeaderText = "BankAccNumber";
      this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
      this.dataGridViewTextBoxColumn19.Visible = false;
      // 
      // dataGridViewTextBoxColumn20
      // 
      this.dataGridViewTextBoxColumn20.DataPropertyName = "SortCode";
      this.dataGridViewTextBoxColumn20.HeaderText = "SortCode";
      this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
      this.dataGridViewTextBoxColumn20.Visible = false;
      // 
      // dataGridViewTextBoxColumn21
      // 
      this.dataGridViewTextBoxColumn21.DataPropertyName = "BIC";
      this.dataGridViewTextBoxColumn21.HeaderText = "BIC";
      this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
      this.dataGridViewTextBoxColumn21.Visible = false;
      // 
      // dataGridViewTextBoxColumn22
      // 
      this.dataGridViewTextBoxColumn22.DataPropertyName = "IBAN";
      this.dataGridViewTextBoxColumn22.HeaderText = "IBAN";
      this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
      this.dataGridViewTextBoxColumn22.Visible = false;
      // 
      // dataGridViewTextBoxColumn23
      // 
      this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn23.DataPropertyName = "SupplierTypeName";
      this.dataGridViewTextBoxColumn23.FillWeight = 22F;
      this.dataGridViewTextBoxColumn23.HeaderText = "Supplier Type";
      this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
      // 
      // dataGridViewTextBoxColumn24
      // 
      this.dataGridViewTextBoxColumn24.DataPropertyName = "PaymentAmount";
      this.dataGridViewTextBoxColumn24.HeaderText = "PaymentAmount";
      this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
      this.dataGridViewTextBoxColumn24.Visible = false;
      // 
      // dataGridViewCheckBoxColumn1
      // 
      this.dataGridViewCheckBoxColumn1.DataPropertyName = "PaymentExists";
      this.dataGridViewCheckBoxColumn1.HeaderText = "PaymentExists";
      this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
      this.dataGridViewCheckBoxColumn1.Visible = false;
      // 
      // dataGridViewCheckBoxColumn3
      // 
      this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsValidForPayment";
      this.dataGridViewCheckBoxColumn3.HeaderText = "IsValidForPayment";
      this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
      this.dataGridViewCheckBoxColumn3.Visible = false;
      // 
      // dataGridViewTextBoxColumn25
      // 
      this.dataGridViewTextBoxColumn25.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn25.HeaderText = "Name";
      this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
      this.dataGridViewTextBoxColumn25.ReadOnly = true;
      this.dataGridViewTextBoxColumn25.Visible = false;
      // 
      // dataGridViewTextBoxColumn26
      // 
      this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn26.DataPropertyName = "Address";
      this.dataGridViewTextBoxColumn26.FillWeight = 40F;
      this.dataGridViewTextBoxColumn26.HeaderText = "Address";
      this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
      this.dataGridViewTextBoxColumn26.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn27
      // 
      this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn27.DataPropertyName = "BIC";
      this.dataGridViewTextBoxColumn27.FillWeight = 20F;
      this.dataGridViewTextBoxColumn27.HeaderText = "BIC";
      this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
      this.dataGridViewTextBoxColumn27.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn28
      // 
      this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn28.DataPropertyName = "IBAN";
      this.dataGridViewTextBoxColumn28.FillWeight = 20F;
      this.dataGridViewTextBoxColumn28.HeaderText = "IBAN";
      this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
      this.dataGridViewTextBoxColumn28.ReadOnly = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnRefresh);
      this.panel1.Controls.Add(this.txtSearchTerm);
      this.panel1.Controls.Add(this.lblSearchKeyword);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(520, 37);
      this.panel1.TabIndex = 1;
      // 
      // btnRefresh
      // 
      this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
      this.btnRefresh.Location = new System.Drawing.Point(355, 7);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 24);
      this.btnRefresh.TabIndex = 2;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // txtSearchTerm
      // 
      this.txtSearchTerm.Location = new System.Drawing.Point(117, 9);
      this.txtSearchTerm.Name = "txtSearchTerm";
      this.txtSearchTerm.Size = new System.Drawing.Size(167, 20);
      this.txtSearchTerm.TabIndex = 1;
      // 
      // lblSearchKeyword
      // 
      this.lblSearchKeyword.AutoSize = true;
      this.lblSearchKeyword.Location = new System.Drawing.Point(8, 12);
      this.lblSearchKeyword.Name = "lblSearchKeyword";
      this.lblSearchKeyword.Size = new System.Drawing.Size(88, 13);
      this.lblSearchKeyword.TabIndex = 0;
      this.lblSearchKeyword.Text = "Search Keyword:";
      // 
      // SupplierBrowseCtrl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "SupplierBrowseCtrl";
      this.Tag = "Supplier Accounts";
      this.Controls.SetChildIndex(this.grpRecords, 0);
      ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
      this.grpRecords.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtSearchTerm;
    private System.Windows.Forms.Label lblSearchKeyword;
    private System.Windows.Forms.Button btnRefresh;
  }
}
