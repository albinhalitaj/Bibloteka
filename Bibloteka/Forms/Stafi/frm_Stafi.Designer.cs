
namespace Bibloteka.Forms
{
    partial class frm_Stafi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stafi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStafi = new System.Windows.Forms.Label();
            this.GrbStafi = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnShto = new Guna.UI.WinForms.GunaButton();
            this.dgv_Stafi = new Guna.UI.WinForms.GunaDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKerko = new Guna.UI.WinForms.GunaTextBox();
            this.colEmri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatelindja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGjinia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKualifikimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrbStafi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stafi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStafi
            // 
            this.lblStafi.AutoSize = true;
            this.lblStafi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStafi.Location = new System.Drawing.Point(36, 28);
            this.lblStafi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStafi.Name = "lblStafi";
            this.lblStafi.Size = new System.Drawing.Size(89, 40);
            this.lblStafi.TabIndex = 3;
            this.lblStafi.Text = "Stafi";
            // 
            // GrbStafi
            // 
            this.GrbStafi.BackColor = System.Drawing.Color.Transparent;
            this.GrbStafi.BaseColor = System.Drawing.Color.White;
            this.GrbStafi.BorderColor = System.Drawing.Color.Gainsboro;
            this.GrbStafi.BorderSize = 2;
            this.GrbStafi.Controls.Add(this.txtKerko);
            this.GrbStafi.Controls.Add(this.label5);
            this.GrbStafi.Controls.Add(this.dgv_Stafi);
            this.GrbStafi.Controls.Add(this.btnShto);
            this.GrbStafi.Controls.Add(this.gunaGroupBox2);
            this.GrbStafi.LineColor = System.Drawing.Color.Gainsboro;
            this.GrbStafi.LineTop = 0;
            this.GrbStafi.Location = new System.Drawing.Point(116, 143);
            this.GrbStafi.Name = "GrbStafi";
            this.GrbStafi.Size = new System.Drawing.Size(1705, 912);
            this.GrbStafi.TabIndex = 4;
            this.GrbStafi.TextLocation = new System.Drawing.Point(10, 8);
            this.GrbStafi.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(237, 14);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(13, 8);
            this.gunaGroupBox2.TabIndex = 0;
            this.gunaGroupBox2.Text = "gunaGroupBox2";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnShto
            // 
            this.btnShto.AnimationHoverSpeed = 0.07F;
            this.btnShto.AnimationSpeed = 0.03F;
            this.btnShto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnShto.BorderColor = System.Drawing.Color.Black;
            this.btnShto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShto.FocusedColor = System.Drawing.Color.Empty;
            this.btnShto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.Image = ((System.Drawing.Image)(resources.GetObject("btnShto.Image")));
            this.btnShto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShto.Location = new System.Drawing.Point(56, 57);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShto.Name = "btnShto";
            this.btnShto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnShto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShto.OnHoverImage = null;
            this.btnShto.OnPressedColor = System.Drawing.Color.Black;
            this.btnShto.Size = new System.Drawing.Size(189, 52);
            this.btnShto.TabIndex = 30;
            this.btnShto.Text = "Shto";
            // 
            // dgv_Stafi
            // 
            this.dgv_Stafi.AllowUserToAddRows = false;
            this.dgv_Stafi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Stafi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Stafi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Stafi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stafi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Stafi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Stafi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Stafi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Stafi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Stafi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Stafi.ColumnHeadersHeight = 41;
            this.dgv_Stafi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmri,
            this.colMbiemri,
            this.colDatelindja,
            this.colGjinia,
            this.colNrPersonal,
            this.colISBN,
            this.colKualifikimi,
            this.colAdresa,
            this.colEmail,
            this.colRoli});
            this.dgv_Stafi.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Stafi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Stafi.EnableHeadersVisualStyles = false;
            this.dgv_Stafi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Stafi.Location = new System.Drawing.Point(37, 179);
            this.dgv_Stafi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Stafi.Name = "dgv_Stafi";
            this.dgv_Stafi.ReadOnly = true;
            this.dgv_Stafi.RowHeadersVisible = false;
            this.dgv_Stafi.RowHeadersWidth = 62;
            this.dgv_Stafi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Stafi.Size = new System.Drawing.Size(1615, 686);
            this.dgv_Stafi.TabIndex = 24;
            this.dgv_Stafi.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Stafi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Stafi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Stafi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Stafi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Stafi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Stafi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Stafi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Stafi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dgv_Stafi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Stafi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Stafi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Stafi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Stafi.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Stafi.ThemeStyle.ReadOnly = true;
            this.dgv_Stafi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Stafi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Stafi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Stafi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Stafi.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Stafi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Stafi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1143, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kërkoni:";
            // 
            // txtKerko
            // 
            this.txtKerko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKerko.BackColor = System.Drawing.Color.Transparent;
            this.txtKerko.BaseColor = System.Drawing.Color.White;
            this.txtKerko.BorderColor = System.Drawing.Color.Silver;
            this.txtKerko.BorderSize = 1;
            this.txtKerko.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKerko.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKerko.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKerko.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerko.Location = new System.Drawing.Point(1277, 57);
            this.txtKerko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.PasswordChar = '\0';
            this.txtKerko.Radius = 3;
            this.txtKerko.SelectedText = "";
            this.txtKerko.Size = new System.Drawing.Size(375, 52);
            this.txtKerko.TabIndex = 30;
            // 
            // colEmri
            // 
            this.colEmri.HeaderText = "Emri";
            this.colEmri.MinimumWidth = 8;
            this.colEmri.Name = "colEmri";
            this.colEmri.ReadOnly = true;
            // 
            // colMbiemri
            // 
            this.colMbiemri.HeaderText = "Mbiemri";
            this.colMbiemri.MinimumWidth = 8;
            this.colMbiemri.Name = "colMbiemri";
            this.colMbiemri.ReadOnly = true;
            // 
            // colDatelindja
            // 
            this.colDatelindja.HeaderText = "Datelindja";
            this.colDatelindja.MinimumWidth = 8;
            this.colDatelindja.Name = "colDatelindja";
            this.colDatelindja.ReadOnly = true;
            // 
            // colGjinia
            // 
            this.colGjinia.HeaderText = "Gjinia";
            this.colGjinia.MinimumWidth = 8;
            this.colGjinia.Name = "colGjinia";
            this.colGjinia.ReadOnly = true;
            // 
            // colNrPersonal
            // 
            this.colNrPersonal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNrPersonal.HeaderText = "Nr.Personal";
            this.colNrPersonal.MinimumWidth = 8;
            this.colNrPersonal.Name = "colNrPersonal";
            this.colNrPersonal.ReadOnly = true;
            this.colNrPersonal.Width = 150;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "Nr.Kontaktues";
            this.colISBN.MinimumWidth = 8;
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colKualifikimi
            // 
            this.colKualifikimi.HeaderText = "Kualifikimi";
            this.colKualifikimi.MinimumWidth = 8;
            this.colKualifikimi.Name = "colKualifikimi";
            this.colKualifikimi.ReadOnly = true;
            // 
            // colAdresa
            // 
            this.colAdresa.HeaderText = "Adresa";
            this.colAdresa.MinimumWidth = 8;
            this.colAdresa.Name = "colAdresa";
            this.colAdresa.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colRoli
            // 
            this.colRoli.HeaderText = "Roli";
            this.colRoli.MinimumWidth = 8;
            this.colRoli.Name = "colRoli";
            this.colRoli.ReadOnly = true;
            // 
            // frm_Stafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1833, 1089);
            this.Controls.Add(this.GrbStafi);
            this.Controls.Add(this.lblStafi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Stafi";
            this.Text = "frm_Stafi";
            this.GrbStafi.ResumeLayout(false);
            this.GrbStafi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stafi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStafi;
        private Guna.UI.WinForms.GunaGroupBox GrbStafi;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnShto;
        private Guna.UI.WinForms.GunaDataGridView dgv_Stafi;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatelindja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGjinia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKualifikimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoli;
    }
}