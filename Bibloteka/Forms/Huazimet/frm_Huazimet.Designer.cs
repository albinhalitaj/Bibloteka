
namespace Bibloteka.Forms
{
    partial class frm_Huazimet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKategorite = new System.Windows.Forms.Label();
            this.btnKyqu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgv_Kategorite = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kategorite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(34, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 3);
            this.panel1.TabIndex = 20;
            // 
            // lblKategorite
            // 
            this.lblKategorite.AutoSize = true;
            this.lblKategorite.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorite.Location = new System.Drawing.Point(26, 21);
            this.lblKategorite.Name = "lblKategorite";
            this.lblKategorite.Size = new System.Drawing.Size(132, 42);
            this.lblKategorite.TabIndex = 19;
            this.lblKategorite.Text = "Huazimet";
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
            this.btnKyqu.Location = new System.Drawing.Point(87, 120);
            this.btnKyqu.Margin = new System.Windows.Forms.Padding(2);
            this.btnKyqu.Name = "btnKyqu";
            this.btnKyqu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnKyqu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKyqu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKyqu.OnHoverImage = null;
            this.btnKyqu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKyqu.OnPressedColor = System.Drawing.Color.Black;
            this.btnKyqu.Radius = 3;
            this.btnKyqu.Size = new System.Drawing.Size(119, 41);
            this.btnKyqu.TabIndex = 32;
            this.btnKyqu.Text = "Huazo";
            this.btnKyqu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Kategorite
            // 
            this.dgv_Kategorite.AllowUserToAddRows = false;
            this.dgv_Kategorite.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Kategorite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Kategorite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kategorite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Kategorite.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Kategorite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Kategorite.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Kategorite.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Kategorite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Kategorite.ColumnHeadersHeight = 41;
            this.dgv_Kategorite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Kategorite.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Kategorite.EnableHeadersVisualStyles = false;
            this.dgv_Kategorite.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Kategorite.Location = new System.Drawing.Point(87, 190);
            this.dgv_Kategorite.Name = "dgv_Kategorite";
            this.dgv_Kategorite.ReadOnly = true;
            this.dgv_Kategorite.RowHeadersVisible = false;
            this.dgv_Kategorite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kategorite.Size = new System.Drawing.Size(946, 646);
            this.dgv_Kategorite.TabIndex = 34;
            this.dgv_Kategorite.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Kategorite.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Kategorite.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Kategorite.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Kategorite.ThemeStyle.ReadOnly = true;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Kategorite.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Kategorite.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Kategorite.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Kategorite.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "HuazimiID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Klienti";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Libri";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sasia";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DataHuazimit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DataKthimit";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Statusi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frm_Huazimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 878);
            this.Controls.Add(this.dgv_Kategorite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKyqu);
            this.Controls.Add(this.lblKategorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Huazimet";
            this.Text = "frm_Huazimet";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kategorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKategorite;
        private Guna.UI.WinForms.GunaAdvenceButton btnKyqu;
        private Guna.UI.WinForms.GunaDataGridView dgv_Kategorite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}