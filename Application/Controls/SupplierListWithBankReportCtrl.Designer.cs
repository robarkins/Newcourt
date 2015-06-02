namespace Newcourt.Controls {
  partial class SupplierListWithBankReportCtrl {
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
      this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
      this.SuspendLayout();
      // 
      // rptViewer
      // 
      this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rptViewer.Location = new System.Drawing.Point(0, 0);
      this.rptViewer.Margin = new System.Windows.Forms.Padding(4);
      this.rptViewer.Name = "rptViewer";
      this.rptViewer.Size = new System.Drawing.Size(1248, 503);
      this.rptViewer.TabIndex = 0;
      this.rptViewer.Load += rptViewer_Load;
      // 
      // SupplierListWithBankReportCtrl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.rptViewer);
      this.Name = "SupplierListWithBankReportCtrl";
      this.Size = new System.Drawing.Size(1248, 503);
      this.Tag = "Supplier List with Bank Details";
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer rptViewer;

  }
}
