
namespace WindowsFormsApp1
{
    partial class KullanıcıGiriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGiriş));
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.btnGirişYap = new System.Windows.Forms.Button();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(181, 44);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(88, 17);
            this.lblKullanıcıAdı.TabIndex = 0;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı ";
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Location = new System.Drawing.Point(184, 134);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(271, 26);
            this.btnGirişYap.TabIndex = 3;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(275, 41);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(180, 22);
            this.txtKullanıcıAdı.TabIndex = 0;
            this.txtKullanıcıAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Location = new System.Drawing.Point(181, 72);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(37, 17);
            this.lblŞifre.TabIndex = 0;
            this.lblŞifre.Text = "Şifre";
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(275, 69);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(180, 22);
            this.txtŞifre.TabIndex = 2;
            this.txtŞifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // KullanıcıGiriş
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(479, 169);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.btnGirişYap);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullanıcıGiriş";
            this.Text = "Kullanıcı Giriş ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Button btnGirişYap;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.TextBox txtŞifre;
    }
}

