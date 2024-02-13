
namespace FormlarDers1
{
    partial class Form1
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
            this.kullanıcıAdı = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtkullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnbasla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullanıcıAdı
            // 
            this.kullanıcıAdı.AutoSize = true;
            this.kullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıAdı.Location = new System.Drawing.Point(12, 9);
            this.kullanıcıAdı.Name = "kullanıcıAdı";
            this.kullanıcıAdı.Size = new System.Drawing.Size(92, 17);
            this.kullanıcıAdı.TabIndex = 0;
            this.kullanıcıAdı.Text = "Kullanıcı Adı :";
            this.kullanıcıAdı.Click += new System.EventHandler(this.kullanıcıAdı_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(111, 36);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(141, 20);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.TextChanged += new System.EventHandler(this.txtKullanıcıAdı_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(12, 36);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 17);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre :";
            this.lblSifre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtkullaniciAdi
            // 
            this.txtkullaniciAdi.Location = new System.Drawing.Point(111, 6);
            this.txtkullaniciAdi.Multiline = true;
            this.txtkullaniciAdi.Name = "txtkullaniciAdi";
            this.txtkullaniciAdi.Size = new System.Drawing.Size(141, 20);
            this.txtkullaniciAdi.TabIndex = 1;
            this.txtkullaniciAdi.TextChanged += new System.EventHandler(this.txtKullanıcıAdı_TextChanged);
            // 
            // btnbasla
            // 
            this.btnbasla.Location = new System.Drawing.Point(285, 9);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(75, 50);
            this.btnbasla.TabIndex = 3;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(164, 86);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 516);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtkullaniciAdi);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.kullanıcıAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullanıcıAdı;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtkullaniciAdi;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

