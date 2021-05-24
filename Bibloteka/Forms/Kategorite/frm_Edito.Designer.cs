
namespace Bibloteka.Forms
{
    partial class frm_Edito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Edito));
            this.epKategorite = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnulo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtEmertimi = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPershkrimi = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epKategorite)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // epKategorite
            // 
            this.epKategorite.ContainerControl = this;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.panel2);
            this.gunaGroupBox1.Controls.Add(this.btnAnulo);
            this.gunaGroupBox1.Controls.Add(this.btnShto);
            this.gunaGroupBox1.Controls.Add(this.txtEmertimi);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.txtPershkrimi);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(402, 409);
            this.gunaGroupBox1.TabIndex = 52;
            this.gunaGroupBox1.Text = "Informatat e Kategorisë";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(235, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 3);
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
            this.btnAnulo.Location = new System.Drawing.Point(151, 313);
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
            this.btnAnulo.TabIndex = 22;
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
            this.btnShto.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.Image = null;
            this.btnShto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShto.Location = new System.Drawing.Point(246, 313);
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
            this.btnShto.TabIndex = 21;
            this.btnShto.Text = "Ruaj";
            this.btnShto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // txtEmertimi
            // 
            this.txtEmertimi.BackColor = System.Drawing.Color.Transparent;
            this.txtEmertimi.BaseColor = System.Drawing.Color.White;
            this.txtEmertimi.BorderColor = System.Drawing.Color.Silver;
            this.txtEmertimi.BorderSize = 1;
            this.txtEmertimi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmertimi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmertimi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEmertimi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmertimi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmertimi.Location = new System.Drawing.Point(74, 115);
            this.txtEmertimi.Name = "txtEmertimi";
            this.txtEmertimi.PasswordChar = '\0';
            this.txtEmertimi.Radius = 3;
            this.txtEmertimi.SelectedText = "";
            this.txtEmertimi.Size = new System.Drawing.Size(250, 34);
            this.txtEmertimi.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(69, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Emërtimi";
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
            this.txtPershkrimi.Location = new System.Drawing.Point(74, 208);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.PasswordChar = '\0';
            this.txtPershkrimi.Radius = 3;
            this.txtPershkrimi.SelectedText = "";
            this.txtPershkrimi.Size = new System.Drawing.Size(250, 62);
            this.txtPershkrimi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(69, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Përshkrimi";
            // 
            // frm_Edito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 409);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(402, 409);
            this.MinimumSize = new System.Drawing.Size(402, 409);
            this.Name = "frm_Edito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edito Kategori";
            this.Load += new System.EventHandler(this.frm_Edito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epKategorite)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epKategorite;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnulo;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private Guna.UI.WinForms.GunaTextBox txtEmertimi;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtPershkrimi;
        private System.Windows.Forms.Label label4;
    }
}