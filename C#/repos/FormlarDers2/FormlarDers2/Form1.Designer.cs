
namespace FormlarDers2
{
    partial class sinemaOtomasyon
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
            this.SuspendLayout();
            // 
            // sinemaOtomasyon
            // 
            this.ClientSize = new System.Drawing.Size(695, 387);
            this.Name = "sinemaOtomasyon";
            this.Load += new System.EventHandler(this.sinemaOtomasyon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.Label lblKoltukSayısı;
        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox grpboxsatis;
        private System.Windows.Forms.CheckBox chkboxindirim;
        private System.Windows.Forms.GroupBox grpboxrapor;
        private System.Windows.Forms.GroupBox grpboxdurum;
        private System.Windows.Forms.Button btniade;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.Button btnbosKoltuk;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Label lblinfo;
    }
}

