
namespace Bibloteka.Forms
{
    partial class frm_Huazimet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Huazimet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKategorite = new System.Windows.Forms.Label();
            this.btnHuazo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgv_Huazimet = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.deriData = new Guna.UI.WinForms.GunaDateTimePicker();
            this.ngaData = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltro = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKerko = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Huazimet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblKategorite
            // 
            resources.ApplyResources(this.lblKategorite, "lblKategorite");
            this.lblKategorite.Name = "lblKategorite";
            // 
            // btnHuazo
            // 
            this.btnHuazo.AnimationHoverSpeed = 0.07F;
            this.btnHuazo.AnimationSpeed = 0.03F;
            this.btnHuazo.BackColor = System.Drawing.Color.Transparent;
            this.btnHuazo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnHuazo.BorderColor = System.Drawing.Color.Black;
            this.btnHuazo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnHuazo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHuazo.CheckedForeColor = System.Drawing.Color.White;
            this.btnHuazo.CheckedImage = null;
            this.btnHuazo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnHuazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuazo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHuazo.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnHuazo, "btnHuazo");
            this.btnHuazo.ForeColor = System.Drawing.Color.White;
            this.btnHuazo.Image = null;
            this.btnHuazo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuazo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHuazo.Name = "btnHuazo";
            this.btnHuazo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnHuazo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuazo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuazo.OnHoverImage = null;
            this.btnHuazo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHuazo.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuazo.Radius = 3;
            this.btnHuazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuazo.Click += new System.EventHandler(this.btnHuazo_Click);
            // 
            // dgv_Huazimet
            // 
            this.dgv_Huazimet.AllowUserToAddRows = false;
            this.dgv_Huazimet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Huazimet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_Huazimet, "dgv_Huazimet");
            this.dgv_Huazimet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Huazimet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Huazimet.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Huazimet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Huazimet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Huazimet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Huazimet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Huazimet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Huazimet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Huazimet.EnableHeadersVisualStyles = false;
            this.dgv_Huazimet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Huazimet.Name = "dgv_Huazimet";
            this.dgv_Huazimet.ReadOnly = true;
            this.dgv_Huazimet.RowHeadersVisible = false;
            this.dgv_Huazimet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Huazimet.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Huazimet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Huazimet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Huazimet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Huazimet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Huazimet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Huazimet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Huazimet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Huazimet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dgv_Huazimet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Huazimet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Huazimet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Huazimet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Huazimet.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Huazimet.ThemeStyle.ReadOnly = true;
            this.dgv_Huazimet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Huazimet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Huazimet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Huazimet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Huazimet.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Huazimet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Huazimet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Huazimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Huazimet_CellContentClick);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aktiv.png");
            this.imageList1.Images.SetKeyName(1, "joaktiv.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "notify.png");
            this.imageList2.Images.SetKeyName(1, "kthe.png");
            // 
            // deriData
            // 
            this.deriData.BackColor = System.Drawing.Color.Transparent;
            this.deriData.BaseColor = System.Drawing.Color.White;
            this.deriData.BorderColor = System.Drawing.Color.Silver;
            this.deriData.BorderSize = 1;
            resources.ApplyResources(this.deriData, "deriData");
            this.deriData.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.deriData.ForeColor = System.Drawing.Color.Black;
            this.deriData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deriData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.deriData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.deriData.Name = "deriData";
            this.deriData.OnHoverBaseColor = System.Drawing.Color.White;
            this.deriData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.deriData.OnHoverForeColor = System.Drawing.Color.Black;
            this.deriData.OnPressedColor = System.Drawing.Color.Black;
            this.deriData.Radius = 3;
            this.deriData.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // ngaData
            // 
            this.ngaData.BackColor = System.Drawing.Color.Transparent;
            this.ngaData.BaseColor = System.Drawing.Color.White;
            this.ngaData.BorderColor = System.Drawing.Color.Silver;
            this.ngaData.BorderSize = 1;
            resources.ApplyResources(this.ngaData, "ngaData");
            this.ngaData.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.ngaData.ForeColor = System.Drawing.Color.Black;
            this.ngaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaData.Name = "ngaData";
            this.ngaData.OnHoverBaseColor = System.Drawing.Color.White;
            this.ngaData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.ngaData.OnHoverForeColor = System.Drawing.Color.Black;
            this.ngaData.OnPressedColor = System.Drawing.Color.Black;
            this.ngaData.Radius = 3;
            this.ngaData.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnFiltro
            // 
            this.btnFiltro.AnimationHoverSpeed = 0.07F;
            this.btnFiltro.AnimationSpeed = 0.03F;
            this.btnFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnFiltro.BorderColor = System.Drawing.Color.Black;
            this.btnFiltro.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnFiltro.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFiltro.CheckedForeColor = System.Drawing.Color.White;
            this.btnFiltro.CheckedImage = null;
            this.btnFiltro.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltro.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnFiltro, "btnFiltro");
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Image = null;
            this.btnFiltro.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltro.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnFiltro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltro.OnHoverImage = null;
            this.btnFiltro.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFiltro.OnPressedColor = System.Drawing.Color.Black;
            this.btnFiltro.Radius = 3;
            this.btnFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtKerko
            // 
            resources.ApplyResources(this.txtKerko, "txtKerko");
            this.txtKerko.BackColor = System.Drawing.Color.Transparent;
            this.txtKerko.BaseColor = System.Drawing.Color.White;
            this.txtKerko.BorderColor = System.Drawing.Color.Silver;
            this.txtKerko.BorderSize = 1;
            this.txtKerko.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKerko.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKerko.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKerko.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.PasswordChar = '\0';
            this.txtKerko.Radius = 3;
            this.txtKerko.SelectedText = "";
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // frm_Huazimet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKerko);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deriData);
            this.Controls.Add(this.ngaData);
            this.Controls.Add(this.dgv_Huazimet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuazo);
            this.Controls.Add(this.lblKategorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Huazimet";
            this.Load += new System.EventHandler(this.frm_Huazimet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Huazimet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKategorite;
        private Guna.UI.WinForms.GunaAdvenceButton btnHuazo;
        private Guna.UI.WinForms.GunaDataGridView dgv_Huazimet;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private Guna.UI.WinForms.GunaDateTimePicker deriData;
        private Guna.UI.WinForms.GunaDateTimePicker ngaData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnFiltro;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
    }
}