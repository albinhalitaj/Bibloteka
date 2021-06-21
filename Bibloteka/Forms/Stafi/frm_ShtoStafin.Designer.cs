
namespace Bibloteka.Forms
{
    partial class frm_ShtoStafi
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
            this.dgv_InformatatStafit = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.radioFemer = new Guna.UI.WinForms.GunaRadioButton();
            this.radioMashkull = new Guna.UI.WinForms.GunaRadioButton();
            this.comboRoli = new System.Windows.Forms.ComboBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmaili = new Guna.UI.WinForms.GunaTextBox();
            this.txtKodiPostal = new Guna.UI.WinForms.GunaTextBox();
            this.comboKualifikimet = new System.Windows.Forms.ComboBox();
            this.txtNrKontaktues = new Guna.UI.WinForms.GunaTextBox();
            this.dataStafit = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtEmri = new Guna.UI.WinForms.GunaTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMbiemri = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresa = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnulo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNrPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.epStafi = new System.Windows.Forms.ErrorProvider(this.components);
            this.dragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.txtShteti = new Guna.UI.WinForms.GunaTextBox();
            this.txtQyteti = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_InformatatStafit.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epStafi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_InformatatStafit
            // 
            this.dgv_InformatatStafit.BackColor = System.Drawing.Color.Transparent;
            this.dgv_InformatatStafit.BaseColor = System.Drawing.Color.White;
            this.dgv_InformatatStafit.BorderColor = System.Drawing.Color.Gainsboro;
            this.dgv_InformatatStafit.Controls.Add(this.gunaGroupBox1);
            this.dgv_InformatatStafit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_InformatatStafit.LineColor = System.Drawing.Color.Gainsboro;
            this.dgv_InformatatStafit.Location = new System.Drawing.Point(0, 0);
            this.dgv_InformatatStafit.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_InformatatStafit.Name = "dgv_InformatatStafit";
            this.dgv_InformatatStafit.Size = new System.Drawing.Size(730, 725);
            this.dgv_InformatatStafit.TabIndex = 0;
            this.dgv_InformatatStafit.Text = "Informatat e Stafit";
            this.dgv_InformatatStafit.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.radioFemer);
            this.gunaGroupBox1.Controls.Add(this.radioMashkull);
            this.gunaGroupBox1.Controls.Add(this.comboRoli);
            this.gunaGroupBox1.Controls.Add(this.txtPassword);
            this.gunaGroupBox1.Controls.Add(this.txtUsername);
            this.gunaGroupBox1.Controls.Add(this.txtEmaili);
            this.gunaGroupBox1.Controls.Add(this.txtKodiPostal);
            this.gunaGroupBox1.Controls.Add(this.comboKualifikimet);
            this.gunaGroupBox1.Controls.Add(this.txtNrKontaktues);
            this.gunaGroupBox1.Controls.Add(this.dataStafit);
            this.gunaGroupBox1.Controls.Add(this.txtEmri);
            this.gunaGroupBox1.Controls.Add(this.label15);
            this.gunaGroupBox1.Controls.Add(this.label14);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.label12);
            this.gunaGroupBox1.Controls.Add(this.txtMbiemri);
            this.gunaGroupBox1.Controls.Add(this.label10);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtQyteti);
            this.gunaGroupBox1.Controls.Add(this.txtShteti);
            this.gunaGroupBox1.Controls.Add(this.txtAdresa);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.panel2);
            this.gunaGroupBox1.Controls.Add(this.btnAnulo);
            this.gunaGroupBox1.Controls.Add(this.btnShto);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label11);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtNrPersonal);
            this.gunaGroupBox1.Controls.Add(this.label8);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label9);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(730, 725);
            this.gunaGroupBox1.TabIndex = 51;
            this.gunaGroupBox1.Text = "Informatat e Librit";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // radioFemer
            // 
            this.radioFemer.BaseColor = System.Drawing.SystemColors.Control;
            this.radioFemer.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioFemer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radioFemer.FillColor = System.Drawing.Color.White;
            this.radioFemer.Location = new System.Drawing.Point(481, 171);
            this.radioFemer.Name = "radioFemer";
            this.radioFemer.Size = new System.Drawing.Size(62, 20);
            this.radioFemer.TabIndex = 81;
            this.radioFemer.Text = "Femer";
            // 
            // radioMashkull
            // 
            this.radioMashkull.BaseColor = System.Drawing.SystemColors.Control;
            this.radioMashkull.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioMashkull.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radioMashkull.FillColor = System.Drawing.Color.White;
            this.radioMashkull.Location = new System.Drawing.Point(378, 171);
            this.radioMashkull.Name = "radioMashkull";
            this.radioMashkull.Size = new System.Drawing.Size(75, 20);
            this.radioMashkull.TabIndex = 80;
            this.radioMashkull.Text = "Mashkull";
            // 
            // comboRoli
            // 
            this.comboRoli.FormattingEnabled = true;
            this.comboRoli.Location = new System.Drawing.Point(45, 641);
            this.comboRoli.Margin = new System.Windows.Forms.Padding(2);
            this.comboRoli.Name = "comboRoli";
            this.comboRoli.Size = new System.Drawing.Size(253, 28);
            this.comboRoli.TabIndex = 79;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(385, 558);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 3;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(250, 25);
            this.txtPassword.TabIndex = 78;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(46, 558);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 3;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(250, 25);
            this.txtUsername.TabIndex = 77;
            //this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged_1);
            // 
            // txtEmaili
            // 
            this.txtEmaili.BackColor = System.Drawing.Color.Transparent;
            this.txtEmaili.BaseColor = System.Drawing.Color.White;
            this.txtEmaili.BorderColor = System.Drawing.Color.Silver;
            this.txtEmaili.BorderSize = 1;
            this.txtEmaili.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmaili.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmaili.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEmaili.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmaili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmaili.Location = new System.Drawing.Point(385, 479);
            this.txtEmaili.Name = "txtEmaili";
            this.txtEmaili.PasswordChar = '\0';
            this.txtEmaili.Radius = 3;
            this.txtEmaili.SelectedText = "";
            this.txtEmaili.Size = new System.Drawing.Size(250, 25);
            this.txtEmaili.TabIndex = 76;
            // 
            // txtKodiPostal
            // 
            this.txtKodiPostal.BackColor = System.Drawing.Color.Transparent;
            this.txtKodiPostal.BaseColor = System.Drawing.Color.White;
            this.txtKodiPostal.BorderColor = System.Drawing.Color.Silver;
            this.txtKodiPostal.BorderSize = 1;
            this.txtKodiPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKodiPostal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKodiPostal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKodiPostal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKodiPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodiPostal.Location = new System.Drawing.Point(46, 479);
            this.txtKodiPostal.Name = "txtKodiPostal";
            this.txtKodiPostal.PasswordChar = '\0';
            this.txtKodiPostal.Radius = 3;
            this.txtKodiPostal.SelectedText = "";
            this.txtKodiPostal.Size = new System.Drawing.Size(250, 25);
            this.txtKodiPostal.TabIndex = 75;
            // 
            // comboKualifikimet
            // 
            this.comboKualifikimet.FormattingEnabled = true;
            this.comboKualifikimet.Location = new System.Drawing.Point(45, 311);
            this.comboKualifikimet.Margin = new System.Windows.Forms.Padding(2);
            this.comboKualifikimet.Name = "comboKualifikimet";
            this.comboKualifikimet.Size = new System.Drawing.Size(253, 28);
            this.comboKualifikimet.TabIndex = 72;
            // 
            // txtNrKontaktues
            // 
            this.txtNrKontaktues.BackColor = System.Drawing.Color.Transparent;
            this.txtNrKontaktues.BaseColor = System.Drawing.Color.White;
            this.txtNrKontaktues.BorderColor = System.Drawing.Color.Silver;
            this.txtNrKontaktues.BorderSize = 1;
            this.txtNrKontaktues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNrKontaktues.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNrKontaktues.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtNrKontaktues.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNrKontaktues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrKontaktues.Location = new System.Drawing.Point(385, 242);
            this.txtNrKontaktues.Name = "txtNrKontaktues";
            this.txtNrKontaktues.PasswordChar = '\0';
            this.txtNrKontaktues.Radius = 3;
            this.txtNrKontaktues.SelectedText = "";
            this.txtNrKontaktues.Size = new System.Drawing.Size(250, 25);
            this.txtNrKontaktues.TabIndex = 71;
            // 
            // dataStafit
            // 
            this.dataStafit.BaseColor = System.Drawing.Color.White;
            this.dataStafit.BorderColor = System.Drawing.Color.Silver;
            this.dataStafit.CustomFormat = null;
            this.dataStafit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataStafit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataStafit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataStafit.ForeColor = System.Drawing.Color.Black;
            this.dataStafit.Location = new System.Drawing.Point(45, 171);
            this.dataStafit.Margin = new System.Windows.Forms.Padding(2);
            this.dataStafit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataStafit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataStafit.Name = "dataStafit";
            this.dataStafit.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataStafit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataStafit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataStafit.OnPressedColor = System.Drawing.Color.Black;
            this.dataStafit.Size = new System.Drawing.Size(251, 34);
            this.dataStafit.TabIndex = 64;
            this.dataStafit.Text = "11/06/2021";
            this.dataStafit.Value = new System.DateTime(2021, 6, 11, 16, 20, 47, 117);
            // 
            // txtEmri
            // 
            this.txtEmri.BaseColor = System.Drawing.Color.White;
            this.txtEmri.BorderColor = System.Drawing.Color.Silver;
            this.txtEmri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmri.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmri.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmri.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmri.Location = new System.Drawing.Point(45, 97);
            this.txtEmri.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.PasswordChar = '\0';
            this.txtEmri.SelectedText = "";
            this.txtEmri.Size = new System.Drawing.Size(251, 26);
            this.txtEmri.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(43, 604);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 17);
            this.label15.TabIndex = 62;
            this.label15.Text = "Roli";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(380, 520);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 61;
            this.label14.Text = "Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(43, 520);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 60;
            this.label13.Text = "Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(382, 443);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Email";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.BackColor = System.Drawing.Color.Transparent;
            this.txtMbiemri.BaseColor = System.Drawing.Color.White;
            this.txtMbiemri.BorderColor = System.Drawing.Color.Silver;
            this.txtMbiemri.BorderSize = 1;
            this.txtMbiemri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMbiemri.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMbiemri.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtMbiemri.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemri.Location = new System.Drawing.Point(385, 97);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.PasswordChar = '\0';
            this.txtMbiemri.Radius = 3;
            this.txtMbiemri.SelectedText = "";
            this.txtMbiemri.Size = new System.Drawing.Size(250, 25);
            this.txtMbiemri.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(43, 443);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Kodi Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(43, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Qyteti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(382, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.BackColor = System.Drawing.Color.Transparent;
            this.txtAdresa.BaseColor = System.Drawing.Color.White;
            this.txtAdresa.BorderColor = System.Drawing.Color.Silver;
            this.txtAdresa.BorderSize = 1;
            this.txtAdresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAdresa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtAdresa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.Location = new System.Drawing.Point(384, 311);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.Radius = 3;
            this.txtAdresa.SelectedText = "";
            this.txtAdresa.Size = new System.Drawing.Size(250, 25);
            this.txtAdresa.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(382, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Shteti";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(215, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 3);
            this.panel2.TabIndex = 49;
            // 
            // btnAnulo
            // 
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
            this.btnAnulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAnulo.ForeColor = System.Drawing.Color.White;
            this.btnAnulo.Image = null;
            this.btnAnulo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnulo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnulo.Location = new System.Drawing.Point(468, 641);
            this.btnAnulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAnulo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnulo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnulo.OnHoverImage = null;
            this.btnAnulo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnulo.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnulo.Radius = 3;
            this.btnAnulo.Size = new System.Drawing.Size(78, 34);
            this.btnAnulo.TabIndex = 12;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnulo.Click += new System.EventHandler(this.btnAnulo_Click);
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
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.Image = null;
            this.btnShto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.Location = new System.Drawing.Point(557, 641);
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
            this.btnShto.TabIndex = 11;
            this.btnShto.Text = "Ruaj";
            this.btnShto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Emri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(43, 286);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Kualifikimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(41, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Datelindja";
            // 
            // txtNrPersonal
            // 
            this.txtNrPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtNrPersonal.BaseColor = System.Drawing.Color.White;
            this.txtNrPersonal.BorderColor = System.Drawing.Color.Silver;
            this.txtNrPersonal.BorderSize = 1;
            this.txtNrPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNrPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNrPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtNrPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNrPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrPersonal.Location = new System.Drawing.Point(46, 242);
            this.txtNrPersonal.Name = "txtNrPersonal";
            this.txtNrPersonal.PasswordChar = '\0';
            this.txtNrPersonal.Radius = 3;
            this.txtNrPersonal.SelectedText = "";
            this.txtNrPersonal.Size = new System.Drawing.Size(250, 25);
            this.txtNrPersonal.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(380, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "NrKontaktues";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(41, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "NrPersonal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(380, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mbiemri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(380, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Gjinia";
            // 
            // epStafi
            // 
            this.epStafi.ContainerControl = this;
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this.gunaGroupBox1;
            // 
            // txtShteti
            // 
            this.txtShteti.BackColor = System.Drawing.Color.Transparent;
            this.txtShteti.BaseColor = System.Drawing.Color.White;
            this.txtShteti.BorderColor = System.Drawing.Color.Silver;
            this.txtShteti.BorderSize = 1;
            this.txtShteti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShteti.FocusedBaseColor = System.Drawing.Color.White;
            this.txtShteti.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtShteti.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtShteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShteti.Location = new System.Drawing.Point(385, 386);
            this.txtShteti.Name = "txtShteti";
            this.txtShteti.PasswordChar = '\0';
            this.txtShteti.Radius = 3;
            this.txtShteti.SelectedText = "";
            this.txtShteti.Size = new System.Drawing.Size(250, 25);
            this.txtShteti.TabIndex = 8;
            // 
            // txtQyteti
            // 
            this.txtQyteti.BackColor = System.Drawing.Color.Transparent;
            this.txtQyteti.BaseColor = System.Drawing.Color.White;
            this.txtQyteti.BorderColor = System.Drawing.Color.Silver;
            this.txtQyteti.BorderSize = 1;
            this.txtQyteti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQyteti.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQyteti.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtQyteti.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQyteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQyteti.Location = new System.Drawing.Point(48, 386);
            this.txtQyteti.Name = "txtQyteti";
            this.txtQyteti.PasswordChar = '\0';
            this.txtQyteti.Radius = 3;
            this.txtQyteti.SelectedText = "";
            this.txtQyteti.Size = new System.Drawing.Size(250, 25);
            this.txtQyteti.TabIndex = 8;
            // 
            // frm_ShtoStafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 725);
            this.Controls.Add(this.dgv_InformatatStafit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_ShtoStafi";
            this.Text = "Shto Stafin";
            this.Load += new System.EventHandler(this.frm_ShtoStafin_Load);
            this.dgv_InformatatStafit.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epStafi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox dgv_InformatatStafit;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtMbiemri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtAdresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnulo;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtNrPersonal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider epStafi;
        private Guna.UI.WinForms.GunaDragControl dragForm;
        private Guna.UI.WinForms.GunaTextBox txtEmri;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaDateTimePicker dataStafit;
        private Guna.UI.WinForms.GunaTextBox txtNrKontaktues;
        private System.Windows.Forms.ComboBox comboKualifikimet;
        private System.Windows.Forms.ComboBox comboRoli;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtEmaili;
        private Guna.UI.WinForms.GunaTextBox txtKodiPostal;
        private Guna.UI.WinForms.GunaRadioButton radioFemer;
        private Guna.UI.WinForms.GunaRadioButton radioMashkull;
        private Guna.UI.WinForms.GunaTextBox txtQyteti;
        private Guna.UI.WinForms.GunaTextBox txtShteti;
    }
}