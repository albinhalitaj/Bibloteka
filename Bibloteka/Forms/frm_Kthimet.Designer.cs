
namespace Bibloteka.Forms
{
    partial class frm_Kthimet
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
            this.lblKthimet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKthimet
            // 
            this.lblKthimet.AutoSize = true;
            this.lblKthimet.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKthimet.Location = new System.Drawing.Point(25, 18);
            this.lblKthimet.Name = "lblKthimet";
            this.lblKthimet.Size = new System.Drawing.Size(111, 42);
            this.lblKthimet.TabIndex = 3;
            this.lblKthimet.Text = "Kthimet";
            // 
            // frm_Kthimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 554);
            this.Controls.Add(this.lblKthimet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Kthimet";
            this.Text = "frm_Kthimet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKthimet;
    }
}