namespace Newcourt.Views
{
    partial class LoginDialogFrm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialogFrm));
      this.grpDetails = new System.Windows.Forms.GroupBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.pnlContent.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.grpDetails.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContent
      // 
      this.pnlContent.Controls.Add(this.grpDetails);
      this.pnlContent.Size = new System.Drawing.Size(211, 83);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 83);
      this.pnlBottom.Size = new System.Drawing.Size(211, 32);
      // 
      // btnSave
      // 
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.Location = new System.Drawing.Point(48, 5);
      this.btnSave.Text = "Login";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(129, 5);
      this.btnCancel.Text = "Close";
      // 
      // grpDetails
      // 
      this.grpDetails.Controls.Add(this.lblPassword);
      this.grpDetails.Controls.Add(this.txtPassword);
      this.grpDetails.Controls.Add(this.txtUsername);
      this.grpDetails.Controls.Add(this.lblUsername);
      this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpDetails.Location = new System.Drawing.Point(0, 0);
      this.grpDetails.Name = "grpDetails";
      this.grpDetails.Size = new System.Drawing.Size(211, 83);
      this.grpDetails.TabIndex = 0;
      this.grpDetails.TabStop = false;
      this.grpDetails.Text = "Login Details";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(8, 54);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(56, 13);
      this.lblPassword.TabIndex = 3;
      this.lblPassword.Text = "Password:";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(84, 51);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(120, 20);
      this.txtPassword.TabIndex = 2;
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(84, 25);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(120, 20);
      this.txtUsername.TabIndex = 1;
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new System.Drawing.Point(8, 28);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(58, 13);
      this.lblUsername.TabIndex = 0;
      this.lblUsername.Text = "Username:";
      // 
      // LoginDialogFrm
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(211, 115);
      this.Name = "LoginDialogFrm";
      this.Text = "Payments Login";
      this.pnlContent.ResumeLayout(false);
      this.pnlBottom.ResumeLayout(false);
      this.grpDetails.ResumeLayout(false);
      this.grpDetails.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}