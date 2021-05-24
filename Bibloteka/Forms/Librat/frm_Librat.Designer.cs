
namespace Bibloteka.Forms
{
    partial class frm_Librat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Librat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKategorite = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblTotalLibra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKerko = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_Librat = new Guna.UI.WinForms.GunaDataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBotuesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGjuha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditioni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusi = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Librat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(33, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 3);
            this.panel1.TabIndex = 24;
            // 
            // lblKategorite
            // 
            this.lblKategorite.AutoSize = true;
            this.lblKategorite.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorite.Location = new System.Drawing.Point(26, 21);
            this.lblKategorite.Name = "lblKategorite";
            this.lblKategorite.Size = new System.Drawing.Size(84, 42);
            this.lblKategorite.TabIndex = 23;
            this.lblKategorite.Text = "Librat";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.btnShto);
            this.gunaGroupBox1.Controls.Add(this.lblTotalLibra);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtKerko);
            this.gunaGroupBox1.Controls.Add(this.dgv_Librat);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(54, 95);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1062, 638);
            this.gunaGroupBox1.TabIndex = 30;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // btnShto
            // 
            this.btnShto.AnimationHoverSpeed = 0.07F;
            this.btnShto.AnimationSpeed = 0.03F;
            this.btnShto.BackColor = System.Drawing.Color.Transparent;
            this.btnShto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnShto.BorderColor = System.Drawing.Color.Black;
            this.btnShto.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShto.CheckedForeColor = System.Drawing.Color.White;
            this.btnShto.CheckedImage = null;
            this.btnShto.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShto.FocusedColor = System.Drawing.Color.Empty;
            this.btnShto.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.Image = ((System.Drawing.Image)(resources.GetObject("btnShto.Image")));
            this.btnShto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.Location = new System.Drawing.Point(37, 37);
            this.btnShto.Name = "btnShto";
            this.btnShto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnShto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShto.OnHoverImage = null;
            this.btnShto.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.OnPressedColor = System.Drawing.Color.Black;
            this.btnShto.Radius = 3;
            this.btnShto.Size = new System.Drawing.Size(126, 34);
            this.btnShto.TabIndex = 30;
            this.btnShto.Text = "Shto Libër";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // lblTotalLibra
            // 
            this.lblTotalLibra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalLibra.AutoSize = true;
            this.lblTotalLibra.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLibra.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTotalLibra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalLibra.Location = new System.Drawing.Point(32, 598);
            this.lblTotalLibra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLibra.Name = "lblTotalLibra";
            this.lblTotalLibra.Size = new System.Drawing.Size(95, 26);
            this.lblTotalLibra.TabIndex = 29;
            this.lblTotalLibra.Text = "Total Libra:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(704, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 28;
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
            this.txtKerko.Location = new System.Drawing.Point(774, 42);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.PasswordChar = '\0';
            this.txtKerko.Radius = 3;
            this.txtKerko.SelectedText = "";
            this.txtKerko.Size = new System.Drawing.Size(250, 34);
            this.txtKerko.TabIndex = 27;
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            // 
            // dgv_Librat
            // 
            this.dgv_Librat.AllowUserToAddRows = false;
            this.dgv_Librat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_Librat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Librat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Librat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Librat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Librat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Librat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Librat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Librat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Librat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Librat.ColumnHeadersHeight = 41;
            this.dgv_Librat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitulli,
            this.colAutori,
            this.colBotuesi,
            this.colGjuha,
            this.colTipi,
            this.colKategoria,
            this.colISBN,
            this.colEditioni,
            this.colSasia,
            this.colStatusi,
            this.Edit,
            this.Delete});
            this.dgv_Librat.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Librat.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Librat.EnableHeadersVisualStyles = false;
            this.dgv_Librat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Librat.Location = new System.Drawing.Point(37, 101);
            this.dgv_Librat.Name = "dgv_Librat";
            this.dgv_Librat.ReadOnly = true;
            this.dgv_Librat.RowHeadersVisible = false;
            this.dgv_Librat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Librat.Size = new System.Drawing.Size(987, 494);
            this.dgv_Librat.TabIndex = 23;
            this.dgv_Librat.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Librat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Librat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Librat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Librat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Librat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Librat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Librat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Librat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dgv_Librat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Librat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Librat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Librat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Librat.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Librat.ThemeStyle.ReadOnly = true;
            this.dgv_Librat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Librat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Librat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Librat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Librat.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Librat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Librat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Librat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Librat_CellContentClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colID.HeaderText = "LibriID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 80;
            // 
            // colTitulli
            // 
            this.colTitulli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTitulli.HeaderText = "Titulli";
            this.colTitulli.Name = "colTitulli";
            this.colTitulli.ReadOnly = true;
            this.colTitulli.Width = 200;
            // 
            // colAutori
            // 
            this.colAutori.HeaderText = "Autori";
            this.colAutori.Name = "colAutori";
            this.colAutori.ReadOnly = true;
            // 
            // colBotuesi
            // 
            this.colBotuesi.HeaderText = "Botuesi";
            this.colBotuesi.Name = "colBotuesi";
            this.colBotuesi.ReadOnly = true;
            // 
            // colGjuha
            // 
            this.colGjuha.HeaderText = "Gjuha";
            this.colGjuha.Name = "colGjuha";
            this.colGjuha.ReadOnly = true;
            // 
            // colTipi
            // 
            this.colTipi.HeaderText = "Tipi";
            this.colTipi.Name = "colTipi";
            this.colTipi.ReadOnly = true;
            // 
            // colKategoria
            // 
            this.colKategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colKategoria.HeaderText = "Kategoria";
            this.colKategoria.Name = "colKategoria";
            this.colKategoria.ReadOnly = true;
            this.colKategoria.Width = 150;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colEditioni
            // 
            this.colEditioni.HeaderText = "Editioni";
            this.colEditioni.Name = "colEditioni";
            this.colEditioni.ReadOnly = true;
            // 
            // colSasia
            // 
            this.colSasia.HeaderText = "Sasia";
            this.colSasia.Name = "colSasia";
            this.colSasia.ReadOnly = true;
            // 
            // colStatusi
            // 
            this.colStatusi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStatusi.HeaderText = "Statusi";
            this.colStatusi.Name = "colStatusi";
            this.colStatusi.ReadOnly = true;
            this.colStatusi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatusi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStatusi.Width = 120;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
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
            this.imageList2.Images.SetKeyName(0, "Picture2.png");
            this.imageList2.Images.SetKeyName(1, "Picture1.png");
            // 
            // frm_Librat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 782);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKategorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Librat";
            this.Text = "frm_Librat";
            this.Load += new System.EventHandler(this.frm_Librat_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Librat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKategorite;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private System.Windows.Forms.Label lblTotalLibra;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private Guna.UI.WinForms.GunaDataGridView dgv_Librat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBotuesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGjuha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditioni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSasia;
        private System.Windows.Forms.DataGridViewImageColumn colStatusi;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}