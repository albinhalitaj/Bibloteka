
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
            this.lblLibrat = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtAutori = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAutori = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNumriKopjev = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumriKopjev = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGjuha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblKategori = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbGjuha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbKategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTitulli = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulli = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBotusi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBotuesi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDepartmenti = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEdiconi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEdicioni = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbDepartmenti = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatusi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbStatusi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnShto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibrat
            // 
            this.lblLibrat.AutoSize = true;
            this.lblLibrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrat.Location = new System.Drawing.Point(24, 18);
            this.lblLibrat.Name = "lblLibrat";
            this.lblLibrat.Size = new System.Drawing.Size(73, 29);
            this.lblLibrat.TabIndex = 3;
            this.lblLibrat.Text = "Librat";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnShto);
            this.guna2GroupBox1.Controls.Add(this.cmbKategoria);
            this.guna2GroupBox1.Controls.Add(this.cmbStatusi);
            this.guna2GroupBox1.Controls.Add(this.cmbDepartmenti);
            this.guna2GroupBox1.Controls.Add(this.cmbGjuha);
            this.guna2GroupBox1.Controls.Add(this.lblKategori);
            this.guna2GroupBox1.Controls.Add(this.lblGjuha);
            this.guna2GroupBox1.Controls.Add(this.lblNumriKopjev);
            this.guna2GroupBox1.Controls.Add(this.lblStatusi);
            this.guna2GroupBox1.Controls.Add(this.lblEdicioni);
            this.guna2GroupBox1.Controls.Add(this.lblDepartmenti);
            this.guna2GroupBox1.Controls.Add(this.lblBotuesi);
            this.guna2GroupBox1.Controls.Add(this.lblTitulli);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.lblAutori);
            this.guna2GroupBox1.Controls.Add(this.txtNumriKopjev);
            this.guna2GroupBox1.Controls.Add(this.txtEdiconi);
            this.guna2GroupBox1.Controls.Add(this.txtBotusi);
            this.guna2GroupBox1.Controls.Add(this.txtTitulli);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.txtAutori);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(29, 62);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(865, 485);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Informatat e Librit";
            // 
            // txtAutori
            // 
            this.txtAutori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutori.DefaultText = "";
            this.txtAutori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAutori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAutori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutori.DisabledState.Parent = this.txtAutori;
            this.txtAutori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAutori.FocusedState.Parent = this.txtAutori;
            this.txtAutori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAutori.HoverState.Parent = this.txtAutori;
            this.txtAutori.Location = new System.Drawing.Point(14, 151);
            this.txtAutori.Name = "txtAutori";
            this.txtAutori.PasswordChar = '\0';
            this.txtAutori.PlaceholderText = "";
            this.txtAutori.SelectedText = "";
            this.txtAutori.ShadowDecoration.Parent = this.txtAutori;
            this.txtAutori.Size = new System.Drawing.Size(200, 36);
            this.txtAutori.TabIndex = 0;
            // 
            // lblAutori
            // 
            this.lblAutori.BackColor = System.Drawing.Color.Transparent;
            this.lblAutori.Location = new System.Drawing.Point(14, 128);
            this.lblAutori.Name = "lblAutori";
            this.lblAutori.Size = new System.Drawing.Size(36, 17);
            this.lblAutori.TabIndex = 1;
            this.lblAutori.Text = "Autori";
            // 
            // txtNumriKopjev
            // 
            this.txtNumriKopjev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumriKopjev.DefaultText = "";
            this.txtNumriKopjev.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumriKopjev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumriKopjev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumriKopjev.DisabledState.Parent = this.txtNumriKopjev;
            this.txtNumriKopjev.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumriKopjev.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumriKopjev.FocusedState.Parent = this.txtNumriKopjev;
            this.txtNumriKopjev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumriKopjev.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumriKopjev.HoverState.Parent = this.txtNumriKopjev;
            this.txtNumriKopjev.Location = new System.Drawing.Point(14, 388);
            this.txtNumriKopjev.Name = "txtNumriKopjev";
            this.txtNumriKopjev.PasswordChar = '\0';
            this.txtNumriKopjev.PlaceholderText = "";
            this.txtNumriKopjev.SelectedText = "";
            this.txtNumriKopjev.ShadowDecoration.Parent = this.txtNumriKopjev;
            this.txtNumriKopjev.Size = new System.Drawing.Size(200, 36);
            this.txtNumriKopjev.TabIndex = 0;
            // 
            // lblNumriKopjev
            // 
            this.lblNumriKopjev.BackColor = System.Drawing.Color.Transparent;
            this.lblNumriKopjev.Location = new System.Drawing.Point(12, 365);
            this.lblNumriKopjev.Name = "lblNumriKopjev";
            this.lblNumriKopjev.Size = new System.Drawing.Size(73, 17);
            this.lblNumriKopjev.TabIndex = 1;
            this.lblNumriKopjev.Text = "NumriKopjev";
            this.lblNumriKopjev.Click += new System.EventHandler(this.lblAutori_Click);
            // 
            // lblGjuha
            // 
            this.lblGjuha.BackColor = System.Drawing.Color.Transparent;
            this.lblGjuha.Location = new System.Drawing.Point(14, 208);
            this.lblGjuha.Name = "lblGjuha";
            this.lblGjuha.Size = new System.Drawing.Size(34, 17);
            this.lblGjuha.TabIndex = 1;
            this.lblGjuha.Text = "Gjuha";
            // 
            // lblKategori
            // 
            this.lblKategori.BackColor = System.Drawing.Color.Transparent;
            this.lblKategori.Location = new System.Drawing.Point(14, 284);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(53, 17);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategoria";
            // 
            // cmbGjuha
            // 
            this.cmbGjuha.BackColor = System.Drawing.Color.Transparent;
            this.cmbGjuha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGjuha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGjuha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGjuha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGjuha.FocusedState.Parent = this.cmbGjuha;
            this.cmbGjuha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGjuha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGjuha.HoverState.Parent = this.cmbGjuha;
            this.cmbGjuha.ItemHeight = 30;
            this.cmbGjuha.ItemsAppearance.Parent = this.cmbGjuha;
            this.cmbGjuha.Location = new System.Drawing.Point(14, 231);
            this.cmbGjuha.Name = "cmbGjuha";
            this.cmbGjuha.ShadowDecoration.Parent = this.cmbGjuha;
            this.cmbGjuha.Size = new System.Drawing.Size(200, 36);
            this.cmbGjuha.TabIndex = 2;
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbKategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKategoria.FocusedState.Parent = this.cmbKategoria;
            this.cmbKategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbKategoria.HoverState.Parent = this.cmbKategoria;
            this.cmbKategoria.ItemHeight = 30;
            this.cmbKategoria.ItemsAppearance.Parent = this.cmbKategoria;
            this.cmbKategoria.Location = new System.Drawing.Point(14, 307);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.ShadowDecoration.Parent = this.cmbKategoria;
            this.cmbKategoria.Size = new System.Drawing.Size(200, 36);
            this.cmbKategoria.TabIndex = 3;
            // 
            // txtTitulli
            // 
            this.txtTitulli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulli.DefaultText = "";
            this.txtTitulli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulli.DisabledState.Parent = this.txtTitulli;
            this.txtTitulli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulli.FocusedState.Parent = this.txtTitulli;
            this.txtTitulli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitulli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulli.HoverState.Parent = this.txtTitulli;
            this.txtTitulli.Location = new System.Drawing.Point(411, 80);
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.PasswordChar = '\0';
            this.txtTitulli.PlaceholderText = "";
            this.txtTitulli.SelectedText = "";
            this.txtTitulli.ShadowDecoration.Parent = this.txtTitulli;
            this.txtTitulli.Size = new System.Drawing.Size(200, 36);
            this.txtTitulli.TabIndex = 0;
            // 
            // lblTitulli
            // 
            this.lblTitulli.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulli.Location = new System.Drawing.Point(411, 57);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(32, 17);
            this.lblTitulli.TabIndex = 1;
            this.lblTitulli.Text = "Titulli";
            this.lblTitulli.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // txtBotusi
            // 
            this.txtBotusi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBotusi.DefaultText = "";
            this.txtBotusi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBotusi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBotusi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBotusi.DisabledState.Parent = this.txtBotusi;
            this.txtBotusi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBotusi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBotusi.FocusedState.Parent = this.txtBotusi;
            this.txtBotusi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBotusi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBotusi.HoverState.Parent = this.txtBotusi;
            this.txtBotusi.Location = new System.Drawing.Point(411, 151);
            this.txtBotusi.Name = "txtBotusi";
            this.txtBotusi.PasswordChar = '\0';
            this.txtBotusi.PlaceholderText = "";
            this.txtBotusi.SelectedText = "";
            this.txtBotusi.ShadowDecoration.Parent = this.txtBotusi;
            this.txtBotusi.Size = new System.Drawing.Size(200, 36);
            this.txtBotusi.TabIndex = 0;
            // 
            // lblBotuesi
            // 
            this.lblBotuesi.BackColor = System.Drawing.Color.Transparent;
            this.lblBotuesi.Location = new System.Drawing.Point(411, 128);
            this.lblBotuesi.Name = "lblBotuesi";
            this.lblBotuesi.Size = new System.Drawing.Size(36, 17);
            this.lblBotuesi.TabIndex = 1;
            this.lblBotuesi.Text = "Botusi";
            // 
            // lblDepartmenti
            // 
            this.lblDepartmenti.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmenti.Location = new System.Drawing.Point(411, 208);
            this.lblDepartmenti.Name = "lblDepartmenti";
            this.lblDepartmenti.Size = new System.Drawing.Size(69, 17);
            this.lblDepartmenti.TabIndex = 1;
            this.lblDepartmenti.Text = "Departmenti";
            // 
            // txtEdiconi
            // 
            this.txtEdiconi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdiconi.DefaultText = "";
            this.txtEdiconi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdiconi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdiconi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdiconi.DisabledState.Parent = this.txtEdiconi;
            this.txtEdiconi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdiconi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdiconi.FocusedState.Parent = this.txtEdiconi;
            this.txtEdiconi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEdiconi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdiconi.HoverState.Parent = this.txtEdiconi;
            this.txtEdiconi.Location = new System.Drawing.Point(411, 307);
            this.txtEdiconi.Name = "txtEdiconi";
            this.txtEdiconi.PasswordChar = '\0';
            this.txtEdiconi.PlaceholderText = "";
            this.txtEdiconi.SelectedText = "";
            this.txtEdiconi.ShadowDecoration.Parent = this.txtEdiconi;
            this.txtEdiconi.Size = new System.Drawing.Size(200, 36);
            this.txtEdiconi.TabIndex = 0;
            // 
            // lblEdicioni
            // 
            this.lblEdicioni.BackColor = System.Drawing.Color.Transparent;
            this.lblEdicioni.Location = new System.Drawing.Point(411, 284);
            this.lblEdicioni.Name = "lblEdicioni";
            this.lblEdicioni.Size = new System.Drawing.Size(42, 17);
            this.lblEdicioni.TabIndex = 1;
            this.lblEdicioni.Text = "Ediconi";
            // 
            // cmbDepartmenti
            // 
            this.cmbDepartmenti.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepartmenti.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartmenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmenti.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartmenti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartmenti.FocusedState.Parent = this.cmbDepartmenti;
            this.cmbDepartmenti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartmenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepartmenti.HoverState.Parent = this.cmbDepartmenti;
            this.cmbDepartmenti.ItemHeight = 30;
            this.cmbDepartmenti.ItemsAppearance.Parent = this.cmbDepartmenti;
            this.cmbDepartmenti.Location = new System.Drawing.Point(411, 231);
            this.cmbDepartmenti.Name = "cmbDepartmenti";
            this.cmbDepartmenti.ShadowDecoration.Parent = this.cmbDepartmenti;
            this.cmbDepartmenti.Size = new System.Drawing.Size(200, 36);
            this.cmbDepartmenti.TabIndex = 2;
            // 
            // lblStatusi
            // 
            this.lblStatusi.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusi.Location = new System.Drawing.Point(411, 365);
            this.lblStatusi.Name = "lblStatusi";
            this.lblStatusi.Size = new System.Drawing.Size(38, 17);
            this.lblStatusi.TabIndex = 1;
            this.lblStatusi.Text = "Statusi";
            // 
            // cmbStatusi
            // 
            this.cmbStatusi.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatusi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatusi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatusi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatusi.FocusedState.Parent = this.cmbStatusi;
            this.cmbStatusi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatusi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatusi.HoverState.Parent = this.cmbStatusi;
            this.cmbStatusi.ItemHeight = 30;
            this.cmbStatusi.ItemsAppearance.Parent = this.cmbStatusi;
            this.cmbStatusi.Location = new System.Drawing.Point(411, 388);
            this.cmbStatusi.Name = "cmbStatusi";
            this.cmbStatusi.ShadowDecoration.Parent = this.cmbStatusi;
            this.cmbStatusi.Size = new System.Drawing.Size(200, 36);
            this.cmbStatusi.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(12, 80);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "LibriID";
            // 
            // btnShto
            // 
            this.btnShto.CheckedState.Parent = this.btnShto;
            this.btnShto.CustomImages.Parent = this.btnShto;
            this.btnShto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.HoverState.Parent = this.btnShto;
            this.btnShto.Location = new System.Drawing.Point(14, 440);
            this.btnShto.Name = "btnShto";
            this.btnShto.ShadowDecoration.Parent = this.btnShto;
            this.btnShto.Size = new System.Drawing.Size(117, 32);
            this.btnShto.TabIndex = 4;
            this.btnShto.Text = "Shto";
            // 
            // frm_Librat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 586);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblLibrat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Librat";
            this.Text = "frm_Librat";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibrat;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGjuha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKategori;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGjuha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumriKopjev;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEdicioni;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDepartmenti;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBotuesi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulli;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAutori;
        private Guna.UI2.WinForms.Guna2TextBox txtNumriKopjev;
        private Guna.UI2.WinForms.Guna2TextBox txtEdiconi;
        private Guna.UI2.WinForms.Guna2TextBox txtBotusi;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulli;
        private Guna.UI2.WinForms.Guna2TextBox txtAutori;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepartmenti;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatusi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatusi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnShto;
    }
}