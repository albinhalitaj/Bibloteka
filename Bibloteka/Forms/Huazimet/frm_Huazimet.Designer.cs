
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Huazimet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKategorite = new System.Windows.Forms.Label();
            this.btnHuazo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgv_Huazimet = new Guna.UI.WinForms.GunaDataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel1.Location = new System.Drawing.Point(34, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 3);
            this.panel1.TabIndex = 20;
            // 
            // lblKategorite
            // 
            this.lblKategorite.AutoSize = true;
            this.lblKategorite.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorite.Location = new System.Drawing.Point(26, 21);
            this.lblKategorite.Name = "lblKategorite";
            this.lblKategorite.Size = new System.Drawing.Size(132, 42);
            this.lblKategorite.TabIndex = 19;
            this.lblKategorite.Text = "Huazimet";
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
            this.btnHuazo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHuazo.ForeColor = System.Drawing.Color.White;
            this.btnHuazo.Image = null;
            this.btnHuazo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuazo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHuazo.Location = new System.Drawing.Point(59, 140);
            this.btnHuazo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuazo.Name = "btnHuazo";
            this.btnHuazo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnHuazo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuazo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuazo.OnHoverImage = null;
            this.btnHuazo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHuazo.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuazo.Radius = 3;
            this.btnHuazo.Size = new System.Drawing.Size(119, 35);
            this.btnHuazo.TabIndex = 32;
            this.btnHuazo.Text = "Huazo";
            this.btnHuazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuazo.Click += new System.EventHandler(this.btnHuazo_Click);
            // 
            // dgv_Huazimet
            // 
            this.dgv_Huazimet.AllowUserToAddRows = false;
            this.dgv_Huazimet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Huazimet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Huazimet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgv_Huazimet.ColumnHeadersHeight = 41;
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
            this.dgv_Huazimet.Location = new System.Drawing.Point(59, 227);
            this.dgv_Huazimet.Name = "dgv_Huazimet";
            this.dgv_Huazimet.ReadOnly = true;
            this.dgv_Huazimet.RowHeadersVisible = false;
            this.dgv_Huazimet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Huazimet.Size = new System.Drawing.Size(974, 609);
            this.dgv_Huazimet.TabIndex = 34;
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
            // Column1
            // 
            this.Column1.HeaderText = "HuazimiID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Klienti";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Libri";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NumriKopjeve";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DataHuazimit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DataKthimit";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "Statusi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
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
            this.deriData.Location = new System.Drawing.Point(495, 140);
            this.deriData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.deriData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.deriData.Name = "deriData";
            this.deriData.OnHoverBaseColor = System.Drawing.Color.White;
            this.deriData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.deriData.OnHoverForeColor = System.Drawing.Color.Black;
            this.deriData.OnPressedColor = System.Drawing.Color.Black;
            this.deriData.Radius = 3;
            this.deriData.Size = new System.Drawing.Size(115, 37);
            this.deriData.TabIndex = 52;
            this.deriData.Text = "5/20/2021";
            this.deriData.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
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
            this.ngaData.Location = new System.Drawing.Point(287, 140);
            this.ngaData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaData.Name = "ngaData";
            this.ngaData.OnHoverBaseColor = System.Drawing.Color.White;
            this.ngaData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.ngaData.OnHoverForeColor = System.Drawing.Color.Black;
            this.ngaData.OnPressedColor = System.Drawing.Color.Black;
            this.ngaData.Radius = 3;
            this.ngaData.Size = new System.Drawing.Size(118, 37);
            this.ngaData.TabIndex = 51;
            this.ngaData.Text = "5/20/2021";
            this.ngaData.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(202, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nga Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(424, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Deri më:";
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
            this.btnFiltro.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Image = null;
            this.btnFiltro.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltro.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFiltro.Location = new System.Drawing.Point(632, 140);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnFiltro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltro.OnHoverImage = null;
            this.btnFiltro.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFiltro.OnPressedColor = System.Drawing.Color.Black;
            this.btnFiltro.Radius = 3;
            this.btnFiltro.Size = new System.Drawing.Size(79, 37);
            this.btnFiltro.TabIndex = 55;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(713, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Kërkoni:";
            // 
            // txtKerko
            // 
            this.txtKerko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKerko.BackColor = System.Drawing.Color.Transparent;
            this.txtKerko.BaseColor = System.Drawing.Color.White;
            this.txtKerko.BorderColor = System.Drawing.Color.Silver;
            this.txtKerko.BorderSize = 1;
            this.txtKerko.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKerko.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKerko.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKerko.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKerko.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerko.Location = new System.Drawing.Point(783, 143);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.PasswordChar = '\0';
            this.txtKerko.Radius = 3;
            this.txtKerko.SelectedText = "";
            this.txtKerko.Size = new System.Drawing.Size(250, 34);
            this.txtKerko.TabIndex = 56;
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Shënim: Huazimet e paraqitura në tabelë janë vetem huazimet e muajit aktual!";
            // 
            // frm_Huazimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 878);
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
            this.Text = "frm_Huazimet";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private Guna.UI.WinForms.GunaDateTimePicker deriData;
        private Guna.UI.WinForms.GunaDateTimePicker ngaData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnFiltro;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private System.Windows.Forms.Label label2;
    }
}