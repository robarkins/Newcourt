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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grpCompanyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpCompanyInfo);
            this.pnlContent.Size = new System.Drawing.Size(617, 113);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 113);
            this.pnlBottom.Size = new System.Drawing.Size(617, 32);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(453, 5);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(534, 5);
            // 
            // grpCompanyInfo
            // 
            this.grpCompanyInfo.Controls.Add(this.txtCompanyName);
            this.grpCompanyInfo.Controls.Add(this.lblCompanyName);
            this.grpCompanyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompanyInfo.Location = new System.Drawing.Point(0, 0);
            this.grpCompanyInfo.Name = "grpCompanyInfo";
            this.grpCompanyInfo.Size = new System.Drawing.Size(617, 113);
            this.grpCompanyInfo.TabIndex = 0;
            this.grpCompanyInfo.TabStop = false;
            this.grpCompanyInfo.Text = "Company Details";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(130, 25);
            this.txtCompanyName.MaxLength = 70;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(148, 20);
            this.txtCompanyName.TabIndex = 2;
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
            // CompanyInfoDialogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 145);
            this.Name = "CompanyInfoDialogFrm";
            this.Text = "Company Information";
            this.pnlContent.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.grpCompanyInfo.ResumeLayout(false);
            this.grpCompanyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompanyInfo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
    }
}