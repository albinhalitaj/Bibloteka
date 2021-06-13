
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
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHuazimet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
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
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(717, 496);
            this.gunaGroupBox1.TabIndex = 50;
            this.gunaGroupBox1.Text = "Informatat e Huazimit";
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
            this.comboLibri.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLibri.ForeColor = System.Drawing.Color.Black;
            this.comboLibri.FormattingEnabled = true;
            this.comboLibri.ItemHeight = 28;
            this.comboLibri.Items.AddRange(new object[] {
            "Selekto Librin"});
            this.comboLibri.Location = new System.Drawing.Point(396, 113);
            this.comboLibri.Name = "comboLibri";
            this.comboLibri.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboLibri.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboLibri.Radius = 3;
            this.comboLibri.Size = new System.Drawing.Size(250, 34);
            this.comboLibri.TabIndex = 61;
            this.comboLibri.SelectedIndexChanged += new System.EventHandler(this.comboLibri_SelectedIndexChanged);
            // 
            // txtSasia
            // 
            this.txtSasia.BackColor = System.Drawing.Color.Transparent;
            this.txtSasia.BaseColor = System.Drawing.Color.White;
            this.txtSasia.BorderColor = System.Drawing.Color.Silver;
            this.txtSasia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtSasia.ButtonForeColor = System.Drawing.Color.White;
            this.txtSasia.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSasia.ForeColor = System.Drawing.Color.Black;
            this.txtSasia.Location = new System.Drawing.Point(57, 316);
            this.txtSasia.Maximum = ((long)(9999999));
            this.txtSasia.Minimum = ((long)(0));
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Radius = 3;
            this.txtSasia.Size = new System.Drawing.Size(250, 30);
            this.txtSasia.TabIndex = 59;
            this.txtSasia.Value = ((long)(0));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(52, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "NumriKopjeve";
            // 
            // dataKthimit
            // 
            this.dataKthimit.BackColor = System.Drawing.Color.Transparent;
            this.dataKthimit.BaseColor = System.Drawing.Color.White;
            this.dataKthimit.BorderColor = System.Drawing.Color.Silver;
            this.dataKthimit.BorderSize = 1;
            this.dataKthimit.CustomFormat = null;
            this.dataKthimit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataKthimit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataKthimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataKthimit.ForeColor = System.Drawing.Color.Black;
            this.dataKthimit.Location = new System.Drawing.Point(396, 212);
            this.dataKthimit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataKthimit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataKthimit.Name = "dataKthimit";
            this.dataKthimit.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataKthimit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataKthimit.OnHoverForeColor = System.Drawing.Color.Black;
            this.dataKthimit.OnPressedColor = System.Drawing.Color.Black;
            this.dataKthimit.Radius = 3;
            this.dataKthimit.Size = new System.Drawing.Size(250, 37);
            this.dataKthimit.TabIndex = 50;
            this.dataKthimit.Text = "Thursday, May 20, 2021";
            this.dataKthimit.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(391, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Data Kthimit";
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
            this.btnAnulo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAnulo.ForeColor = System.Drawing.Color.White;
            this.btnAnulo.Image = null;
            this.btnAnulo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnulo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnulo.Location = new System.Drawing.Point(474, 396);
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
            this.btnAnulo.TabIndex = 11;
            this.btnAnulo.Text = "Anulo";
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
            this.btnHuazo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHuazo.ForeColor = System.Drawing.Color.White;
            this.btnHuazo.Image = null;
            this.btnHuazo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuazo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHuazo.Location = new System.Drawing.Point(568, 396);
            this.btnHuazo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuazo.Name = "btnHuazo";
            this.btnHuazo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnHuazo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuazo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuazo.OnHoverImage = null;
            this.btnHuazo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHuazo.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuazo.Radius = 3;
            this.btnHuazo.Size = new System.Drawing.Size(78, 34);
            this.btnHuazo.TabIndex = 10;
            this.btnHuazo.Text = "Huazo";
            this.btnHuazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuazo.Click += new System.EventHandler(this.btnHuazo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(52, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Klienti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(391, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Libri";
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
            this.comboKlienti.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKlienti.ForeColor = System.Drawing.Color.Black;
            this.comboKlienti.FormattingEnabled = true;
            this.comboKlienti.ItemHeight = 28;
            this.comboKlienti.Items.AddRange(new object[] {
            "Selekto Klientin"});
            this.comboKlienti.Location = new System.Drawing.Point(57, 114);
            this.comboKlienti.Name = "comboKlienti";
            this.comboKlienti.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.comboKlienti.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboKlienti.Radius = 3;
            this.comboKlienti.Size = new System.Drawing.Size(250, 34);
            this.comboKlienti.TabIndex = 6;
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
            this.txtPershkrimi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPershkrimi.Location = new System.Drawing.Point(396, 312);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.PasswordChar = '\0';
            this.txtPershkrimi.Radius = 3;
            this.txtPershkrimi.SelectedText = "";
            this.txtPershkrimi.Size = new System.Drawing.Size(250, 34);
            this.txtPershkrimi.TabIndex = 8;
            // 
            // dataHuazimit
            // 
            this.dataHuazimit.BackColor = System.Drawing.Color.Transparent;
            this.dataHuazimit.BaseColor = System.Drawing.Color.White;
            this.dataHuazimit.BorderColor = System.Drawing.Color.Silver;
            this.dataHuazimit.BorderSize = 1;
            this.dataHuazimit.CustomFormat = null;
            this.dataHuazimit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataHuazimit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataHuazimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataHuazimit.ForeColor = System.Drawing.Color.Black;
            this.dataHuazimit.Location = new System.Drawing.Point(57, 212);
            this.dataHuazimit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataHuazimit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataHuazimit.Name = "dataHuazimit";
            this.dataHuazimit.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataHuazimit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.dataHuazimit.OnHoverForeColor = System.Drawing.Color.Black;
            this.dataHuazimit.OnPressedColor = System.Drawing.Color.Black;
            this.dataHuazimit.Radius = 3;
            this.dataHuazimit.Size = new System.Drawing.Size(250, 37);
            this.dataHuazimit.TabIndex = 2;
            this.dataHuazimit.Text = "Thursday, May 20, 2021";
            this.dataHuazimit.Value = new System.DateTime(2021, 5, 20, 14, 58, 37, 411);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(52, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data Huazimit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(391, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Përshkrimi";
            // 
            // epHuazimet
            // 
            this.epHuazimet.ContainerControl = this;
            // 
            // frm_HuazoLiber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 496);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HuazoLiber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huazo Libër";
            this.Load += new System.EventHandler(this.frm_HuazoLiber_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHuazimet)).EndInit();
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
    }
}