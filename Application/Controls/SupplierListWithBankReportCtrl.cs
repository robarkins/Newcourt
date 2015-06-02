using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newcourt.Controls {
  public partial class SupplierListWithBankReportCtrl: UserControl {
    public SupplierListWithBankReportCtrl() {
      InitializeComponent();
    }

    private void rptViewer_Load(object sender, System.EventArgs e) {
      try {
        Cursor.Current = Cursors.WaitCursor;
        rptViewer.ServerReport.ReportServerUrl = Global.ReportServer;
        rptViewer.ServerReport.ReportPath = "/Reports/SupplierListWithBank";
        rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
        rptViewer.RefreshReport();
      } catch (Exception ex) {
        Utils.ShowException(ex);
      } finally {
        Cursor.Current = Cursors.Default;
      }
    }
  }
}
