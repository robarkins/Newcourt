using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newcourt.Controls
{
    public partial class PaymentsSummaryReportCtrl : MasterReportCtrl
    {
        public PaymentsSummaryReportCtrl()
        {
            InitializeComponent();
        }

        private void rptViewer_Load(object sender, EventArgs e)
        {
            rptViewer.ServerReport.ReportServerUrl = reportServer;
            rptViewer.ServerReport.ReportPath = "/Reports/PaymentSummary";
            rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            rptViewer.RefreshReport();
        }
    }
}
