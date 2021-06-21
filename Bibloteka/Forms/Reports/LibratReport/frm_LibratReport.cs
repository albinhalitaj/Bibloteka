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

namespace Bibloteka.Forms.Reports.LibratReport
{
    public partial class frm_LibratReport : Form
    {
        public frm_LibratReport()
        {
            InitializeComponent();
        }

        private void frm_LibratReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsData.usp_GetLibratReportData' table. You can move, or remove it, as needed.
            this.usp_GetLibratReportDataTableAdapter.Fill(this.reportsData.usp_GetLibratReportData);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }
    }
}
