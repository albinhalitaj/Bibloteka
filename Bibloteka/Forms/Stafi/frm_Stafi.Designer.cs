
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stafi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKategorite = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtKerko = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_Stafi = new Guna.UI.WinForms.GunaDataGridView();
            this.colStafiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatalindjes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKualifikimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stafi)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Picture2.png");
            this.imageList1.Images.SetKeyName(1, "Picture1.png");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Name = "panel1";
            // 
            // lblKategorite
            // 
            resources.ApplyResources(this.lblKategorite, "lblKategorite");
            this.lblKategorite.Name = "lblKategorite";
            // 
            // gunaGroupBox1
            // 
            resources.ApplyResources(this.gunaGroupBox1, "gunaGroupBox1");
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.btnShto);
            this.gunaGroupBox1.Controls.Add(this.txtKerko);
            this.gunaGroupBox1.Controls.Add(this.dgv_Stafi);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(30, 15);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnShto
            // 
            resources.ApplyResources(this.btnShto, "btnShto");
            this.btnShto.AnimationHoverSpeed = 0.07F;
            this.btnShto.AnimationSpeed = 0.03F;
            this.btnShto.BackColor = System.Drawing.Color.Transparent;
            this.btnShto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.btnShto.BorderColor = System.Drawing.Color.Black;
            this.btnShto.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShto.CheckedForeColor = System.Drawing.Color.White;
            this.btnShto.CheckedImage = null;
            this.btnShto.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShto.FocusedColor = System.Drawing.Color.Empty;
            this.btnShto.ForeColor = System.Drawing.Color.White;
            this.btnShto.Image = ((System.Drawing.Image)(resources.GetObject("btnShto.Image")));
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
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // txtKerko
            // 
            resources.ApplyResources(this.txtKerko, "txtKerko");
            this.txtKerko.BackColor = System.Drawing.Color.Transparent;
            this.txtKerko.BaseColor = System.Drawing.Color.White;
            this.txtKerko.BorderColor = System.Drawing.Color.Silver;
            this.txtKerko.BorderSize = 1;
            this.txtKerko.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKerko.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKerko.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtKerko.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.PasswordChar = '\0';
            this.txtKerko.Radius = 3;
            this.txtKerko.SelectedText = "";
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            // 
            // dgv_Stafi
            // 
            resources.ApplyResources(this.dgv_Stafi, "dgv_Stafi");
            this.dgv_Stafi.AllowUserToAddRows = false;
            this.dgv_Stafi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_Stafi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Stafi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stafi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Stafi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Stafi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Stafi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Stafi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Stafi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Stafi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStafiId,
            this.colEmri,
            this.colMbiemri,
            this.colDatalindjes,
            this.colNrPersonal,
            this.colKualifikimi,
            this.colUsername,
            this.colRoli,
            this.Edit,
            this.Delete});
            this.dgv_Stafi.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Stafi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Stafi.EnableHeadersVisualStyles = false;
            this.dgv_Stafi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Stafi.Name = "dgv_Stafi";
            this.dgv_Stafi.ReadOnly = true;
            this.dgv_Stafi.RowHeadersVisible = false;
            this.dgv_Stafi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.dgv_Stafi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Stafi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Stafi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Stafi.ThemeStyle.HeaderStyle.Height = 41;
            this.dgv_Stafi.ThemeStyle.ReadOnly = true;
            this.dgv_Stafi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Stafi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Stafi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Stafi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Stafi.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Stafi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Stafi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Stafi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Stafi_CellContentClick);
            // 
            // colStafiId
            // 
            resources.ApplyResources(this.colStafiId, "colStafiId");
            this.colStafiId.Name = "colStafiId";
            this.colStafiId.ReadOnly = true;
            // 
            // colEmri
            // 
            resources.ApplyResources(this.colEmri, "colEmri");
            this.colEmri.Name = "colEmri";
            this.colEmri.ReadOnly = true;
            // 
            // colMbiemri
            // 
            resources.ApplyResources(this.colMbiemri, "colMbiemri");
            this.colMbiemri.Name = "colMbiemri";
            this.colMbiemri.ReadOnly = true;
            // 
            // colDatalindjes
            // 
            resources.ApplyResources(this.colDatalindjes, "colDatalindjes");
            this.colDatalindjes.Name = "colDatalindjes";
            this.colDatalindjes.ReadOnly = true;
            // 
            // colNrPersonal
            // 
            resources.ApplyResources(this.colNrPersonal, "colNrPersonal");
            this.colNrPersonal.Name = "colNrPersonal";
            this.colNrPersonal.ReadOnly = true;
            // 
            // colKualifikimi
            // 
            resources.ApplyResources(this.colKualifikimi, "colKualifikimi");
            this.colKualifikimi.Name = "colKualifikimi";
            this.colKualifikimi.ReadOnly = true;
            // 
            // colUsername
            // 
            resources.ApplyResources(this.colUsername, "colUsername");
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colRoli
            // 
            resources.ApplyResources(this.colRoli, "colRoli");
            this.colRoli.Name = "colRoli";
            this.colRoli.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Edit, "Edit");
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // frm_Stafi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKategorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Stafi";
            this.Load += new System.EventHandler(this.frm_Stafi_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stafi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKategorite;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnShto;
        private Guna.UI.WinForms.GunaTextBox txtKerko;
        private Guna.UI.WinForms.GunaDataGridView dgv_Stafi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStafiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatalindjes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKualifikimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoli;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}