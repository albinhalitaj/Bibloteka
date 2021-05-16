
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
            this.lblStafi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStafi
            // 
            this.lblStafi.AutoSize = true;
            this.lblStafi.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStafi.Location = new System.Drawing.Point(24, 18);
            this.lblStafi.Name = "lblStafi";
            this.lblStafi.Size = new System.Drawing.Size(71, 42);
            this.lblStafi.TabIndex = 3;
            this.lblStafi.Text = "Stafi";
            // 
            // frm_Stafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 492);
            this.Controls.Add(this.lblStafi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Stafi";
            this.Text = "frm_Stafi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStafi;
    }
}