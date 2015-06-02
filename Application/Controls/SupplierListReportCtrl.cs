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
  public partial class SupplierListReportCtrl: UserControl {
    public SupplierListReportCtrl() {
      InitializeComponent();
    }

    private void SupplierListReportCtrl_Load(object sender, EventArgs e) {
      try {
        Cursor.Current = Cursors.WaitCursor;
        rptViewer.ServerReport.ReportServerUrl = Global.ReportServer;
        rptViewer.ServerReport.ReportPath = "/Reports/SupplierList";
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
