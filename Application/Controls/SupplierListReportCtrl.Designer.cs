namespace Newcourt.Controls {
  partial class SupplierListReportCtrl {
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
      this.rptViewer.Name = "ReportViewer";
      this.rptViewer.Size = new System.Drawing.Size(693, 396);
      this.rptViewer.TabIndex = 0;
      // 
      // SupplierListReportCtrl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.rptViewer);
      this.Name = "SupplierListReportCtrl";
      this.Size = new System.Drawing.Size(940, 396);
      this.Tag = "Supplier List";
      this.Load += new System.EventHandler(this.SupplierListReportCtrl_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
  }
}
