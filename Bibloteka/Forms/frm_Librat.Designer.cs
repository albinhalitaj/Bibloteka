
namespace Bibloteka.Forms
{
    partial class frm_Librat
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
            this.lblLibrat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLibrat
            // 
            this.lblLibrat.AutoSize = true;
            this.lblLibrat.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrat.Location = new System.Drawing.Point(24, 18);
            this.lblLibrat.Name = "lblLibrat";
            this.lblLibrat.Size = new System.Drawing.Size(84, 42);
            this.lblLibrat.TabIndex = 3;
            this.lblLibrat.Text = "Librat";
            // 
            // frm_Librat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 546);
            this.Controls.Add(this.lblLibrat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Librat";
            this.Text = "frm_Librat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibrat;
    }
}