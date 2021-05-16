
namespace Bibloteka.Forms
{
    partial class frm_Klientet
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
            this.lblKlientet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKlientet
            // 
            this.lblKlientet.AutoSize = true;
            this.lblKlientet.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlientet.Location = new System.Drawing.Point(26, 21);
            this.lblKlientet.Name = "lblKlientet";
            this.lblKlientet.Size = new System.Drawing.Size(107, 42);
            this.lblKlientet.TabIndex = 2;
            this.lblKlientet.Text = "Klientët";
            // 
            // frm_Klientet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 539);
            this.Controls.Add(this.lblKlientet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Klientet";
            this.Text = "frm_Klientet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlientet;
    }
}