
namespace Bibloteka.Forms.Reports.LibratReport
{
    partial class frm_LibratReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LibratReport));
            this.uspGetLibratReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsData = new Bibloteka.Forms.Reports.ReportsData();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_GetLibratReportDataTableAdapter = new Bibloteka.Forms.Reports.ReportsDataTableAdapters.usp_GetLibratReportDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetLibratReportDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).BeginInit();
            this.SuspendLayout();
            // 
            // uspGetLibratReportDataBindingSource
            // 
            this.uspGetLibratReportDataBindingSource.DataMember = "usp_GetLibratReportData";
            this.uspGetLibratReportDataBindingSource.DataSource = this.reportsData;
            // 
            // reportsData
            // 
            this.reportsData.DataSetName = "ReportsData";
            this.reportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.uspGetLibratReportDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bibloteka.Forms.Reports.LibratReport.LibratReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_GetLibratReportDataTableAdapter
            // 
            this.usp_GetLibratReportDataTableAdapter.ClearBeforeFill = true;
            // 
            // frm_LibratReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 650);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LibratReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporti Librave";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_LibratReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetLibratReportDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportsData reportsData;
        private System.Windows.Forms.BindingSource uspGetLibratReportDataBindingSource;
        private ReportsDataTableAdapters.usp_GetLibratReportDataTableAdapter usp_GetLibratReportDataTableAdapter;
    }
}