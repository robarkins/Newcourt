namespace Newcourt.Views
{
    partial class BankAccountDialogFrm
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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.lblBIC = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblOIN = new System.Windows.Forms.Label();
            this.txtOIN = new System.Windows.Forms.TextBox();
            this.pnlContent.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpDetails);
            this.pnlContent.Size = new System.Drawing.Size(317, 156);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 156);
            this.pnlBottom.Size = new System.Drawing.Size(317, 32);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 5);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 5);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtOIN);
            this.grpDetails.Controls.Add(this.lblOIN);
            this.grpDetails.Controls.Add(this.lblIBAN);
            this.grpDetails.Controls.Add(this.txtIBAN);
            this.grpDetails.Controls.Add(this.lblBIC);
            this.grpDetails.Controls.Add(this.txtBIC);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.txtCode);
            this.grpDetails.Controls.Add(this.lblCode);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetails.Location = new System.Drawing.Point(0, 0);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(317, 156);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Bank Account Details";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 27);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(61, 23);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(94, 20);
            this.txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 49);
            this.txtName.MaxLength = 70;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(61, 75);
            this.txtBIC.MaxLength = 11;
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(246, 20);
            this.txtBIC.TabIndex = 6;
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(8, 78);
            this.lblBIC.Name = "lblBIC";
            this.lblBIC.Size = new System.Drawing.Size(27, 13);
            this.lblBIC.TabIndex = 7;
            this.lblBIC.Text = "BIC:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(61, 101);
            this.txtIBAN.MaxLength = 35;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(246, 20);
            this.txtIBAN.TabIndex = 8;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(8, 104);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(35, 13);
            this.lblIBAN.TabIndex = 9;
            this.lblIBAN.Text = "IBAN:";
            // 
            // lblOIN
            // 
            this.lblOIN.AutoSize = true;
            this.lblOIN.Location = new System.Drawing.Point(8, 130);
            this.lblOIN.Name = "lblOIN";
            this.lblOIN.Size = new System.Drawing.Size(29, 13);
            this.lblOIN.TabIndex = 10;
            this.lblOIN.Text = "OIN:";
            // 
            // txtOIN
            // 
            this.txtOIN.Location = new System.Drawing.Point(61, 127);
            this.txtOIN.MaxLength = 35;
            this.txtOIN.Name = "txtOIN";
            this.txtOIN.Size = new System.Drawing.Size(246, 20);
            this.txtOIN.TabIndex = 11;
            // 
            // BankAccountDialogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 188);
            this.Name = "BankAccountDialogFrm";
            this.Text = "Add Bank Account";
            this.pnlContent.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtOIN;
        private System.Windows.Forms.Label lblOIN;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label lblBIC;
        private System.Windows.Forms.TextBox txtBIC;
    }
}