namespace Newcourt.Views {
  partial class PaymentDetailByBatchReportFrm {
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
      this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
      this.pnlContent.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContent
      // 
      this.pnlContent.Controls.Add(this.rptViewer);
      this.pnlContent.Size = new System.Drawing.Size(534, 230);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Size = new System.Drawing.Size(534, 32);
      // 
      // btnSave
      // 
      this.btnSave.Visible = false;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Location = new System.Drawing.Point(447, 5);
      // 
      // rptViewer
      // 
      this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rptViewer.Location = new System.Drawing.Point(0, 0);
      this.rptViewer.Name = "rptViewer";
      this.rptViewer.Size = new System.Drawing.Size(534, 230);
      this.rptViewer.TabIndex = 0;
      this.rptViewer.Load += new System.EventHandler(this.rptViewer_Load);
      // 
      // PaymentDetailByBatchReportFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 262);
      this.Name = "PaymentDetailByBatchReportFrm";
      this.Text = "PaymentDetailByBatchReportFrm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.pnlContent.ResumeLayout(false);
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer rptViewer;

  }
}