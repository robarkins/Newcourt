using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Newcourt.Controls
{
    public partial class PaymentDetailReportCtrl : UserControl
    {
        public PaymentDetailReportCtrl()
        {
            InitializeComponent();
        }

        private void PaymentDetailReportCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                rptViewer.ServerReport.ReportServerUrl = Global.ReportServer;
                rptViewer.ServerReport.ReportPath = "/Reports/PaymentDetail";
                rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;

                List<ReportParameter> parameters = new List<ReportParameter>();
                String dateFrom = null;
                String dateTo = null;
                parameters.Add(new ReportParameter("DateFrom", dateFrom, true));
                parameters.Add(new ReportParameter("DateTo", dateTo, true));
                rptViewer.ServerReport.SetParameters(parameters);

                rptViewer.RefreshReport();
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
