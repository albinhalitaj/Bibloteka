
namespace Bibloteka.Forms
{
    partial class frm_ShtoKlient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ShtoKlient));
            this.txtEmri = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnulo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtMbiemri = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNrPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrKontaktues = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataKlientit = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresa = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodiPostal = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmaili = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboShteti = new Guna.UI.WinForms.GunaComboBox();
            this.comboQyteti = new Guna.UI.WinForms.GunaComboBox();
            this.epKlienti = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.radioMashkull = new Guna.UI.WinForms.GunaRadioButton();
            this.radioFemer = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epKlienti)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmri
            // 
            resources.ApplyResources(this.txtEmri, "txtEmri");
            this.txtEmri.BackColor = System.Drawing.Color.Transparent;
            this.txtEmri.BaseColor = System.Drawing.Color.White;
            this.txtEmri.BorderColor = System.Drawing.Color.Silver;
            this.txtEmri.BorderSize = 1;
            this.txtEmri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtEmri, resources.GetString("txtEmri.Error"));
            this.txtEmri.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmri.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEmri.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtEmri, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmri.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtEmri, ((int)(resources.GetObject("txtEmri.IconPadding"))));
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.PasswordChar = '\0';
            this.txtEmri.Radius = 3;
            this.txtEmri.SelectedText = "";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.epKlienti.SetError(this.label3, resources.GetString("label3.Error"));
            this.epKlienti.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
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
            this.epKlienti.SetError(this.btnAnulo, resources.GetString("btnAnulo.Error"));
            this.btnAnulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnulo.ForeColor = System.Drawing.Color.White;
            this.epKlienti.SetIconAlignment(this.btnAnulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAnulo.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.btnAnulo, ((int)(resources.GetObject("btnAnulo.IconPadding"))));
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
            this.epKlienti.SetError(this.btnShto, resources.GetString("btnShto.Error"));
            this.btnShto.FocusedColor = System.Drawing.Color.Empty;
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.epKlienti.SetIconAlignment(this.btnShto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnShto.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.btnShto, ((int)(resources.GetObject("btnShto.IconPadding"))));
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
            // txtMbiemri
            // 
            resources.ApplyResources(this.txtMbiemri, "txtMbiemri");
            this.txtMbiemri.BackColor = System.Drawing.Color.Transparent;
            this.txtMbiemri.BaseColor = System.Drawing.Color.White;
            this.txtMbiemri.BorderColor = System.Drawing.Color.Silver;
            this.txtMbiemri.BorderSize = 1;
            this.txtMbiemri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtMbiemri, resources.GetString("txtMbiemri.Error"));
            this.txtMbiemri.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMbiemri.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtMbiemri.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtMbiemri, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMbiemri.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtMbiemri, ((int)(resources.GetObject("txtMbiemri.IconPadding"))));
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.PasswordChar = '\0';
            this.txtMbiemri.Radius = 3;
            this.txtMbiemri.SelectedText = "";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.epKlienti.SetError(this.label1, resources.GetString("label1.Error"));
            this.epKlienti.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtNrPersonal
            // 
            resources.ApplyResources(this.txtNrPersonal, "txtNrPersonal");
            this.txtNrPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtNrPersonal.BaseColor = System.Drawing.Color.White;
            this.txtNrPersonal.BorderColor = System.Drawing.Color.Silver;
            this.txtNrPersonal.BorderSize = 1;
            this.txtNrPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtNrPersonal, resources.GetString("txtNrPersonal.Error"));
            this.txtNrPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNrPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtNrPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtNrPersonal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNrPersonal.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtNrPersonal, ((int)(resources.GetObject("txtNrPersonal.IconPadding"))));
            this.txtNrPersonal.Name = "txtNrPersonal";
            this.txtNrPersonal.PasswordChar = '\0';
            this.txtNrPersonal.Radius = 3;
            this.txtNrPersonal.SelectedText = "";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.epKlienti.SetError(this.label2, resources.GetString("label2.Error"));
            this.epKlienti.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtNrKontaktues
            // 
            resources.ApplyResources(this.txtNrKontaktues, "txtNrKontaktues");
            this.txtNrKontaktues.BackColor = System.Drawing.Color.Transparent;
            this.txtNrKontaktues.BaseColor = System.Drawing.Color.White;
            this.txtNrKontaktues.BorderColor = System.Drawing.Color.Silver;
            this.txtNrKontaktues.BorderSize = 1;
            this.txtNrKontaktues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtNrKontaktues, resources.GetString("txtNrKontaktues.Error"));
            this.txtNrKontaktues.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNrKontaktues.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtNrKontaktues.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtNrKontaktues, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNrKontaktues.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtNrKontaktues, ((int)(resources.GetObject("txtNrKontaktues.IconPadding"))));
            this.txtNrKontaktues.Name = "txtNrKontaktues";
            this.txtNrKontaktues.PasswordChar = '\0';
            this.txtNrKontaktues.Radius = 3;
            this.txtNrKontaktues.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.epKlienti.SetError(this.label4, resources.GetString("label4.Error"));
            this.epKlienti.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // dataKlientit
            // 
            resources.ApplyResources(this.dataKlientit, "dataKlientit");
            this.dataKlientit.BackColor = System.Drawing.Color.Transparent;
            this.dataKlientit.BaseColor = System.Drawing.Color.White;
            this.dataKlientit.BorderColor = System.Drawing.Color.Silver;
            this.dataKlientit.BorderSize = 1;
            this.epKlienti.SetError(this.dataKlientit, resources.GetString("dataKlientit.Error"));
            this.dataKlientit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataKlientit.ForeColor = System.Drawing.Color.Black;
            this.epKlienti.SetIconAlignment(this.dataKlientit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataKlientit.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.dataKlientit, ((int)(resources.GetObject("dataKlientit.IconPadding"))));
            this.dataKlientit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataKlientit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataKlientit.Name = "dataKlientit";
            this.dataKlientit.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataKlientit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataKlientit.OnHoverForeColor = System.Drawing.Color.Black;
            this.dataKlientit.OnPressedColor = System.Drawing.Color.Black;
            this.dataKlientit.Radius = 3;
            this.dataKlientit.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.epKlienti.SetError(this.label5, resources.GetString("label5.Error"));
            this.epKlienti.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.epKlienti.SetError(this.label6, resources.GetString("label6.Error"));
            this.epKlienti.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // txtAdresa
            // 
            resources.ApplyResources(this.txtAdresa, "txtAdresa");
            this.txtAdresa.BackColor = System.Drawing.Color.Transparent;
            this.txtAdresa.BaseColor = System.Drawing.Color.White;
            this.txtAdresa.BorderColor = System.Drawing.Color.Silver;
            this.txtAdresa.BorderSize = 1;
            this.txtAdresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtAdresa, resources.GetString("txtAdresa.Error"));
            this.txtAdresa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAdresa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtAdresa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtAdresa, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAdresa.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtAdresa, ((int)(resources.GetObject("txtAdresa.IconPadding"))));
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.Radius = 3;
            this.txtAdresa.SelectedText = "";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.epKlienti.SetError(this.label7, resources.GetString("label7.Error"));
            this.epKlienti.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // txtKodiPostal
            // 
            resources.ApplyResources(this.txtKodiPostal, "txtKodiPostal");
            this.txtKodiPostal.BackColor = System.Drawing.Color.Transparent;
            this.txtKodiPostal.BaseColor = System.Drawing.Color.White;
            this.txtKodiPostal.BorderColor = System.Drawing.Color.Silver;
            this.txtKodiPostal.BorderSize = 1;
            this.txtKodiPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtKodiPostal, resources.GetString("txtKodiPostal.Error"));
            this.txtKodiPostal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKodiPostal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKodiPostal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtKodiPostal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtKodiPostal.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtKodiPostal, ((int)(resources.GetObject("txtKodiPostal.IconPadding"))));
            this.txtKodiPostal.Name = "txtKodiPostal";
            this.txtKodiPostal.PasswordChar = '\0';
            this.txtKodiPostal.Radius = 3;
            this.txtKodiPostal.SelectedText = "";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.epKlienti.SetError(this.label8, resources.GetString("label8.Error"));
            this.epKlienti.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.epKlienti.SetError(this.label9, resources.GetString("label9.Error"));
            this.epKlienti.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // txtEmaili
            // 
            resources.ApplyResources(this.txtEmaili, "txtEmaili");
            this.txtEmaili.BackColor = System.Drawing.Color.Transparent;
            this.txtEmaili.BaseColor = System.Drawing.Color.White;
            this.txtEmaili.BorderColor = System.Drawing.Color.Silver;
            this.txtEmaili.BorderSize = 1;
            this.txtEmaili.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epKlienti.SetError(this.txtEmaili, resources.GetString("txtEmaili.Error"));
            this.txtEmaili.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmaili.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEmaili.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epKlienti.SetIconAlignment(this.txtEmaili, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmaili.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.txtEmaili, ((int)(resources.GetObject("txtEmaili.IconPadding"))));
            this.txtEmaili.Name = "txtEmaili";
            this.txtEmaili.PasswordChar = '\0';
            this.txtEmaili.Radius = 3;
            this.txtEmaili.SelectedText = "";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.epKlienti.SetError(this.label10, resources.GetString("label10.Error"));
            this.epKlienti.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // comboShteti
            // 
            resources.ApplyResources(this.comboShteti, "comboShteti");
            this.comboShteti.BackColor = System.Drawing.Color.Transparent;
            this.comboShteti.BaseColor = System.Drawing.Color.White;
            this.comboShteti.BorderColor = System.Drawing.Color.Silver;
            this.comboShteti.BorderSize = 1;
            this.comboShteti.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboShteti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.epKlienti.SetError(this.comboShteti, resources.GetString("comboShteti.Error"));
            this.comboShteti.FocusedColor = System.Drawing.Color.Empty;
            this.comboShteti.ForeColor = System.Drawing.Color.Black;
            this.comboShteti.FormattingEnabled = true;
            this.epKlienti.SetIconAlignment(this.comboShteti, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboShteti.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.comboShteti, ((int)(resources.GetObject("comboShteti.IconPadding"))));
            this.comboShteti.Items.AddRange(new object[] {
            resources.GetString("comboShteti.Items"),
            resources.GetString("comboShteti.Items1"),
            resources.GetString("comboShteti.Items2"),
            resources.GetString("comboShteti.Items3")});
            this.comboShteti.Name = "comboShteti";
            this.comboShteti.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboShteti.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboShteti.Radius = 3;
            this.comboShteti.SelectedIndexChanged += new System.EventHandler(this.comboShteti_SelectedIndexChanged);
            // 
            // comboQyteti
            // 
            resources.ApplyResources(this.comboQyteti, "comboQyteti");
            this.comboQyteti.BackColor = System.Drawing.Color.Transparent;
            this.comboQyteti.BaseColor = System.Drawing.Color.White;
            this.comboQyteti.BorderColor = System.Drawing.Color.Silver;
            this.comboQyteti.BorderSize = 1;
            this.comboQyteti.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboQyteti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.epKlienti.SetError(this.comboQyteti, resources.GetString("comboQyteti.Error"));
            this.comboQyteti.FocusedColor = System.Drawing.Color.Empty;
            this.comboQyteti.ForeColor = System.Drawing.Color.Black;
            this.comboQyteti.FormattingEnabled = true;
            this.epKlienti.SetIconAlignment(this.comboQyteti, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboQyteti.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.comboQyteti, ((int)(resources.GetObject("comboQyteti.IconPadding"))));
            this.comboQyteti.Name = "comboQyteti";
            this.comboQyteti.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboQyteti.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboQyteti.Radius = 3;
            // 
            // epKlienti
            // 
            this.epKlienti.ContainerControl = this;
            resources.ApplyResources(this.epKlienti, "epKlienti");
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.epKlienti.SetError(this.label11, resources.GetString("label11.Error"));
            this.epKlienti.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // radioMashkull
            // 
            resources.ApplyResources(this.radioMashkull, "radioMashkull");
            this.radioMashkull.BaseColor = System.Drawing.Color.White;
            this.radioMashkull.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioMashkull.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.epKlienti.SetError(this.radioMashkull, resources.GetString("radioMashkull.Error"));
            this.radioMashkull.FillColor = System.Drawing.Color.White;
            this.epKlienti.SetIconAlignment(this.radioMashkull, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radioMashkull.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.radioMashkull, ((int)(resources.GetObject("radioMashkull.IconPadding"))));
            this.radioMashkull.Name = "radioMashkull";
            // 
            // radioFemer
            // 
            resources.ApplyResources(this.radioFemer, "radioFemer");
            this.radioFemer.BaseColor = System.Drawing.Color.White;
            this.radioFemer.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioFemer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.epKlienti.SetError(this.radioFemer, resources.GetString("radioFemer.Error"));
            this.radioFemer.FillColor = System.Drawing.Color.White;
            this.epKlienti.SetIconAlignment(this.radioFemer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radioFemer.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.radioFemer, ((int)(resources.GetObject("radioFemer.IconPadding"))));
            this.radioFemer.Name = "radioFemer";
            // 
            // gunaGroupBox1
            // 
            resources.ApplyResources(this.gunaGroupBox1, "gunaGroupBox1");
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.panel2);
            this.gunaGroupBox1.Controls.Add(this.btnAnulo);
            this.gunaGroupBox1.Controls.Add(this.txtNrKontaktues);
            this.gunaGroupBox1.Controls.Add(this.btnShto);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtEmaili);
            this.gunaGroupBox1.Controls.Add(this.label10);
            this.gunaGroupBox1.Controls.Add(this.txtNrPersonal);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtAdresa);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.radioFemer);
            this.gunaGroupBox1.Controls.Add(this.txtEmri);
            this.gunaGroupBox1.Controls.Add(this.radioMashkull);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label11);
            this.gunaGroupBox1.Controls.Add(this.comboQyteti);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.comboShteti);
            this.gunaGroupBox1.Controls.Add(this.txtKodiPostal);
            this.gunaGroupBox1.Controls.Add(this.label8);
            this.gunaGroupBox1.Controls.Add(this.txtMbiemri);
            this.gunaGroupBox1.Controls.Add(this.dataKlientit);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label9);
            this.epKlienti.SetError(this.gunaGroupBox1, resources.GetString("gunaGroupBox1.Error"));
            this.epKlienti.SetIconAlignment(this.gunaGroupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gunaGroupBox1.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.gunaGroupBox1, ((int)(resources.GetObject("gunaGroupBox1.IconPadding"))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.epKlienti.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.epKlienti.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.epKlienti.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.panel2.Name = "panel2";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.gunaGroupBox1;
            // 
            // frm_ShtoKlient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ShtoKlient";
            this.Load += new System.EventHandler(this.frm_ShtoKlient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epKlienti)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtEmri;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnulo;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private Guna.UI.WinForms.GunaTextBox txtMbiemri;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtNrPersonal;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtNrKontaktues;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker dataKlientit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtAdresa;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtKodiPostal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtEmaili;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox comboShteti;
        private Guna.UI.WinForms.GunaComboBox comboQyteti;
        private System.Windows.Forms.ErrorProvider epKlienti;
        private Guna.UI.WinForms.GunaRadioButton radioFemer;
        private Guna.UI.WinForms.GunaRadioButton radioMashkull;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}