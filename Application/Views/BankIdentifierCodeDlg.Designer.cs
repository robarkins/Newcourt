namespace Newcourt.Views {
  partial class BankIdentifierCodeDlg {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.grpDetails = new System.Windows.Forms.GroupBox();
      this.lblCode = new System.Windows.Forms.Label();
      this.txtCode = new System.Windows.Forms.TextBox();
      this.pnlContent.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.grpDetails.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContent
      // 
      this.pnlContent.Controls.Add(this.grpDetails);
      this.pnlContent.Size = new System.Drawing.Size(190, 51);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 51);
      this.pnlBottom.Size = new System.Drawing.Size(190, 32);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(25, 5);
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(106, 5);
      // 
      // grpDetails
      // 
      this.grpDetails.Controls.Add(this.txtCode);
      this.grpDetails.Controls.Add(this.lblCode);
      this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpDetails.Location = new System.Drawing.Point(0, 0);
      this.grpDetails.Name = "grpDetails";
      this.grpDetails.Size = new System.Drawing.Size(190, 51);
      this.grpDetails.TabIndex = 0;
      this.grpDetails.TabStop = false;
      this.grpDetails.Text = "Details";
      // 
      // lblCode
      // 
      this.lblCode.AutoSize = true;
      this.lblCode.Location = new System.Drawing.Point(8, 26);
      this.lblCode.Name = "lblCode";
      this.lblCode.Size = new System.Drawing.Size(35, 13);
      this.lblCode.TabIndex = 0;
      this.lblCode.Text = "Code:";
      // 
      // txtCode
      // 
      this.txtCode.Location = new System.Drawing.Point(61, 23);
      this.txtCode.MaxLength = 11;
      this.txtCode.Name = "txtCode";
      this.txtCode.Size = new System.Drawing.Size(100, 20);
      this.txtCode.TabIndex = 1;
      // 
      // BankIdentifierCodeDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(190, 83);
      this.Name = "BankIdentifierCodeDlg";
      this.Text = "Add BIC";
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
  }
}