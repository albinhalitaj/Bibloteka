
namespace Bibloteka.Forms
{
    partial class frm_Klientet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Klientet));
            this.dgv_Klientet = new Guna.UI.WinForms.GunaDataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatalindjes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGjinia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrKontaktues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQyteti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShteti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKodiPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmaili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKerko = new Guna.UI.WinForms.GunaTextBox();
            this.btnFshi = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNdrysho = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblTotalKlients = new System.Windows.Forms.Label();
            this.lblKategorite = new System.Windows.Forms.Label();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klientet)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Klientet
            // 
            this.dgv_Klientet.AllowUserToAddRows = false;
            this.dgv_Klientet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Klientet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Klientet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Klientet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Klientet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Klientet.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Klientet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Klientet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Klientet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Klientet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Klientet.ColumnHeadersHeight = 41;
            this.dgv_Klientet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colEmri,
            this.colMbiemri,
            this.colDatalindjes,
            this.colGjinia,
            this.colNrPersonal,
            this.NrKontaktues,
            this.colAdresa,
            this.colQyteti,
            this.colShteti,
            this.colKodiPostal,
            this.colEmaili});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Klientet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Klientet.EnableHeadersVisualStyles = false;
            this.dgv_Klientet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Klientet.Location = new System.Drawing.Point(37, 101);
            this.dgv_Klientet.Name = "dgv_Klientet";
            this.dgv_Klientet.ReadOnly = true;
            this.dgv_Klientet.RowHeadersVisible = false;
            this.dgv_Klientet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Klientet.Size = new System.Drawing.Size(987, 494);
            this.dgv_Klientet.TabIndex = 23;
            this.dgv_Klientet.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Klientet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Klientet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Klientet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Klientet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Klientet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Klientet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Klientet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Klientet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dgv_Klientet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Klientet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Klientet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Klientet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Klientet.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Klientet.ThemeStyle.ReadOnly = true;
            this.dgv_Klientet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Klientet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Klientet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Klientet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Klientet.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Klientet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Klientet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colID
            // 
            this.colID.HeaderText = "KlientiID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colEmri
            // 
            this.colEmri.HeaderText = "Emri";
            this.colEmri.Name = "colEmri";
            this.colEmri.ReadOnly = true;
            // 
            // colMbiemri
            // 
            this.colMbiemri.HeaderText = "Mbiemri";
            this.colMbiemri.Name = "colMbiemri";
            this.colMbiemri.ReadOnly = true;
            // 
            // colDatalindjes
            // 
            this.colDatalindjes.HeaderText = "Datalindjes";
            this.colDatalindjes.Name = "colDatalindjes";
            this.colDatalindjes.ReadOnly = true;
            // 
            // colGjinia
            // 
            this.colGjinia.HeaderText = "Gjinia";
            this.colGjinia.Name = "colGjinia";
            this.colGjinia.ReadOnly = true;
            // 
            // colNrPersonal
            // 
            this.colNrPersonal.HeaderText = "NrPersonal";
            this.colNrPersonal.Name = "colNrPersonal";
            this.colNrPersonal.ReadOnly = true;
            // 
            // NrKontaktues
            // 
            this.NrKontaktues.HeaderText = "NrKontaktues";
            this.NrKontaktues.Name = "NrKontaktues";
            this.NrKontaktues.ReadOnly = true;
            // 
            // colAdresa
            // 
            this.colAdresa.HeaderText = "Adresa";
            this.colAdresa.Name = "colAdresa";
            this.colAdresa.ReadOnly = true;
            // 
            // colQyteti
            // 
            this.colQyteti.HeaderText = "Qyteti";
            this.colQyteti.Name = "colQyteti";
            this.colQyteti.ReadOnly = true;
            // 
            // colShteti
            // 
            this.colShteti.HeaderText = "Shteti";
            this.colShteti.Name = "colShteti";
            this.colShteti.ReadOnly = true;
            // 
            // colKodiPostal
            // 
            this.colKodiPostal.HeaderText = "KodiPostal";
            this.colKodiPostal.Name = "colKodiPostal";
            this.colKodiPostal.ReadOnly = true;
            // 
            // colEmaili
            // 
            this.colEmaili.HeaderText = "Emaili";
            this.colEmaili.Name = "colEmaili";
            this.colEmaili.ReadOnly = true;
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
            this.txtKerko.BorderColor = System.Drawing.Color.Gray;
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
            // 
            // btnFshi
            // 
            this.btnFshi.AnimationHoverSpeed = 0.07F;
            this.btnFshi.AnimationSpeed = 0.03F;
            this.btnFshi.BackColor = System.Drawing.Color.Transparent;
            this.btnFshi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnFshi.BorderColor = System.Drawing.Color.Black;
            this.btnFshi.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnFshi.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFshi.CheckedForeColor = System.Drawing.Color.White;
            this.btnFshi.CheckedImage = null;
            this.btnFshi.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFshi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFshi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFshi.FocusedColor = System.Drawing.Color.Empty;
            this.btnFshi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFshi.ForeColor = System.Drawing.Color.White;
            this.btnFshi.Image = null;
            this.btnFshi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFshi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFshi.Location = new System.Drawing.Point(298, 37);
            this.btnFshi.Margin = new System.Windows.Forms.Padding(2);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnFshi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFshi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFshi.OnHoverImage = null;
            this.btnFshi.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFshi.OnPressedColor = System.Drawing.Color.Black;
            this.btnFshi.Radius = 3;
            this.btnFshi.Size = new System.Drawing.Size(86, 34);
            this.btnFshi.TabIndex = 26;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnNdrysho
            // 
            this.btnNdrysho.AnimationHoverSpeed = 0.07F;
            this.btnNdrysho.AnimationSpeed = 0.03F;
            this.btnNdrysho.BackColor = System.Drawing.Color.Transparent;
            this.btnNdrysho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnNdrysho.BorderColor = System.Drawing.Color.Black;
            this.btnNdrysho.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnNdrysho.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNdrysho.CheckedForeColor = System.Drawing.Color.White;
            this.btnNdrysho.CheckedImage = null;
            this.btnNdrysho.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNdrysho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNdrysho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNdrysho.FocusedColor = System.Drawing.Color.Empty;
            this.btnNdrysho.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNdrysho.ForeColor = System.Drawing.Color.White;
            this.btnNdrysho.Image = null;
            this.btnNdrysho.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNdrysho.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNdrysho.Location = new System.Drawing.Point(186, 37);
            this.btnNdrysho.Margin = new System.Windows.Forms.Padding(2);
            this.btnNdrysho.Name = "btnNdrysho";
            this.btnNdrysho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnNdrysho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNdrysho.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNdrysho.OnHoverImage = null;
            this.btnNdrysho.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNdrysho.OnPressedColor = System.Drawing.Color.Black;
            this.btnNdrysho.Radius = 3;
            this.btnNdrysho.Size = new System.Drawing.Size(86, 34);
            this.btnNdrysho.TabIndex = 25;
            this.btnNdrysho.Text = "Ndrysho";
            this.btnNdrysho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gunaGroupBox1.Controls.Add(this.lblTotalKlients);
            this.gunaGroupBox1.Controls.Add(this.btnFshi);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtKerko);
            this.gunaGroupBox1.Controls.Add(this.btnNdrysho);
            this.gunaGroupBox1.Controls.Add(this.dgv_Klientet);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(37, 101);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1062, 638);
            this.gunaGroupBox1.TabIndex = 29;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // lblTotalKlients
            // 
            this.lblTotalKlients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalKlients.AutoSize = true;
            this.lblTotalKlients.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKlients.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTotalKlients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalKlients.Location = new System.Drawing.Point(32, 598);
            this.lblTotalKlients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalKlients.Name = "lblTotalKlients";
            this.lblTotalKlients.Size = new System.Drawing.Size(110, 26);
            this.lblTotalKlients.TabIndex = 29;
            this.lblTotalKlients.Text = "Total Klientë:";
            // 
            // lblKategorite
            // 
            this.lblKategorite.AutoSize = true;
            this.lblKategorite.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorite.Location = new System.Drawing.Point(30, 29);
            this.lblKategorite.Name = "lblKategorite";
            this.lblKategorite.Size = new System.Drawing.Size(107, 42);
            this.lblKategorite.TabIndex = 30;
            this.lblKategorite.Text = "Klientët";
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
            this.btnShto.Text = "Shto Klient";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // frm_Klientet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 762);
            this.Controls.Add(this.lblKategorite);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Klientet";
            this.Text = "frm_Klientet";
            this.Load += new System.EventHandler(this.frm_Klientet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klientet)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgv_Klientet;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private Guna.UI.WinForms.GunaAdvenceButton btnFshi;
        private Guna.UI.WinForms.GunaAdvenceButton btnNdrysho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatalindjes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGjinia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrKontaktues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQyteti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShteti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKodiPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmaili;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label lblKategorite;
        private System.Windows.Forms.Label lblTotalKlients;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
    }
}