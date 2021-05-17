
namespace Bibloteka.Forms
{
    partial class frm_Kategorite
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
            this.lblKategorite = new System.Windows.Forms.Label();
            this.txtPershkrimi = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmertimi = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNdrysho = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnFshi = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKerko = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_Kategorite = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epKategorite = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotalCategories = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kategorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKategorite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKategorite
            // 
            this.lblKategorite.AutoSize = true;
            this.lblKategorite.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorite.Location = new System.Drawing.Point(24, 19);
            this.lblKategorite.Name = "lblKategorite";
            this.lblKategorite.Size = new System.Drawing.Size(142, 42);
            this.lblKategorite.TabIndex = 1;
            this.lblKategorite.Text = "Kategoritë";
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.BackColor = System.Drawing.Color.Transparent;
            this.txtPershkrimi.BaseColor = System.Drawing.Color.White;
            this.txtPershkrimi.BorderColor = System.Drawing.Color.Gray;
            this.txtPershkrimi.BorderSize = 1;
            this.txtPershkrimi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPershkrimi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPershkrimi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtPershkrimi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPershkrimi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPershkrimi.Location = new System.Drawing.Point(46, 255);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.PasswordChar = '\0';
            this.txtPershkrimi.Radius = 3;
            this.txtPershkrimi.SelectedText = "";
            this.txtPershkrimi.Size = new System.Drawing.Size(250, 34);
            this.txtPershkrimi.TabIndex = 16;
            // 
            // txtEmertimi
            // 
            this.txtEmertimi.BackColor = System.Drawing.Color.Transparent;
            this.txtEmertimi.BaseColor = System.Drawing.Color.White;
            this.txtEmertimi.BorderColor = System.Drawing.Color.Gray;
            this.txtEmertimi.BorderSize = 1;
            this.txtEmertimi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmertimi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmertimi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEmertimi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmertimi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmertimi.Location = new System.Drawing.Point(46, 150);
            this.txtEmertimi.Name = "txtEmertimi";
            this.txtEmertimi.PasswordChar = '\0';
            this.txtEmertimi.Radius = 3;
            this.txtEmertimi.SelectedText = "";
            this.txtEmertimi.Size = new System.Drawing.Size(250, 34);
            this.txtEmertimi.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(41, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Përshkrimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(41, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "*Emërtimi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(32, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 3);
            this.panel1.TabIndex = 18;
            // 
            // btnShto
            // 
            this.btnShto.AnimationHoverSpeed = 0.07F;
            this.btnShto.AnimationSpeed = 0.03F;
            this.btnShto.BackColor = System.Drawing.Color.Transparent;
            this.btnShto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnShto.BorderColor = System.Drawing.Color.Black;
            this.btnShto.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnShto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShto.CheckedForeColor = System.Drawing.Color.White;
            this.btnShto.CheckedImage = null;
            this.btnShto.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShto.FocusedColor = System.Drawing.Color.Empty;
            this.btnShto.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.Image = null;
            this.btnShto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.Location = new System.Drawing.Point(349, 255);
            this.btnShto.Margin = new System.Windows.Forms.Padding(2);
            this.btnShto.Name = "btnShto";
            this.btnShto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnShto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShto.OnHoverImage = null;
            this.btnShto.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.OnPressedColor = System.Drawing.Color.Black;
            this.btnShto.Radius = 3;
            this.btnShto.Size = new System.Drawing.Size(78, 34);
            this.btnShto.TabIndex = 19;
            this.btnShto.Text = "Shto";
            this.btnShto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
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
            this.btnNdrysho.Location = new System.Drawing.Point(456, 255);
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
            this.btnNdrysho.TabIndex = 20;
            this.btnNdrysho.Text = "Ndrysho";
            this.btnNdrysho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNdrysho.Click += new System.EventHandler(this.btnNdrysho_Click);
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
            this.btnFshi.Location = new System.Drawing.Point(565, 255);
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
            this.btnFshi.TabIndex = 21;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(586, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 23;
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
            this.txtKerko.Location = new System.Drawing.Point(656, 351);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.PasswordChar = '\0';
            this.txtKerko.Radius = 3;
            this.txtKerko.SelectedText = "";
            this.txtKerko.Size = new System.Drawing.Size(250, 34);
            this.txtKerko.TabIndex = 22;
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            // 
            // dgv_Kategorite
            // 
            this.dgv_Kategorite.AllowUserToAddRows = false;
            this.dgv_Kategorite.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Kategorite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Kategorite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kategorite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Kategorite.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Kategorite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Kategorite.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Kategorite.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Kategorite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Kategorite.ColumnHeadersHeight = 41;
            this.dgv_Kategorite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Kategorite.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Kategorite.EnableHeadersVisualStyles = false;
            this.dgv_Kategorite.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Kategorite.Location = new System.Drawing.Point(46, 413);
            this.dgv_Kategorite.Name = "dgv_Kategorite";
            this.dgv_Kategorite.ReadOnly = true;
            this.dgv_Kategorite.RowHeadersVisible = false;
            this.dgv_Kategorite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kategorite.Size = new System.Drawing.Size(860, 239);
            this.dgv_Kategorite.TabIndex = 24;
            this.dgv_Kategorite.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Kategorite.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Kategorite.ThemeStyle.ReadOnly = true;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Kategorite.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Kategorite.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Kategorite.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Kategorite.DoubleClick += new System.EventHandler(this.dgv_Kategorite_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emertimi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Përshkrimi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // epKategorite
            // 
            this.epKategorite.ContainerControl = this;
            // 
            // lblTotalCategories
            // 
            this.lblTotalCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalCategories.AutoSize = true;
            this.lblTotalCategories.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.lblTotalCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalCategories.Location = new System.Drawing.Point(41, 655);
            this.lblTotalCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCategories.Name = "lblTotalCategories";
            this.lblTotalCategories.Size = new System.Drawing.Size(110, 25);
            this.lblTotalCategories.TabIndex = 25;
            this.lblTotalCategories.Text = "Total Kategori:";
            // 
            // frm_Kategorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 695);
            this.Controls.Add(this.lblTotalCategories);
            this.Controls.Add(this.dgv_Kategorite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKerko);
            this.Controls.Add(this.btnFshi);
            this.Controls.Add(this.btnNdrysho);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.txtEmertimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKategorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Kategorite";
            this.Text = "frm_Kategorite";
            this.Load += new System.EventHandler(this.frm_Kategorite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kategorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKategorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorite;
        private Guna.UI.WinForms.GunaTextBox txtPershkrimi;
        private Guna.UI.WinForms.GunaTextBox txtEmertimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private Guna.UI.WinForms.GunaAdvenceButton btnNdrysho;
        private Guna.UI.WinForms.GunaAdvenceButton btnFshi;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private Guna.UI.WinForms.GunaDataGridView dgv_Kategorite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ErrorProvider epKategorite;
        private System.Windows.Forms.Label lblTotalCategories;
    }
}