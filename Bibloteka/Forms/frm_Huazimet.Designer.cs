
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
            this.lblHuazimet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHuazimet
            // 
            this.lblHuazimet.AutoSize = true;
            this.lblHuazimet.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuazimet.Location = new System.Drawing.Point(22, 19);
            this.lblHuazimet.Name = "lblHuazimet";
            this.lblHuazimet.Size = new System.Drawing.Size(132, 42);
            this.lblHuazimet.TabIndex = 3;
            this.lblHuazimet.Text = "Huazimet";
            // 
            // frm_Huazimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Controls.Add(this.lblHuazimet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Huazimet";
            this.Text = "frm_Huazimet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuazimet;
    }
}