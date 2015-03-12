using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Newcourt.Views {
  public partial class PaymentDetailByBatchReportFrm: MasterDialogFrm {
    private int batch;

    public PaymentDetailByBatchReportFrm(int batch) {
      InitializeComponent();

      this.batch = batch;
    }

    private void rptViewer_Load(object sender, EventArgs e) {
      try {
        Cursor.Current = Cursors.WaitCursor;

        ReportParameter[] param = new ReportParameter[1];
        param[0] = new ReportParameter("Batch", batch.ToString());

        rptViewer.ServerReport.ReportServerUrl = Global.ReportServer;
        rptViewer.ServerReport.ReportPath = "/Reports/PaymentDetailByBatch";

        rptViewer.ServerReport.SetParameters(param);
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
