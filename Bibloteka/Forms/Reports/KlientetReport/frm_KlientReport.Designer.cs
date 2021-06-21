
namespace Bibloteka.Forms.Reports.KlientetReport
{
    partial class frm_KlientReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KlientReport));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportsData = new Bibloteka.Forms.Reports.ReportsData();
            this.uspGetKlientReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_GetKlientReportDataTableAdapter = new Bibloteka.Forms.Reports.ReportsDataTableAdapters.usp_GetKlientReportDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetKlientReportDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.uspGetKlientReportDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bibloteka.Forms.Reports.KlientetReport.KlientReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportsData
            // 
            this.reportsData.DataSetName = "ReportsData";
            this.reportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspGetKlientReportDataBindingSource
            // 
            this.uspGetKlientReportDataBindingSource.DataMember = "usp_GetKlientReportData";
            this.uspGetKlientReportDataBindingSource.DataSource = this.reportsData;
            // 
            // usp_GetKlientReportDataTableAdapter
            // 
            this.usp_GetKlientReportDataTableAdapter.ClearBeforeFill = true;
            // 
            // frm_KlientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 586);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KlientReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporti i Klientëve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_KlientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetKlientReportDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportsData reportsData;
        private System.Windows.Forms.BindingSource uspGetKlientReportDataBindingSource;
        private ReportsDataTableAdapters.usp_GetKlientReportDataTableAdapter usp_GetKlientReportDataTableAdapter;
    }
}