
namespace WindowsFormsApp1
{
    partial class Anaform
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
            this.lblselamala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblselamala
            // 
            this.lblselamala.AutoSize = true;
            this.lblselamala.Location = new System.Drawing.Point(302, 56);
            this.lblselamala.Name = "lblselamala";
            this.lblselamala.Size = new System.Drawing.Size(0, 17);
            this.lblselamala.TabIndex = 0;
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 83);
            this.Controls.Add(this.lblselamala);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblselamala;
    }
}