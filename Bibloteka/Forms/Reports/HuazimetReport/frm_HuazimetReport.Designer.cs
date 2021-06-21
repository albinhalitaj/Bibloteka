
namespace Bibloteka.Forms.Reports.HuazimetReport
{
    partial class frm_HuazimetReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HuazimetReport));
            this.uspGetHuazimetReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsData = new Bibloteka.Forms.Reports.ReportsData();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_GetHuazimetReportDataTableAdapter = new Bibloteka.Forms.Reports.ReportsDataTableAdapters.usp_GetHuazimetReportDataTableAdapter();
            this.ngaData = new Guna.UI.WinForms.GunaDateTimePicker();
            this.deriData = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGjenero = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetHuazimetReportDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).BeginInit();
            this.SuspendLayout();
            // 
            // uspGetHuazimetReportDataBindingSource
            // 
            this.uspGetHuazimetReportDataBindingSource.DataMember = "usp_GetHuazimetReportData";
            this.uspGetHuazimetReportDataBindingSource.DataSource = this.reportsData;
            // 
            // reportsData
            // 
            this.reportsData.DataSetName = "ReportsData";
            this.reportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.uspGetHuazimetReportDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bibloteka.Forms.Reports.HuazimetReport.RaportiHuazimeve.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(796, 591);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_GetHuazimetReportDataTableAdapter
            // 
            this.usp_GetHuazimetReportDataTableAdapter.ClearBeforeFill = true;
            // 
            // ngaData
            // 
            this.ngaData.BackColor = System.Drawing.Color.Transparent;
            this.ngaData.BaseColor = System.Drawing.Color.White;
            this.ngaData.BorderColor = System.Drawing.Color.Silver;
            this.ngaData.BorderSize = 1;
            this.ngaData.CustomFormat = null;
            this.ngaData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ngaData.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.ngaData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngaData.ForeColor = System.Drawing.Color.Black;
            this.ngaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaData.Location = new System.Drawing.Point(125, 42);
            this.ngaData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaData.Name = "ngaData";
            this.ngaData.OnHoverBaseColor = System.Drawing.Color.White;
            this.ngaData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.ngaData.OnHoverForeColor = System.Drawing.Color.Black;
            this.ngaData.OnPressedColor = System.Drawing.Color.Black;
            this.ngaData.Radius = 3;
            this.ngaData.Size = new System.Drawing.Size(143, 37);
            this.ngaData.TabIndex = 3;
            this.ngaData.Text = "5/20/2021";
            this.ngaData.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // deriData
            // 
            this.deriData.BackColor = System.Drawing.Color.Transparent;
            this.deriData.BaseColor = System.Drawing.Color.White;
            this.deriData.BorderColor = System.Drawing.Color.Silver;
            this.deriData.BorderSize = 1;
            this.deriData.CustomFormat = null;
            this.deriData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.deriData.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.deriData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deriData.ForeColor = System.Drawing.Color.Black;
            this.deriData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deriData.Location = new System.Drawing.Point(334, 42);
            this.deriData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.deriData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.deriData.Name = "deriData";
            this.deriData.OnHoverBaseColor = System.Drawing.Color.White;
            this.deriData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.deriData.OnHoverForeColor = System.Drawing.Color.Black;
            this.deriData.OnPressedColor = System.Drawing.Color.Black;
            this.deriData.Radius = 3;
            this.deriData.Size = new System.Drawing.Size(143, 37);
            this.deriData.TabIndex = 4;
            this.deriData.Text = "5/20/2021";
            this.deriData.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(40, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nga Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(283, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Deri: ";
            // 
            // btnGjenero
            // 
            this.btnGjenero.AnimationHoverSpeed = 0.07F;
            this.btnGjenero.AnimationSpeed = 0.03F;
            this.btnGjenero.BackColor = System.Drawing.Color.Transparent;
            this.btnGjenero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnGjenero.BorderColor = System.Drawing.Color.Black;
            this.btnGjenero.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnGjenero.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGjenero.CheckedForeColor = System.Drawing.Color.White;
            this.btnGjenero.CheckedImage = null;
            this.btnGjenero.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGjenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGjenero.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGjenero.FocusedColor = System.Drawing.Color.Empty;
            this.btnGjenero.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGjenero.ForeColor = System.Drawing.Color.White;
            this.btnGjenero.Image = null;
            this.btnGjenero.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGjenero.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGjenero.Location = new System.Drawing.Point(515, 42);
            this.btnGjenero.Margin = new System.Windows.Forms.Padding(2);
            this.btnGjenero.Name = "btnGjenero";
            this.btnGjenero.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnGjenero.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGjenero.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGjenero.OnHoverImage = null;
            this.btnGjenero.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGjenero.OnPressedColor = System.Drawing.Color.Black;
            this.btnGjenero.Radius = 3;
            this.btnGjenero.Size = new System.Drawing.Size(97, 37);
            this.btnGjenero.TabIndex = 23;
            this.btnGjenero.Text = "Gjenero";
            this.btnGjenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGjenero.Click += new System.EventHandler(this.btnGjenero_Click);
            // 
            // frm_HuazimetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 692);
            this.Controls.Add(this.btnGjenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deriData);
            this.Controls.Add(this.ngaData);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HuazimetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporti i Huazimeve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HuazimetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetHuazimetReportDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspGetHuazimetReportDataBindingSource;
        private ReportsData reportsData;
        private ReportsDataTableAdapters.usp_GetHuazimetReportDataTableAdapter usp_GetHuazimetReportDataTableAdapter;
        private Guna.UI.WinForms.GunaDateTimePicker ngaData;
        private Guna.UI.WinForms.GunaDateTimePicker deriData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnGjenero;
    }
}