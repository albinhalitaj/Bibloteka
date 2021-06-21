using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.Forms.Reports.ReportsDataTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Bibloteka.Forms.Reports.HuazimetReport
{
    public partial class frm_HuazimetReport : Form
    {
        public frm_HuazimetReport()
        {
            InitializeComponent();
        }

        private void frm_HuazimetReport_Load(object sender, EventArgs e)
        {
            deriData.Value = DateTime.Today;
            var dt = new usp_GetHuazimetMuajitAktualTableAdapter().GetData();
            uspGetHuazimetReportDataBindingSource.DataSource = dt;
            var date = Convert.ToDateTime(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).ToString("dd/MM/yyyy");
            var deriDate = Convert.ToDateTime(new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))).ToString("dd/MM/yyyy");
            var r = new[]
            {
                new ReportParameter("nData", date),
                new ReportParameter("dData",deriDate)
            };
            reportViewer1.LocalReport.SetParameters(r);
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void btnGjenero_Click(object sender, EventArgs e)
        {
            var dt = new usp_GetHuazimetReportDataTableAdapter().GetData(ngaData.Value, deriData.Value);
            uspGetHuazimetReportDataBindingSource.DataSource = dt;
            var r = new[]
            {
                new ReportParameter("nData", ngaData.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("dData", deriData.Value.ToString("dd/MM/yyyy"))
            };
            reportViewer1.LocalReport.SetParameters(r);
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }
    }
}
