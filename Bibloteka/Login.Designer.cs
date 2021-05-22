
namespace Bibloteka
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSqXK = new System.Windows.Forms.PictureBox();
            this.btnEnUS = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerdoruesi = new Guna.UI.WinForms.GunaTextBox();
            this.txtFjalekalimi = new Guna.UI.WinForms.GunaTextBox();
            this.btnKyqu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.chkMeMbajMend = new Guna.UI.WinForms.GunaCheckBox();
            this.epLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSqXK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSqXK);
            this.panel1.Controls.Add(this.btnEnUS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 492);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSqXK
            // 
            this.btnSqXK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSqXK.Image = ((System.Drawing.Image)(resources.GetObject("btnSqXK.Image")));
            this.btnSqXK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSqXK.Location = new System.Drawing.Point(47, 459);
            this.btnSqXK.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqXK.Name = "btnSqXK";
            this.btnSqXK.Size = new System.Drawing.Size(34, 22);
            this.btnSqXK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSqXK.TabIndex = 8;
            this.btnSqXK.TabStop = false;
            // 
            // btnEnUS
            // 
            this.btnEnUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnUS.Image = ((System.Drawing.Image)(resources.GetObject("btnEnUS.Image")));
            this.btnEnUS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnUS.Location = new System.Drawing.Point(9, 459);
            this.btnEnUS.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnUS.Name = "btnEnUS";
            this.btnEnUS.Size = new System.Drawing.Size(34, 22);
            this.btnEnUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEnUS.TabIndex = 7;
            this.btnEnUS.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(360, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fjalëkalimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(360, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Përdoruesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(436, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hyrja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(373, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hyrja në panelin e kontrollit";
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.BackColor = System.Drawing.Color.Transparent;
            this.txtPerdoruesi.BaseColor = System.Drawing.Color.White;
            this.txtPerdoruesi.BorderColor = System.Drawing.Color.Gray;
            this.txtPerdoruesi.BorderSize = 1;
            this.txtPerdoruesi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPerdoruesi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPerdoruesi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtPerdoruesi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPerdoruesi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerdoruesi.Location = new System.Drawing.Point(365, 192);
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.PasswordChar = '\0';
            this.txtPerdoruesi.Radius = 3;
            this.txtPerdoruesi.SelectedText = "";
            this.txtPerdoruesi.Size = new System.Drawing.Size(250, 34);
            this.txtPerdoruesi.TabIndex = 11;
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.BackColor = System.Drawing.Color.Transparent;
            this.txtFjalekalimi.BaseColor = System.Drawing.Color.White;
            this.txtFjalekalimi.BorderColor = System.Drawing.Color.Gray;
            this.txtFjalekalimi.BorderSize = 1;
            this.txtFjalekalimi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFjalekalimi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFjalekalimi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtFjalekalimi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFjalekalimi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimi.Location = new System.Drawing.Point(365, 271);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.PasswordChar = '*';
            this.txtFjalekalimi.Radius = 3;
            this.txtFjalekalimi.SelectedText = "";
            this.txtFjalekalimi.Size = new System.Drawing.Size(250, 34);
            this.txtFjalekalimi.TabIndex = 12;
            // 
            // btnKyqu
            // 
            this.btnKyqu.AnimationHoverSpeed = 0.07F;
            this.btnKyqu.AnimationSpeed = 0.03F;
            this.btnKyqu.BackColor = System.Drawing.Color.Transparent;
            this.btnKyqu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnKyqu.BorderColor = System.Drawing.Color.Black;
            this.btnKyqu.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnKyqu.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnKyqu.CheckedForeColor = System.Drawing.Color.White;
            this.btnKyqu.CheckedImage = null;
            this.btnKyqu.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnKyqu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKyqu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKyqu.FocusedColor = System.Drawing.Color.Empty;
            this.btnKyqu.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKyqu.ForeColor = System.Drawing.Color.White;
            this.btnKyqu.Image = null;
            this.btnKyqu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKyqu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKyqu.Location = new System.Drawing.Point(365, 356);
            this.btnKyqu.Margin = new System.Windows.Forms.Padding(2);
            this.btnKyqu.Name = "btnKyqu";
            this.btnKyqu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnKyqu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKyqu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKyqu.OnHoverImage = null;
            this.btnKyqu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKyqu.OnPressedColor = System.Drawing.Color.Black;
            this.btnKyqu.Radius = 3;
            this.btnKyqu.Size = new System.Drawing.Size(250, 41);
            this.btnKyqu.TabIndex = 13;
            this.btnKyqu.Text = "Kyçu";
            this.btnKyqu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKyqu.Click += new System.EventHandler(this.btnKyqu_Click);
            // 
            // chkMeMbajMend
            // 
            this.chkMeMbajMend.BaseColor = System.Drawing.Color.White;
            this.chkMeMbajMend.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkMeMbajMend.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.chkMeMbajMend.FillColor = System.Drawing.Color.White;
            this.chkMeMbajMend.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeMbajMend.Location = new System.Drawing.Point(365, 321);
            this.chkMeMbajMend.Name = "chkMeMbajMend";
            this.chkMeMbajMend.Size = new System.Drawing.Size(135, 22);
            this.chkMeMbajMend.TabIndex = 15;
            this.chkMeMbajMend.Text = "Më mbaj mend.";
            // 
            // epLogin
            // 
            this.epLogin.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 492);
            this.Controls.Add(this.chkMeMbajMend);
            this.Controls.Add(this.btnKyqu);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.txtPerdoruesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(685, 531);
            this.MinimumSize = new System.Drawing.Size(685, 531);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyçu - Biblioteka";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSqXK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPerdoruesi;
        private Guna.UI.WinForms.GunaTextBox txtFjalekalimi;
        private Guna.UI.WinForms.GunaAdvenceButton btnKyqu;
        private System.Windows.Forms.PictureBox btnSqXK;
        private System.Windows.Forms.PictureBox btnEnUS;
        private Guna.UI.WinForms.GunaCheckBox chkMeMbajMend;
        private System.Windows.Forms.ErrorProvider epLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}