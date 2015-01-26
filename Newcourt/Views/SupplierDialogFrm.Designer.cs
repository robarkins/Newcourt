namespace Newcourt.Views
{
    partial class SupplierDialogFrm
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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblSupplierType = new System.Windows.Forms.Label();
            this.luSupplierType = new System.Windows.Forms.ComboBox();
            this.bsSupplierTypes = new System.Windows.Forms.BindingSource(this.components);
            this.lblPPSVat = new System.Windows.Forms.Label();
            this.txtPPSVat = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress5 = new System.Windows.Forms.TextBox();
            this.txtAddress4 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpBankDetails = new System.Windows.Forms.GroupBox();
            this.txtBankAddress5 = new System.Windows.Forms.TextBox();
            this.txtBankAddress4 = new System.Windows.Forms.TextBox();
            this.txtBankAddress3 = new System.Windows.Forms.TextBox();
            this.txtBankAddress2 = new System.Windows.Forms.TextBox();
            this.txtBankAddress1 = new System.Windows.Forms.TextBox();
            this.lblBankAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.lblBIC = new System.Windows.Forms.Label();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.lblBankAccNumber = new System.Windows.Forms.Label();
            this.txtBankAccNumber = new System.Windows.Forms.TextBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.pnlContent.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).BeginInit();
            this.grpBankDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpBankDetails);
            this.pnlContent.Controls.Add(this.grpDetails);
            this.pnlContent.Size = new System.Drawing.Size(554, 341);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 341);
            this.pnlBottom.Size = new System.Drawing.Size(554, 32);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(389, 6);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 6);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblSupplierType);
            this.grpDetails.Controls.Add(this.luSupplierType);
            this.grpDetails.Controls.Add(this.lblPPSVat);
            this.grpDetails.Controls.Add(this.txtPPSVat);
            this.grpDetails.Controls.Add(this.lblMobile);
            this.grpDetails.Controls.Add(this.txtMobile);
            this.grpDetails.Controls.Add(this.lblPhone);
            this.grpDetails.Controls.Add(this.txtPhone);
            this.grpDetails.Controls.Add(this.txtAddress5);
            this.grpDetails.Controls.Add(this.txtAddress4);
            this.grpDetails.Controls.Add(this.txtAddress3);
            this.grpDetails.Controls.Add(this.txtAddress2);
            this.grpDetails.Controls.Add(this.lblAddress1);
            this.grpDetails.Controls.Add(this.txtAddress1);
            this.grpDetails.Controls.Add(this.txtSurname);
            this.grpDetails.Controls.Add(this.lblSurname);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDetails.Location = new System.Drawing.Point(0, 0);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(554, 185);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Supplier Details";
            // 
            // lblSupplierType
            // 
            this.lblSupplierType.AutoSize = true;
            this.lblSupplierType.Location = new System.Drawing.Point(8, 158);
            this.lblSupplierType.Name = "lblSupplierType";
            this.lblSupplierType.Size = new System.Drawing.Size(75, 13);
            this.lblSupplierType.TabIndex = 17;
            this.lblSupplierType.Text = "Supplier Type:";
            // 
            // luSupplierType
            // 
            this.luSupplierType.DataSource = this.bsSupplierTypes;
            this.luSupplierType.DisplayMember = "SupplierTypeCode";
            this.luSupplierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.luSupplierType.FormattingEnabled = true;
            this.luSupplierType.Location = new System.Drawing.Point(130, 155);
            this.luSupplierType.Name = "luSupplierType";
            this.luSupplierType.Size = new System.Drawing.Size(148, 21);
            this.luSupplierType.TabIndex = 6;
            this.luSupplierType.ValueMember = "SupplierTypeCode";
            // 
            // bsSupplierTypes
            // 
            this.bsSupplierTypes.DataSource = typeof(Newcourt.Data.Data_SupplierType);
            // 
            // lblPPSVat
            // 
            this.lblPPSVat.AutoSize = true;
            this.lblPPSVat.Location = new System.Drawing.Point(8, 132);
            this.lblPPSVat.Name = "lblPPSVat";
            this.lblPPSVat.Size = new System.Drawing.Size(103, 13);
            this.lblPPSVat.TabIndex = 15;
            this.lblPPSVat.Text = "PPS / VAT Number:";
            // 
            // txtPPSVat
            // 
            this.txtPPSVat.Location = new System.Drawing.Point(130, 129);
            this.txtPPSVat.MaxLength = 15;
            this.txtPPSVat.Name = "txtPPSVat";
            this.txtPPSVat.Size = new System.Drawing.Size(148, 20);
            this.txtPPSVat.TabIndex = 5;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(8, 106);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 13;
            this.lblMobile.Text = "Mobile:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(130, 103);
            this.txtMobile.MaxLength = 70;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(148, 20);
            this.txtMobile.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(130, 77);
            this.txtPhone.MaxLength = 70;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress5
            // 
            this.txtAddress5.Location = new System.Drawing.Point(396, 129);
            this.txtAddress5.MaxLength = 70;
            this.txtAddress5.Name = "txtAddress5";
            this.txtAddress5.Size = new System.Drawing.Size(148, 20);
            this.txtAddress5.TabIndex = 11;
            // 
            // txtAddress4
            // 
            this.txtAddress4.Location = new System.Drawing.Point(396, 103);
            this.txtAddress4.MaxLength = 70;
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.Size = new System.Drawing.Size(148, 20);
            this.txtAddress4.TabIndex = 10;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(396, 77);
            this.txtAddress3.MaxLength = 70;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(148, 20);
            this.txtAddress3.TabIndex = 9;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(396, 51);
            this.txtAddress2.MaxLength = 70;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(148, 20);
            this.txtAddress2.TabIndex = 8;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(324, 28);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(48, 13);
            this.lblAddress1.TabIndex = 5;
            this.lblAddress1.Text = "Address:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(396, 25);
            this.txtAddress1.MaxLength = 70;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(148, 20);
            this.txtAddress1.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 51);
            this.txtSurname.MaxLength = 70;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(148, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(8, 54);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 25);
            this.txtFirstName.MaxLength = 70;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(8, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // grpBankDetails
            // 
            this.grpBankDetails.Controls.Add(this.txtBankAddress5);
            this.grpBankDetails.Controls.Add(this.txtBankAddress4);
            this.grpBankDetails.Controls.Add(this.txtBankAddress3);
            this.grpBankDetails.Controls.Add(this.txtBankAddress2);
            this.grpBankDetails.Controls.Add(this.txtBankAddress1);
            this.grpBankDetails.Controls.Add(this.lblBankAddress);
            this.grpBankDetails.Controls.Add(this.label1);
            this.grpBankDetails.Controls.Add(this.txtIBAN);
            this.grpBankDetails.Controls.Add(this.lblBIC);
            this.grpBankDetails.Controls.Add(this.txtBIC);
            this.grpBankDetails.Controls.Add(this.lblSortCode);
            this.grpBankDetails.Controls.Add(this.txtSortCode);
            this.grpBankDetails.Controls.Add(this.lblBankAccNumber);
            this.grpBankDetails.Controls.Add(this.txtBankAccNumber);
            this.grpBankDetails.Controls.Add(this.lblBankName);
            this.grpBankDetails.Controls.Add(this.txtBankName);
            this.grpBankDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBankDetails.Location = new System.Drawing.Point(0, 185);
            this.grpBankDetails.Name = "grpBankDetails";
            this.grpBankDetails.Size = new System.Drawing.Size(554, 156);
            this.grpBankDetails.TabIndex = 1;
            this.grpBankDetails.TabStop = false;
            this.grpBankDetails.Text = "Bank Details";
            // 
            // txtBankAddress5
            // 
            this.txtBankAddress5.Location = new System.Drawing.Point(396, 129);
            this.txtBankAddress5.MaxLength = 70;
            this.txtBankAddress5.Name = "txtBankAddress5";
            this.txtBankAddress5.Size = new System.Drawing.Size(148, 20);
            this.txtBankAddress5.TabIndex = 32;
            // 
            // txtBankAddress4
            // 
            this.txtBankAddress4.Location = new System.Drawing.Point(396, 103);
            this.txtBankAddress4.MaxLength = 70;
            this.txtBankAddress4.Name = "txtBankAddress4";
            this.txtBankAddress4.Size = new System.Drawing.Size(148, 20);
            this.txtBankAddress4.TabIndex = 31;
            // 
            // txtBankAddress3
            // 
            this.txtBankAddress3.Location = new System.Drawing.Point(396, 77);
            this.txtBankAddress3.MaxLength = 70;
            this.txtBankAddress3.Name = "txtBankAddress3";
            this.txtBankAddress3.Size = new System.Drawing.Size(148, 20);
            this.txtBankAddress3.TabIndex = 30;
            // 
            // txtBankAddress2
            // 
            this.txtBankAddress2.Location = new System.Drawing.Point(396, 51);
            this.txtBankAddress2.MaxLength = 70;
            this.txtBankAddress2.Name = "txtBankAddress2";
            this.txtBankAddress2.Size = new System.Drawing.Size(148, 20);
            this.txtBankAddress2.TabIndex = 29;
            // 
            // txtBankAddress1
            // 
            this.txtBankAddress1.Location = new System.Drawing.Point(396, 25);
            this.txtBankAddress1.MaxLength = 70;
            this.txtBankAddress1.Name = "txtBankAddress1";
            this.txtBankAddress1.Size = new System.Drawing.Size(148, 20);
            this.txtBankAddress1.TabIndex = 28;
            // 
            // lblBankAddress
            // 
            this.lblBankAddress.AutoSize = true;
            this.lblBankAddress.Location = new System.Drawing.Point(324, 28);
            this.lblBankAddress.Name = "lblBankAddress";
            this.lblBankAddress.Size = new System.Drawing.Size(48, 13);
            this.lblBankAddress.TabIndex = 27;
            this.lblBankAddress.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "IBAN:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(130, 129);
            this.txtIBAN.MaxLength = 35;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(148, 20);
            this.txtIBAN.TabIndex = 25;
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(8, 106);
            this.lblBIC.Name = "lblBIC";
            this.lblBIC.Size = new System.Drawing.Size(27, 13);
            this.lblBIC.TabIndex = 24;
            this.lblBIC.Text = "BIC:";
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(130, 103);
            this.txtBIC.MaxLength = 11;
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(148, 20);
            this.txtBIC.TabIndex = 23;
            // 
            // lblSortCode
            // 
            this.lblSortCode.AutoSize = true;
            this.lblSortCode.Location = new System.Drawing.Point(8, 80);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(57, 13);
            this.lblSortCode.TabIndex = 22;
            this.lblSortCode.Text = "Sort Code:";
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(130, 77);
            this.txtSortCode.MaxLength = 15;
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(148, 20);
            this.txtSortCode.TabIndex = 21;
            // 
            // lblBankAccNumber
            // 
            this.lblBankAccNumber.AutoSize = true;
            this.lblBankAccNumber.Location = new System.Drawing.Point(8, 54);
            this.lblBankAccNumber.Name = "lblBankAccNumber";
            this.lblBankAccNumber.Size = new System.Drawing.Size(90, 13);
            this.lblBankAccNumber.TabIndex = 20;
            this.lblBankAccNumber.Text = "Account Number:";
            // 
            // txtBankAccNumber
            // 
            this.txtBankAccNumber.Location = new System.Drawing.Point(130, 51);
            this.txtBankAccNumber.MaxLength = 15;
            this.txtBankAccNumber.Name = "txtBankAccNumber";
            this.txtBankAccNumber.Size = new System.Drawing.Size(148, 20);
            this.txtBankAccNumber.TabIndex = 19;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(8, 28);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(66, 13);
            this.lblBankName.TabIndex = 18;
            this.lblBankName.Text = "Bank Name:";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(130, 25);
            this.txtBankName.MaxLength = 70;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(148, 20);
            this.txtBankName.TabIndex = 2;
            // 
            // SupplierDialogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Name = "SupplierDialogFrm";
            this.Text = "Supplier Accounts";
            this.pnlContent.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplierTypes)).EndInit();
            this.grpBankDetails.ResumeLayout(false);
            this.grpBankDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtAddress5;
        private System.Windows.Forms.TextBox txtAddress4;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblPPSVat;
        private System.Windows.Forms.TextBox txtPPSVat;
        private System.Windows.Forms.ComboBox luSupplierType;
        private System.Windows.Forms.BindingSource bsSupplierTypes;
        private System.Windows.Forms.Label lblSupplierType;
        private System.Windows.Forms.GroupBox grpBankDetails;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblBankAccNumber;
        private System.Windows.Forms.TextBox txtBankAccNumber;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label lblBIC;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.TextBox txtBankAddress5;
        private System.Windows.Forms.TextBox txtBankAddress4;
        private System.Windows.Forms.TextBox txtBankAddress3;
        private System.Windows.Forms.TextBox txtBankAddress2;
        private System.Windows.Forms.TextBox txtBankAddress1;
        private System.Windows.Forms.Label lblBankAddress;
    }
}