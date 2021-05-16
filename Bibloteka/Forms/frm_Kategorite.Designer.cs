
namespace Bibloteka.Forms
{
    partial class frm_Kategorite
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
            this.lblKategorite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKategorite
            // 
            this.lblKategorite.AutoSize = true;
            this.lblKategorite.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorite.Location = new System.Drawing.Point(24, 19);
            this.lblKategorite.Name = "lblKategorite";
            this.lblKategorite.Size = new System.Drawing.Size(142, 42);
            this.lblKategorite.TabIndex = 1;
            this.lblKategorite.Text = "Kategoritë";
            // 
            // frm_Kategorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 567);
            this.Controls.Add(this.lblKategorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Kategorite";
            this.Text = "frm_Kategorite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorite;
    }
}