
namespace Bibloteka.Forms.Huazimet
{
    partial class frm_HuazoLiber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HuazoLiber));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.comboLibri = new Guna.UI.WinForms.GunaComboBox();
            this.txtSasia = new Guna.UI.WinForms.GunaNumeric();
            this.label4 = new System.Windows.Forms.Label();
            this.dataKthimit = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnulo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHuazo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboKlienti = new Guna.UI.WinForms.GunaComboBox();
            this.txtPershkrimi = new Guna.UI.WinForms.GunaTextBox();
            this.dataHuazimit = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.epHuazimet = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHuazimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.btnHelp);
            this.gunaGroupBox1.Controls.Add(this.comboLibri);
            this.gunaGroupBox1.Controls.Add(this.txtSasia);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.dataKthimit);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.panel2);
            this.gunaGroupBox1.Controls.Add(this.btnAnulo);
            this.gunaGroupBox1.Controls.Add(this.btnHuazo);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.comboKlienti);
            this.gunaGroupBox1.Controls.Add(this.txtPershkrimi);
            this.gunaGroupBox1.Controls.Add(this.dataHuazimit);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label9);
            resources.ApplyResources(this.gunaGroupBox1, "gunaGroupBox1");
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // comboLibri
            // 
            this.comboLibri.BackColor = System.Drawing.Color.Transparent;
            this.comboLibri.BaseColor = System.Drawing.Color.White;
            this.comboLibri.BorderColor = System.Drawing.Color.Silver;
            this.comboLibri.BorderSize = 1;
            this.comboLibri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLibri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLibri.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.comboLibri, "comboLibri");
            this.comboLibri.ForeColor = System.Drawing.Color.Black;
            this.comboLibri.FormattingEnabled = true;
            this.comboLibri.Items.AddRange(new object[] {
            resources.GetString("comboLibri.Items")});
            this.comboLibri.Name = "comboLibri";
            this.comboLibri.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboLibri.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboLibri.Radius = 3;
            this.comboLibri.SelectedIndexChanged += new System.EventHandler(this.comboLibri_SelectedIndexChanged);
            // 
            // txtSasia
            // 
            this.txtSasia.BackColor = System.Drawing.Color.Transparent;
            this.txtSasia.BaseColor = System.Drawing.Color.White;
            this.txtSasia.BorderColor = System.Drawing.Color.Silver;
            this.txtSasia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtSasia.ButtonForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtSasia, "txtSasia");
            this.txtSasia.ForeColor = System.Drawing.Color.Black;
            this.txtSasia.Maximum = ((long)(9999999));
            this.txtSasia.Minimum = ((long)(0));
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Radius = 3;
            this.txtSasia.Value = ((long)(0));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dataKthimit
            // 
            this.dataKthimit.BackColor = System.Drawing.Color.Transparent;
            this.dataKthimit.BaseColor = System.Drawing.Color.White;
            this.dataKthimit.BorderColor = System.Drawing.Color.Silver;
            this.dataKthimit.BorderSize = 1;
            resources.ApplyResources(this.dataKthimit, "dataKthimit");
            this.dataKthimit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataKthimit.ForeColor = System.Drawing.Color.Black;
            this.dataKthimit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataKthimit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataKthimit.Name = "dataKthimit";
            this.dataKthimit.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataKthimit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataKthimit.OnHoverForeColor = System.Drawing.Color.Black;
            this.dataKthimit.OnPressedColor = System.Drawing.Color.Black;
            this.dataKthimit.Radius = 3;
            this.dataKthimit.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
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
            resources.ApplyResources(this.btnAnulo, "btnAnulo");
            this.btnAnulo.ForeColor = System.Drawing.Color.White;
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // comboKlienti
            // 
            this.comboKlienti.BackColor = System.Drawing.Color.Transparent;
            this.comboKlienti.BaseColor = System.Drawing.Color.White;
            this.comboKlienti.BorderColor = System.Drawing.Color.Silver;
            this.comboKlienti.BorderSize = 1;
            this.comboKlienti.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboKlienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKlienti.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.comboKlienti, "comboKlienti");
            this.comboKlienti.ForeColor = System.Drawing.Color.Black;
            this.comboKlienti.FormattingEnabled = true;
            this.comboKlienti.Items.AddRange(new object[] {
            resources.GetString("comboKlienti.Items")});
            this.comboKlienti.Name = "comboKlienti";
            this.comboKlienti.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboKlienti.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboKlienti.Radius = 3;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.BackColor = System.Drawing.Color.Transparent;
            this.txtPershkrimi.BaseColor = System.Drawing.Color.White;
            this.txtPershkrimi.BorderColor = System.Drawing.Color.Silver;
            this.txtPershkrimi.BorderSize = 1;
            this.txtPershkrimi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPershkrimi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPershkrimi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtPershkrimi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.txtPershkrimi, "txtPershkrimi");
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.PasswordChar = '\0';
            this.txtPershkrimi.Radius = 3;
            this.txtPershkrimi.SelectedText = "";
            // 
            // dataHuazimit
            // 
            this.dataHuazimit.BackColor = System.Drawing.Color.Transparent;
            this.dataHuazimit.BaseColor = System.Drawing.Color.White;
            this.dataHuazimit.BorderColor = System.Drawing.Color.Silver;
            this.dataHuazimit.BorderSize = 1;
            resources.ApplyResources(this.dataHuazimit, "dataHuazimit");
            this.dataHuazimit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataHuazimit.ForeColor = System.Drawing.Color.Black;
            this.dataHuazimit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataHuazimit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataHuazimit.Name = "dataHuazimit";
            this.dataHuazimit.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataHuazimit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataHuazimit.OnHoverForeColor = System.Drawing.Color.Black;
            this.dataHuazimit.OnPressedColor = System.Drawing.Color.Black;
            this.dataHuazimit.Radius = 3;
            this.dataHuazimit.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // epHuazimet
            // 
            this.epHuazimet.ContainerControl = this;
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frm_HuazoLiber
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HuazoLiber";
            this.Load += new System.EventHandler(this.frm_HuazoLiber_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHuazimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnulo;
        private Guna.UI.WinForms.GunaAdvenceButton btnHuazo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox comboKlienti;
        private Guna.UI.WinForms.GunaTextBox txtPershkrimi;
        private Guna.UI.WinForms.GunaDateTimePicker dataHuazimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaDateTimePicker dataKthimit;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox comboLibri;
        private Guna.UI.WinForms.GunaNumeric txtSasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epHuazimet;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}