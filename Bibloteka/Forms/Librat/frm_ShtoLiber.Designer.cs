
namespace Bibloteka.Forms.Librat
{
    partial class frm_ShtoLiber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ShtoLiber));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtBotuesi = new Guna.UI.WinForms.GunaTextBox();
            this.txtAutori = new Guna.UI.WinForms.GunaTextBox();
            this.txtSasia = new Guna.UI.WinForms.GunaNumeric();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdtitioni = new Guna.UI.WinForms.GunaTextBox();
            this.comboStatusi = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboKategoria = new Guna.UI.WinForms.GunaComboBox();
            this.comboTipi = new Guna.UI.WinForms.GunaComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnulo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulli = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboGjuha = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.epLibri = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            resources.ApplyResources(this.gunaGroupBox1, "gunaGroupBox1");
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.txtBotuesi);
            this.gunaGroupBox1.Controls.Add(this.txtAutori);
            this.gunaGroupBox1.Controls.Add(this.txtSasia);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtEdtitioni);
            this.gunaGroupBox1.Controls.Add(this.comboStatusi);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.comboKategoria);
            this.gunaGroupBox1.Controls.Add(this.comboTipi);
            this.gunaGroupBox1.Controls.Add(this.panel2);
            this.gunaGroupBox1.Controls.Add(this.btnAnulo);
            this.gunaGroupBox1.Controls.Add(this.btnShto);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.txtTitulli);
            this.gunaGroupBox1.Controls.Add(this.label11);
            this.gunaGroupBox1.Controls.Add(this.comboGjuha);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtISBN);
            this.gunaGroupBox1.Controls.Add(this.label8);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label9);
            this.epLibri.SetError(this.gunaGroupBox1, resources.GetString("gunaGroupBox1.Error"));
            this.epLibri.SetIconAlignment(this.gunaGroupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gunaGroupBox1.IconAlignment"))));
            this.epLibri.SetIconPadding(this.gunaGroupBox1, ((int)(resources.GetObject("gunaGroupBox1.IconPadding"))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // txtBotuesi
            // 
            resources.ApplyResources(this.txtBotuesi, "txtBotuesi");
            this.txtBotuesi.BackColor = System.Drawing.Color.Transparent;
            this.txtBotuesi.BaseColor = System.Drawing.Color.White;
            this.txtBotuesi.BorderColor = System.Drawing.Color.Silver;
            this.txtBotuesi.BorderSize = 1;
            this.txtBotuesi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLibri.SetError(this.txtBotuesi, resources.GetString("txtBotuesi.Error"));
            this.txtBotuesi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBotuesi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtBotuesi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLibri.SetIconAlignment(this.txtBotuesi, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBotuesi.IconAlignment"))));
            this.epLibri.SetIconPadding(this.txtBotuesi, ((int)(resources.GetObject("txtBotuesi.IconPadding"))));
            this.txtBotuesi.Name = "txtBotuesi";
            this.txtBotuesi.PasswordChar = '\0';
            this.txtBotuesi.Radius = 3;
            this.txtBotuesi.SelectedText = "";
            // 
            // txtAutori
            // 
            resources.ApplyResources(this.txtAutori, "txtAutori");
            this.txtAutori.BackColor = System.Drawing.Color.Transparent;
            this.txtAutori.BaseColor = System.Drawing.Color.White;
            this.txtAutori.BorderColor = System.Drawing.Color.Silver;
            this.txtAutori.BorderSize = 1;
            this.txtAutori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLibri.SetError(this.txtAutori, resources.GetString("txtAutori.Error"));
            this.txtAutori.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAutori.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtAutori.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLibri.SetIconAlignment(this.txtAutori, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAutori.IconAlignment"))));
            this.epLibri.SetIconPadding(this.txtAutori, ((int)(resources.GetObject("txtAutori.IconPadding"))));
            this.txtAutori.Name = "txtAutori";
            this.txtAutori.PasswordChar = '\0';
            this.txtAutori.Radius = 3;
            this.txtAutori.SelectedText = "";
            // 
            // txtSasia
            // 
            resources.ApplyResources(this.txtSasia, "txtSasia");
            this.txtSasia.BackColor = System.Drawing.Color.Transparent;
            this.txtSasia.BaseColor = System.Drawing.Color.White;
            this.txtSasia.BorderColor = System.Drawing.Color.Silver;
            this.txtSasia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtSasia.ButtonForeColor = System.Drawing.Color.White;
            this.epLibri.SetError(this.txtSasia, resources.GetString("txtSasia.Error"));
            this.txtSasia.ForeColor = System.Drawing.Color.Black;
            this.epLibri.SetIconAlignment(this.txtSasia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSasia.IconAlignment"))));
            this.epLibri.SetIconPadding(this.txtSasia, ((int)(resources.GetObject("txtSasia.IconPadding"))));
            this.txtSasia.Maximum = ((long)(9999999));
            this.txtSasia.Minimum = ((long)(0));
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Radius = 3;
            this.txtSasia.Value = ((long)(0));
            this.txtSasia.ValueChanged += new System.EventHandler(this.txtSasia_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.epLibri.SetError(this.label4, resources.GetString("label4.Error"));
            this.epLibri.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.epLibri.SetError(this.label2, resources.GetString("label2.Error"));
            this.epLibri.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtEdtitioni
            // 
            resources.ApplyResources(this.txtEdtitioni, "txtEdtitioni");
            this.txtEdtitioni.BackColor = System.Drawing.Color.Transparent;
            this.txtEdtitioni.BaseColor = System.Drawing.Color.White;
            this.txtEdtitioni.BorderColor = System.Drawing.Color.Silver;
            this.txtEdtitioni.BorderSize = 1;
            this.txtEdtitioni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLibri.SetError(this.txtEdtitioni, resources.GetString("txtEdtitioni.Error"));
            this.txtEdtitioni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEdtitioni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEdtitioni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLibri.SetIconAlignment(this.txtEdtitioni, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEdtitioni.IconAlignment"))));
            this.epLibri.SetIconPadding(this.txtEdtitioni, ((int)(resources.GetObject("txtEdtitioni.IconPadding"))));
            this.txtEdtitioni.Name = "txtEdtitioni";
            this.txtEdtitioni.PasswordChar = '\0';
            this.txtEdtitioni.Radius = 3;
            this.txtEdtitioni.SelectedText = "";
            // 
            // comboStatusi
            // 
            resources.ApplyResources(this.comboStatusi, "comboStatusi");
            this.comboStatusi.BackColor = System.Drawing.Color.Transparent;
            this.comboStatusi.BaseColor = System.Drawing.Color.White;
            this.comboStatusi.BorderColor = System.Drawing.Color.Silver;
            this.comboStatusi.BorderSize = 1;
            this.comboStatusi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboStatusi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.epLibri.SetError(this.comboStatusi, resources.GetString("comboStatusi.Error"));
            this.comboStatusi.FocusedColor = System.Drawing.Color.Empty;
            this.comboStatusi.ForeColor = System.Drawing.Color.Black;
            this.comboStatusi.FormattingEnabled = true;
            this.epLibri.SetIconAlignment(this.comboStatusi, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboStatusi.IconAlignment"))));
            this.epLibri.SetIconPadding(this.comboStatusi, ((int)(resources.GetObject("comboStatusi.IconPadding"))));
            this.comboStatusi.Items.AddRange(new object[] {
            resources.GetString("comboStatusi.Items"),
            resources.GetString("comboStatusi.Items1")});
            this.comboStatusi.Name = "comboStatusi";
            this.comboStatusi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboStatusi.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboStatusi.Radius = 3;
            this.comboStatusi.StartIndex = 0;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.epLibri.SetError(this.label7, resources.GetString("label7.Error"));
            this.epLibri.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // comboKategoria
            // 
            resources.ApplyResources(this.comboKategoria, "comboKategoria");
            this.comboKategoria.BackColor = System.Drawing.Color.Transparent;
            this.comboKategoria.BaseColor = System.Drawing.Color.White;
            this.comboKategoria.BorderColor = System.Drawing.Color.Silver;
            this.comboKategoria.BorderSize = 1;
            this.comboKategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.epLibri.SetError(this.comboKategoria, resources.GetString("comboKategoria.Error"));
            this.comboKategoria.FocusedColor = System.Drawing.Color.Empty;
            this.comboKategoria.ForeColor = System.Drawing.Color.Black;
            this.comboKategoria.FormattingEnabled = true;
            this.epLibri.SetIconAlignment(this.comboKategoria, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboKategoria.IconAlignment"))));
            this.epLibri.SetIconPadding(this.comboKategoria, ((int)(resources.GetObject("comboKategoria.IconPadding"))));
            this.comboKategoria.Name = "comboKategoria";
            this.comboKategoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboKategoria.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboKategoria.Radius = 3;
            this.comboKategoria.SelectedValueChanged += new System.EventHandler(this.comboKategoria_SelectedValueChanged);
            this.comboKategoria.Click += new System.EventHandler(this.comboKategoria_Click);
            // 
            // comboTipi
            // 
            resources.ApplyResources(this.comboTipi, "comboTipi");
            this.comboTipi.BackColor = System.Drawing.Color.Transparent;
            this.comboTipi.BaseColor = System.Drawing.Color.White;
            this.comboTipi.BorderColor = System.Drawing.Color.Silver;
            this.comboTipi.BorderSize = 1;
            this.comboTipi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.epLibri.SetError(this.comboTipi, resources.GetString("comboTipi.Error"));
            this.comboTipi.FocusedColor = System.Drawing.Color.Empty;
            this.comboTipi.ForeColor = System.Drawing.Color.Black;
            this.comboTipi.FormattingEnabled = true;
            this.epLibri.SetIconAlignment(this.comboTipi, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboTipi.IconAlignment"))));
            this.epLibri.SetIconPadding(this.comboTipi, ((int)(resources.GetObject("comboTipi.IconPadding"))));
            this.comboTipi.Items.AddRange(new object[] {
            resources.GetString("comboTipi.Items")});
            this.comboTipi.Name = "comboTipi";
            this.comboTipi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboTipi.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboTipi.Radius = 3;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.epLibri.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.epLibri.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.epLibri.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.panel2.Name = "panel2";
            // 
            // btnAnulo
            // 
            resources.ApplyResources(this.btnAnulo, "btnAnulo");
            this.btnAnulo.AnimationHoverSpeed = 0.07F;
            this.btnAnulo.AnimationSpeed = 0.03F;
            this.btnAnulo.BackColor = System.Drawing.Color.Transparent;
            this.btnAnulo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnAnulo.BorderColor = System.Drawing.Color.Black;
            this.btnAnulo.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAnulo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAnulo.CheckedForeColor = System.Drawing.Color.White;
            this.btnAnulo.CheckedImage = null;
            this.btnAnulo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAnulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.epLibri.SetError(this.btnAnulo, resources.GetString("btnAnulo.Error"));
            this.btnAnulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnulo.ForeColor = System.Drawing.Color.White;
            this.epLibri.SetIconAlignment(this.btnAnulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAnulo.IconAlignment"))));
            this.epLibri.SetIconPadding(this.btnAnulo, ((int)(resources.GetObject("btnAnulo.IconPadding"))));
            this.btnAnulo.Image = null;
            this.btnAnulo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnulo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAnulo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnulo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnulo.OnHoverImage = null;
            this.btnAnulo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnulo.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnulo.Radius = 3;
            this.btnAnulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnulo.Click += new System.EventHandler(this.btnAnulo_Click);
            // 
            // btnShto
            // 
            resources.ApplyResources(this.btnShto, "btnShto");
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
            this.epLibri.SetError(this.btnShto, resources.GetString("btnShto.Error"));
            this.btnShto.FocusedColor = System.Drawing.Color.Empty;
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.epLibri.SetIconAlignment(this.btnShto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnShto.IconAlignment"))));
            this.epLibri.SetIconPadding(this.btnShto, ((int)(resources.GetObject("btnShto.IconPadding"))));
            this.btnShto.Image = null;
            this.btnShto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.Name = "btnShto";
            this.btnShto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnShto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShto.OnHoverImage = null;
            this.btnShto.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.OnPressedColor = System.Drawing.Color.Black;
            this.btnShto.Radius = 3;
            this.btnShto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.epLibri.SetError(this.label3, resources.GetString("label3.Error"));
            this.epLibri.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // txtTitulli
            // 
            resources.ApplyResources(this.txtTitulli, "txtTitulli");
            this.txtTitulli.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulli.BaseColor = System.Drawing.Color.White;
            this.txtTitulli.BorderColor = System.Drawing.Color.Silver;
            this.txtTitulli.BorderSize = 1;
            this.txtTitulli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLibri.SetError(this.txtTitulli, resources.GetString("txtTitulli.Error"));
            this.txtTitulli.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTitulli.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtTitulli.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLibri.SetIconAlignment(this.txtTitulli, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTitulli.IconAlignment"))));
            this.epLibri.SetIconPadding(this.txtTitulli, ((int)(resources.GetObject("txtTitulli.IconPadding"))));
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.PasswordChar = '\0';
            this.txtTitulli.Radius = 3;
            this.txtTitulli.SelectedText = "";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.epLibri.SetError(this.label11, resources.GetString("label11.Error"));
            this.epLibri.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // comboGjuha
            // 
            resources.ApplyResources(this.comboGjuha, "comboGjuha");
            this.comboGjuha.BackColor = System.Drawing.Color.Transparent;
            this.comboGjuha.BaseColor = System.Drawing.Color.White;
            this.comboGjuha.BorderColor = System.Drawing.Color.Silver;
            this.comboGjuha.BorderSize = 1;
            this.comboGjuha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGjuha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.epLibri.SetError(this.comboGjuha, resources.GetString("comboGjuha.Error"));
            this.comboGjuha.FocusedColor = System.Drawing.Color.Empty;
            this.comboGjuha.ForeColor = System.Drawing.Color.Black;
            this.comboGjuha.FormattingEnabled = true;
            this.epLibri.SetIconAlignment(this.comboGjuha, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboGjuha.IconAlignment"))));
            this.epLibri.SetIconPadding(this.comboGjuha, ((int)(resources.GetObject("comboGjuha.IconPadding"))));
            this.comboGjuha.Items.AddRange(new object[] {
            resources.GetString("comboGjuha.Items")});
            this.comboGjuha.Name = "comboGjuha";
            this.comboGjuha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboGjuha.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboGjuha.Radius = 3;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.epLibri.SetError(this.label1, resources.GetString("label1.Error"));
            this.epLibri.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtISBN
            // 
            resources.ApplyResources(this.txtISBN, "txtISBN");
            this.txtISBN.BackColor = System.Drawing.Color.Transparent;
            this.txtISBN.BaseColor = System.Drawing.Color.White;
            this.txtISBN.BorderColor = System.Drawing.Color.Silver;
            this.txtISBN.BorderSize = 1;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLibri.SetError(this.txtISBN, resources.GetString("txtISBN.Error"));
            this.txtISBN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtISBN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtISBN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLibri.SetIconAlignment(this.txtISBN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtISBN.IconAlignment"))));
            this.epLibri.SetIconPadding(this.txtISBN, ((int)(resources.GetObject("txtISBN.IconPadding"))));
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.Radius = 3;
            this.txtISBN.SelectedText = "";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.epLibri.SetError(this.label8, resources.GetString("label8.Error"));
            this.epLibri.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.epLibri.SetError(this.label5, resources.GetString("label5.Error"));
            this.epLibri.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.epLibri.SetError(this.label6, resources.GetString("label6.Error"));
            this.epLibri.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.epLibri.SetError(this.label9, resources.GetString("label9.Error"));
            this.epLibri.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.epLibri.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this.gunaGroupBox1;
            // 
            // epLibri
            // 
            this.epLibri.ContainerControl = this;
            resources.ApplyResources(this.epLibri, "epLibri");
            // 
            // frm_ShtoLiber
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ShtoLiber";
            this.Load += new System.EventHandler(this.frm_ShtoLiber_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLibri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtEdtitioni;
        private Guna.UI.WinForms.GunaComboBox comboStatusi;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox comboKategoria;
        private Guna.UI.WinForms.GunaComboBox comboTipi;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnulo;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtTitulli;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaComboBox comboGjuha;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaDragControl dragForm;
        private Guna.UI.WinForms.GunaNumeric txtSasia;
        private Guna.UI.WinForms.GunaTextBox txtAutori;
        private Guna.UI.WinForms.GunaTextBox txtBotuesi;
        private System.Windows.Forms.ErrorProvider epLibri;
    }
}