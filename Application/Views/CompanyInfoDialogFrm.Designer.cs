namespace Newcourt.Views
{
    partial class CompanyInfoDialogFrm
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
      this.grpCompanyInfo = new System.Windows.Forms.GroupBox();
      this.lbPhone = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.lblVatRegNo = new System.Windows.Forms.Label();
      this.txtVatRegNo = new System.Windows.Forms.TextBox();
      this.txtAddress5 = new System.Windows.Forms.TextBox();
      this.txtAddress4 = new System.Windows.Forms.TextBox();
      this.txtAddress3 = new System.Windows.Forms.TextBox();
      this.txtAddress2 = new System.Windows.Forms.TextBox();
      this.txtAddress1 = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.txtCompanyName = new System.Windows.Forms.TextBox();
      this.lblCompanyName = new System.Windows.Forms.Label();
      this.grpSystemParameters = new System.Windows.Forms.GroupBox();
      this.txtDatabaseVersion = new System.Windows.Forms.TextBox();
      this.lblDatabaseVersion = new System.Windows.Forms.Label();
      this.txtSepaFileCount = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkHideSupplierFields = new System.Windows.Forms.CheckBox();
      this.pnlContent.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.grpCompanyInfo.SuspendLayout();
      this.grpSystemParameters.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContent
      // 
      this.pnlContent.Controls.Add(this.grpSystemParameters);
      this.pnlContent.Controls.Add(this.grpCompanyInfo);
      this.pnlContent.Size = new System.Drawing.Size(607, 228);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 228);
      this.pnlBottom.Size = new System.Drawing.Size(607, 32);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(441, 5);
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(522, 5);
      // 
      // grpCompanyInfo
      // 
      this.grpCompanyInfo.Controls.Add(this.lbPhone);
      this.grpCompanyInfo.Controls.Add(this.txtPhone);
      this.grpCompanyInfo.Controls.Add(this.lblVatRegNo);
      this.grpCompanyInfo.Controls.Add(this.txtVatRegNo);
      this.grpCompanyInfo.Controls.Add(this.txtAddress5);
      this.grpCompanyInfo.Controls.Add(this.txtAddress4);
      this.grpCompanyInfo.Controls.Add(this.txtAddress3);
      this.grpCompanyInfo.Controls.Add(this.txtAddress2);
      this.grpCompanyInfo.Controls.Add(this.txtAddress1);
      this.grpCompanyInfo.Controls.Add(this.lblAddress);
      this.grpCompanyInfo.Controls.Add(this.txtCompanyName);
      this.grpCompanyInfo.Controls.Add(this.lblCompanyName);
      this.grpCompanyInfo.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpCompanyInfo.Location = new System.Drawing.Point(0, 0);
      this.grpCompanyInfo.Name = "grpCompanyInfo";
      this.grpCompanyInfo.Size = new System.Drawing.Size(607, 154);
      this.grpCompanyInfo.TabIndex = 0;
      this.grpCompanyInfo.TabStop = false;
      this.grpCompanyInfo.Text = "Company Details";
      // 
      // lbPhone
      // 
      this.lbPhone.AutoSize = true;
      this.lbPhone.Location = new System.Drawing.Point(8, 54);
      this.lbPhone.Name = "lbPhone";
      this.lbPhone.Size = new System.Drawing.Size(41, 13);
      this.lbPhone.TabIndex = 12;
      this.lbPhone.Text = "Phone:";
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(130, 51);
      this.txtPhone.MaxLength = 15;
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(148, 20);
      this.txtPhone.TabIndex = 1;
      // 
      // lblVatRegNo
      // 
      this.lblVatRegNo.AutoSize = true;
      this.lblVatRegNo.Location = new System.Drawing.Point(8, 80);
      this.lblVatRegNo.Name = "lblVatRegNo";
      this.lblVatRegNo.Size = new System.Drawing.Size(89, 13);
      this.lblVatRegNo.TabIndex = 10;
      this.lblVatRegNo.Text = "Vat Reg Number:";
      // 
      // txtVatRegNo
      // 
      this.txtVatRegNo.Location = new System.Drawing.Point(130, 77);
      this.txtVatRegNo.MaxLength = 15;
      this.txtVatRegNo.Name = "txtVatRegNo";
      this.txtVatRegNo.Size = new System.Drawing.Size(148, 20);
      this.txtVatRegNo.TabIndex = 2;
      // 
      // txtAddress5
      // 
      this.txtAddress5.Location = new System.Drawing.Point(449, 129);
      this.txtAddress5.MaxLength = 70;
      this.txtAddress5.Name = "txtAddress5";
      this.txtAddress5.Size = new System.Drawing.Size(148, 20);
      this.txtAddress5.TabIndex = 7;
      // 
      // txtAddress4
      // 
      this.txtAddress4.Location = new System.Drawing.Point(449, 103);
      this.txtAddress4.MaxLength = 70;
      this.txtAddress4.Name = "txtAddress4";
      this.txtAddress4.Size = new System.Drawing.Size(148, 20);
      this.txtAddress4.TabIndex = 6;
      // 
      // txtAddress3
      // 
      this.txtAddress3.Location = new System.Drawing.Point(449, 77);
      this.txtAddress3.MaxLength = 70;
      this.txtAddress3.Name = "txtAddress3";
      this.txtAddress3.Size = new System.Drawing.Size(148, 20);
      this.txtAddress3.TabIndex = 5;
      // 
      // txtAddress2
      // 
      this.txtAddress2.Location = new System.Drawing.Point(449, 51);
      this.txtAddress2.MaxLength = 70;
      this.txtAddress2.Name = "txtAddress2";
      this.txtAddress2.Size = new System.Drawing.Size(148, 20);
      this.txtAddress2.TabIndex = 4;
      // 
      // txtAddress1
      // 
      this.txtAddress1.Location = new System.Drawing.Point(449, 25);
      this.txtAddress1.MaxLength = 70;
      this.txtAddress1.Name = "txtAddress1";
      this.txtAddress1.Size = new System.Drawing.Size(148, 20);
      this.txtAddress1.TabIndex = 3;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(336, 28);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(48, 13);
      this.lblAddress.TabIndex = 3;
      this.lblAddress.Text = "Address:";
      // 
      // txtCompanyName
      // 
      this.txtCompanyName.Location = new System.Drawing.Point(130, 25);
      this.txtCompanyName.MaxLength = 70;
      this.txtCompanyName.Name = "txtCompanyName";
      this.txtCompanyName.Size = new System.Drawing.Size(148, 20);
      this.txtCompanyName.TabIndex = 0;
      // 
      // lblCompanyName
      // 
      this.lblCompanyName.AutoSize = true;
      this.lblCompanyName.Location = new System.Drawing.Point(8, 28);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
      this.lblCompanyName.TabIndex = 0;
      this.lblCompanyName.Text = "Company Name:";
      // 
      // grpSystemParameters
      // 
      this.grpSystemParameters.Controls.Add(this.chkHideSupplierFields);
      this.grpSystemParameters.Controls.Add(this.txtDatabaseVersion);
      this.grpSystemParameters.Controls.Add(this.lblDatabaseVersion);
      this.grpSystemParameters.Controls.Add(this.txtSepaFileCount);
      this.grpSystemParameters.Controls.Add(this.label1);
      this.grpSystemParameters.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpSystemParameters.Location = new System.Drawing.Point(0, 154);
      this.grpSystemParameters.Name = "grpSystemParameters";
      this.grpSystemParameters.Size = new System.Drawing.Size(607, 74);
      this.grpSystemParameters.TabIndex = 1;
      this.grpSystemParameters.TabStop = false;
      this.grpSystemParameters.Text = "System Parameters";
      // 
      // txtDatabaseVersion
      // 
      this.txtDatabaseVersion.Location = new System.Drawing.Point(449, 25);
      this.txtDatabaseVersion.Name = "txtDatabaseVersion";
      this.txtDatabaseVersion.ReadOnly = true;
      this.txtDatabaseVersion.Size = new System.Drawing.Size(148, 20);
      this.txtDatabaseVersion.TabIndex = 3;
      // 
      // lblDatabaseVersion
      // 
      this.lblDatabaseVersion.AutoSize = true;
      this.lblDatabaseVersion.Location = new System.Drawing.Point(336, 29);
      this.lblDatabaseVersion.Name = "lblDatabaseVersion";
      this.lblDatabaseVersion.Size = new System.Drawing.Size(94, 13);
      this.lblDatabaseVersion.TabIndex = 2;
      this.lblDatabaseVersion.Text = "Database Version:";
      // 
      // txtSepaFileCount
      // 
      this.txtSepaFileCount.Location = new System.Drawing.Point(130, 25);
      this.txtSepaFileCount.Name = "txtSepaFileCount";
      this.txtSepaFileCount.ReadOnly = true;
      this.txtSepaFileCount.Size = new System.Drawing.Size(100, 20);
      this.txtSepaFileCount.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "SEPA File Count:";
      // 
      // chkHideSupplierFields
      // 
      this.chkHideSupplierFields.Location = new System.Drawing.Point(7, 48);
      this.chkHideSupplierFields.Name = "chkHideSupplierFields";
      this.chkHideSupplierFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.chkHideSupplierFields.Size = new System.Drawing.Size(223, 24);
      this.chkHideSupplierFields.TabIndex = 4;
      this.chkHideSupplierFields.Text = ":Hide Sensitive Supplier Fields";
      this.chkHideSupplierFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkHideSupplierFields.UseVisualStyleBackColor = true;
      // 
      // CompanyInfoDialogFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(607, 260);
      this.Name = "CompanyInfoDialogFrm";
      this.Text = "Company Information";
      this.pnlContent.ResumeLayout(false);
      this.pnlBottom.ResumeLayout(false);
      this.grpCompanyInfo.ResumeLayout(false);
      this.grpCompanyInfo.PerformLayout();
      this.grpSystemParameters.ResumeLayout(false);
      this.grpSystemParameters.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompanyInfo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress4;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress5;
        private System.Windows.Forms.TextBox txtVatRegNo;
        private System.Windows.Forms.Label lblVatRegNo;
        private System.Windows.Forms.GroupBox grpSystemParameters;
        private System.Windows.Forms.TextBox txtSepaFileCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDatabaseVersion;
        private System.Windows.Forms.Label lblDatabaseVersion;
        private System.Windows.Forms.CheckBox chkHideSupplierFields;
    }
}