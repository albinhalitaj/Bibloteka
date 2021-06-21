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

namespace Bibloteka.Forms.Reports.KlientetReport
{
    public partial class frm_KlientReport : Form
    {
        public frm_KlientReport()
        {
            InitializeComponent();
        }

        private void frm_KlientReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsData.usp_GetKlientReportData' table. You can move, or remove it, as needed.
            this.usp_GetKlientReportDataTableAdapter.Fill(this.reportsData.usp_GetKlientReportData);
            // TODO: This line of code loads data into the 'reportsData.usp_GetKlientReportData' table. You can move, or remove it, as needed.
            this.usp_GetKlientReportDataTableAdapter.Fill(this.reportsData.usp_GetKlientReportData);
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }
    }
}
