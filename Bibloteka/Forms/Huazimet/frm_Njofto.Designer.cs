
namespace Bibloteka.Forms.Huazimet
{
    partial class frm_Njofto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Njofto));
            BaiqiSoft.HtmlEditorControl.FormatHtmlOptions formatHtmlOptions1 = new BaiqiSoft.HtmlEditorControl.FormatHtmlOptions();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubjekti = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtMesazhi = new BaiqiSoft.HtmlEditorControl.MstHtmlEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmaili = new Guna.UI.WinForms.GunaTextBox();
            this.txtKlienti = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnulo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNjofto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.epNjoftimi = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNjoftimi)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            resources.ApplyResources(this.gunaGroupBox1, "gunaGroupBox1");
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtSubjekti);
            this.gunaGroupBox1.Controls.Add(this.gunaGroupBox2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtEmaili);
            this.gunaGroupBox1.Controls.Add(this.txtKlienti);
            this.gunaGroupBox1.Controls.Add(this.panel2);
            this.gunaGroupBox1.Controls.Add(this.btnAnulo);
            this.gunaGroupBox1.Controls.Add(this.btnNjofto);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.epNjoftimi.SetError(this.gunaGroupBox1, resources.GetString("gunaGroupBox1.Error"));
            this.epNjoftimi.SetIconAlignment(this.gunaGroupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gunaGroupBox1.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.gunaGroupBox1, ((int)(resources.GetObject("gunaGroupBox1.IconPadding"))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.epNjoftimi.SetError(this.label4, resources.GetString("label4.Error"));
            this.epNjoftimi.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.epNjoftimi.SetError(this.label2, resources.GetString("label2.Error"));
            this.epNjoftimi.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtSubjekti
            // 
            resources.ApplyResources(this.txtSubjekti, "txtSubjekti");
            this.txtSubjekti.BackColor = System.Drawing.Color.Transparent;
            this.txtSubjekti.BaseColor = System.Drawing.Color.White;
            this.txtSubjekti.BorderColor = System.Drawing.Color.Silver;
            this.txtSubjekti.BorderSize = 1;
            this.txtSubjekti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epNjoftimi.SetError(this.txtSubjekti, resources.GetString("txtSubjekti.Error"));
            this.txtSubjekti.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSubjekti.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtSubjekti.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epNjoftimi.SetIconAlignment(this.txtSubjekti, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSubjekti.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.txtSubjekti, ((int)(resources.GetObject("txtSubjekti.IconPadding"))));
            this.txtSubjekti.Name = "txtSubjekti";
            this.txtSubjekti.PasswordChar = '\0';
            this.txtSubjekti.Radius = 3;
            this.txtSubjekti.SelectedText = "";
            // 
            // gunaGroupBox2
            // 
            resources.ApplyResources(this.gunaGroupBox2, "gunaGroupBox2");
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.txtMesazhi);
            this.epNjoftimi.SetError(this.gunaGroupBox2, resources.GetString("gunaGroupBox2.Error"));
            this.epNjoftimi.SetIconAlignment(this.gunaGroupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gunaGroupBox2.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.gunaGroupBox2, ((int)(resources.GetObject("gunaGroupBox2.IconPadding"))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.LineTop = 0;
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 3;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtMesazhi
            // 
            resources.ApplyResources(this.txtMesazhi, "txtMesazhi");
            this.epNjoftimi.SetError(this.txtMesazhi, resources.GetString("txtMesazhi.Error"));
            formatHtmlOptions1.BreakBeforeBR = true;
            formatHtmlOptions1.ClosingSingleTags = true;
            formatHtmlOptions1.IndentHtmlTags = true;
            formatHtmlOptions1.IndentScript = true;
            formatHtmlOptions1.IndentSpaces = 4;
            formatHtmlOptions1.IndentWithTabs = false;
            formatHtmlOptions1.LowercaseTags = true;
            formatHtmlOptions1.QuoteAttributeValues = true;
            this.txtMesazhi.FormatHtmlOptions = formatHtmlOptions1;
            this.epNjoftimi.SetIconAlignment(this.txtMesazhi, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMesazhi.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.txtMesazhi, ((int)(resources.GetObject("txtMesazhi.IconPadding"))));
            this.txtMesazhi.LanguageConfig = null;
            this.txtMesazhi.Name = "txtMesazhi";
            this.txtMesazhi.SelectionLength = 0;
            this.txtMesazhi.SelectionStart = 0;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.epNjoftimi.SetError(this.label1, resources.GetString("label1.Error"));
            this.epNjoftimi.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtEmaili
            // 
            resources.ApplyResources(this.txtEmaili, "txtEmaili");
            this.txtEmaili.BackColor = System.Drawing.Color.Transparent;
            this.txtEmaili.BaseColor = System.Drawing.Color.White;
            this.txtEmaili.BorderColor = System.Drawing.Color.Silver;
            this.txtEmaili.BorderSize = 1;
            this.txtEmaili.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epNjoftimi.SetError(this.txtEmaili, resources.GetString("txtEmaili.Error"));
            this.txtEmaili.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmaili.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtEmaili.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epNjoftimi.SetIconAlignment(this.txtEmaili, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmaili.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.txtEmaili, ((int)(resources.GetObject("txtEmaili.IconPadding"))));
            this.txtEmaili.Name = "txtEmaili";
            this.txtEmaili.PasswordChar = '\0';
            this.txtEmaili.Radius = 3;
            this.txtEmaili.ReadOnly = true;
            this.txtEmaili.SelectedText = "";
            // 
            // txtKlienti
            // 
            resources.ApplyResources(this.txtKlienti, "txtKlienti");
            this.txtKlienti.BackColor = System.Drawing.Color.Transparent;
            this.txtKlienti.BaseColor = System.Drawing.Color.White;
            this.txtKlienti.BorderColor = System.Drawing.Color.Silver;
            this.txtKlienti.BorderSize = 1;
            this.txtKlienti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epNjoftimi.SetError(this.txtKlienti, resources.GetString("txtKlienti.Error"));
            this.txtKlienti.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKlienti.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKlienti.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.epNjoftimi.SetIconAlignment(this.txtKlienti, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtKlienti.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.txtKlienti, ((int)(resources.GetObject("txtKlienti.IconPadding"))));
            this.txtKlienti.Name = "txtKlienti";
            this.txtKlienti.PasswordChar = '\0';
            this.txtKlienti.Radius = 3;
            this.txtKlienti.ReadOnly = true;
            this.txtKlienti.SelectedText = "";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.epNjoftimi.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.epNjoftimi.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
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
            this.epNjoftimi.SetError(this.btnAnulo, resources.GetString("btnAnulo.Error"));
            this.btnAnulo.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnulo.ForeColor = System.Drawing.Color.White;
            this.epNjoftimi.SetIconAlignment(this.btnAnulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAnulo.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.btnAnulo, ((int)(resources.GetObject("btnAnulo.IconPadding"))));
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
            // btnNjofto
            // 
            resources.ApplyResources(this.btnNjofto, "btnNjofto");
            this.btnNjofto.AnimationHoverSpeed = 0.07F;
            this.btnNjofto.AnimationSpeed = 0.03F;
            this.btnNjofto.BackColor = System.Drawing.Color.Transparent;
            this.btnNjofto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnNjofto.BorderColor = System.Drawing.Color.Black;
            this.btnNjofto.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnNjofto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNjofto.CheckedForeColor = System.Drawing.Color.White;
            this.btnNjofto.CheckedImage = null;
            this.btnNjofto.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNjofto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNjofto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.epNjoftimi.SetError(this.btnNjofto, resources.GetString("btnNjofto.Error"));
            this.btnNjofto.FocusedColor = System.Drawing.Color.Empty;
            this.btnNjofto.ForeColor = System.Drawing.Color.White;
            this.epNjoftimi.SetIconAlignment(this.btnNjofto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnNjofto.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.btnNjofto, ((int)(resources.GetObject("btnNjofto.IconPadding"))));
            this.btnNjofto.Image = null;
            this.btnNjofto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNjofto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNjofto.Name = "btnNjofto";
            this.btnNjofto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnNjofto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNjofto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNjofto.OnHoverImage = null;
            this.btnNjofto.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNjofto.OnPressedColor = System.Drawing.Color.Black;
            this.btnNjofto.Radius = 3;
            this.btnNjofto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNjofto.Click += new System.EventHandler(this.btnNjofto_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.epNjoftimi.SetError(this.label3, resources.GetString("label3.Error"));
            this.epNjoftimi.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.epNjoftimi.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // epNjoftimi
            // 
            this.epNjoftimi.ContainerControl = this;
            resources.ApplyResources(this.epNjoftimi, "epNjoftimi");
            // 
            // frm_Njofto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Njofto";
            this.Load += new System.EventHandler(this.frm_Njofto_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epNjoftimi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnulo;
        private Guna.UI.WinForms.GunaAdvenceButton btnNjofto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtSubjekti;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private BaiqiSoft.HtmlEditorControl.MstHtmlEditor txtMesazhi;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtEmaili;
        private Guna.UI.WinForms.GunaTextBox txtKlienti;
        private System.Windows.Forms.ErrorProvider epNjoftimi;
    }
}