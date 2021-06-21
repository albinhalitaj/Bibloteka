
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSqXK);
            this.panel1.Controls.Add(this.btnEnUS);
            this.epLogin.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.epLogin.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.epLogin.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.epLogin.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.epLogin.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.epLogin.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnSqXK
            // 
            resources.ApplyResources(this.btnSqXK, "btnSqXK");
            this.btnSqXK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epLogin.SetError(this.btnSqXK, resources.GetString("btnSqXK.Error"));
            this.epLogin.SetIconAlignment(this.btnSqXK, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSqXK.IconAlignment"))));
            this.epLogin.SetIconPadding(this.btnSqXK, ((int)(resources.GetObject("btnSqXK.IconPadding"))));
            this.btnSqXK.Name = "btnSqXK";
            this.btnSqXK.TabStop = false;
            this.btnSqXK.Click += new System.EventHandler(this.btnSqXK_Click);
            // 
            // btnEnUS
            // 
            resources.ApplyResources(this.btnEnUS, "btnEnUS");
            this.btnEnUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epLogin.SetError(this.btnEnUS, resources.GetString("btnEnUS.Error"));
            this.epLogin.SetIconAlignment(this.btnEnUS, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnEnUS.IconAlignment"))));
            this.epLogin.SetIconPadding(this.btnEnUS, ((int)(resources.GetObject("btnEnUS.IconPadding"))));
            this.btnEnUS.Name = "btnEnUS";
            this.btnEnUS.TabStop = false;
            this.btnEnUS.Click += new System.EventHandler(this.btnEnUS_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.epLogin.SetError(this.label4, resources.GetString("label4.Error"));
            this.epLogin.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.epLogin.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.epLogin.SetError(this.label3, resources.GetString("label3.Error"));
            this.epLogin.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.epLogin.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.epLogin.SetError(this.label2, resources.GetString("label2.Error"));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.epLogin.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.epLogin.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.epLogin.SetError(this.label1, resources.GetString("label1.Error"));
            this.epLogin.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.epLogin.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtPerdoruesi
            // 
            resources.ApplyResources(this.txtPerdoruesi, "txtPerdoruesi");
            this.txtPerdoruesi.BackColor = System.Drawing.Color.Transparent;
            this.txtPerdoruesi.BaseColor = System.Drawing.Color.White;
            this.txtPerdoruesi.BorderColor = System.Drawing.Color.Gray;
            this.txtPerdoruesi.BorderSize = 1;
            this.txtPerdoruesi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLogin.SetError(this.txtPerdoruesi, resources.GetString("txtPerdoruesi.Error"));
            this.txtPerdoruesi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPerdoruesi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtPerdoruesi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLogin.SetIconAlignment(this.txtPerdoruesi, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPerdoruesi.IconAlignment"))));
            this.epLogin.SetIconPadding(this.txtPerdoruesi, ((int)(resources.GetObject("txtPerdoruesi.IconPadding"))));
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.PasswordChar = '\0';
            this.txtPerdoruesi.Radius = 3;
            this.txtPerdoruesi.SelectedText = "";
            // 
            // txtFjalekalimi
            // 
            resources.ApplyResources(this.txtFjalekalimi, "txtFjalekalimi");
            this.txtFjalekalimi.BackColor = System.Drawing.Color.Transparent;
            this.txtFjalekalimi.BaseColor = System.Drawing.Color.White;
            this.txtFjalekalimi.BorderColor = System.Drawing.Color.Gray;
            this.txtFjalekalimi.BorderSize = 1;
            this.txtFjalekalimi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLogin.SetError(this.txtFjalekalimi, resources.GetString("txtFjalekalimi.Error"));
            this.txtFjalekalimi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFjalekalimi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtFjalekalimi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epLogin.SetIconAlignment(this.txtFjalekalimi, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFjalekalimi.IconAlignment"))));
            this.epLogin.SetIconPadding(this.txtFjalekalimi, ((int)(resources.GetObject("txtFjalekalimi.IconPadding"))));
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.PasswordChar = '*';
            this.txtFjalekalimi.Radius = 3;
            this.txtFjalekalimi.SelectedText = "";
            // 
            // btnKyqu
            // 
            resources.ApplyResources(this.btnKyqu, "btnKyqu");
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
            this.epLogin.SetError(this.btnKyqu, resources.GetString("btnKyqu.Error"));
            this.btnKyqu.FocusedColor = System.Drawing.Color.Empty;
            this.btnKyqu.ForeColor = System.Drawing.Color.White;
            this.epLogin.SetIconAlignment(this.btnKyqu, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnKyqu.IconAlignment"))));
            this.epLogin.SetIconPadding(this.btnKyqu, ((int)(resources.GetObject("btnKyqu.IconPadding"))));
            this.btnKyqu.Image = null;
            this.btnKyqu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKyqu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKyqu.Name = "btnKyqu";
            this.btnKyqu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnKyqu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKyqu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKyqu.OnHoverImage = null;
            this.btnKyqu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKyqu.OnPressedColor = System.Drawing.Color.Black;
            this.btnKyqu.Radius = 3;
            this.btnKyqu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKyqu.Click += new System.EventHandler(this.btnKyqu_Click);
            // 
            // chkMeMbajMend
            // 
            resources.ApplyResources(this.chkMeMbajMend, "chkMeMbajMend");
            this.chkMeMbajMend.BaseColor = System.Drawing.Color.White;
            this.chkMeMbajMend.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkMeMbajMend.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.epLogin.SetError(this.chkMeMbajMend, resources.GetString("chkMeMbajMend.Error"));
            this.chkMeMbajMend.FillColor = System.Drawing.Color.White;
            this.epLogin.SetIconAlignment(this.chkMeMbajMend, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkMeMbajMend.IconAlignment"))));
            this.epLogin.SetIconPadding(this.chkMeMbajMend, ((int)(resources.GetObject("chkMeMbajMend.IconPadding"))));
            this.chkMeMbajMend.Name = "chkMeMbajMend";
            // 
            // epLogin
            // 
            this.epLogin.ContainerControl = this;
            resources.ApplyResources(this.epLogin, "epLogin");
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chkMeMbajMend);
            this.Controls.Add(this.btnKyqu);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.txtPerdoruesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
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