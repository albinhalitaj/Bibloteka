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

namespace Bibloteka.Forms.Reports.KthimetReport
{
    public partial class frm_KthimetReport : Form
    {
        public frm_KthimetReport()
        {
            InitializeComponent();
        }

        private void frm_KthimetReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsData.usp_GetKthimetReportData' table. You can move, or remove it, as needed.
            this.usp_GetKthimetReportDataTableAdapter.Fill(this.reportsData.usp_GetKthimetReportData);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }
    }
}
