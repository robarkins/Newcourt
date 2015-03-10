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
                //rptViewer.ServerReport.ReportServerUrl = new Uri(@"http://ROB-LAPTOP/ReportServer");
                rptViewer.ServerReport.ReportServerUrl = new Uri(@"http://IIS-DEVEL06/ReportServer");
                rptViewer.ServerReport.ReportPath = "/Reports/PaymentDetail";
                rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
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
