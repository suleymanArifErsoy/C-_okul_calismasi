
namespace FormlarEv
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
            this.lblBİlgi = new System.Windows.Forms.Label();
            this.lblSalonAdi1 = new System.Windows.Forms.Label();
            this.txtSalonAdi1 = new System.Windows.Forms.TextBox();
            this.txtKoltuksayisi1 = new System.Windows.Forms.TextBox();
            this.btnsaloncreate = new System.Windows.Forms.Button();
            this.btnsatis = new System.Windows.Forms.Button();
            this.btniade = new System.Windows.Forms.Button();
            this.grpboxrapor = new System.Windows.Forms.GroupBox();
            this.grpboxsatisIade = new System.Windows.Forms.GroupBox();
            this.grpboxdurum = new System.Windows.Forms.GroupBox();
            this.chkindirim = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKoltukSayisi = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.grpboxrapor.SuspendLayout();
            this.grpboxsatisIade.SuspendLayout();
            this.grpboxdurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBİlgi
            // 
            this.lblBİlgi.AutoSize = true;
            this.lblBİlgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBİlgi.Location = new System.Drawing.Point(37, 52);
            this.lblBİlgi.Name = "lblBİlgi";
            this.lblBİlgi.Size = new System.Drawing.Size(96, 17);
            this.lblBİlgi.TabIndex = 0;
            this.lblBİlgi.Text = "Koltuk Sayısı :";
            // 
            // lblSalonAdi1
            // 
            this.lblSalonAdi1.AutoSize = true;
            this.lblSalonAdi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalonAdi1.Location = new System.Drawing.Point(23, 9);
            this.lblSalonAdi1.Name = "lblSalonAdi1";
            this.lblSalonAdi1.Size = new System.Drawing.Size(80, 17);
            this.lblSalonAdi1.TabIndex = 0;
            this.lblSalonAdi1.Text = "Salon Adı : ";
            // 
            // txtSalonAdi1
            // 
            this.txtSalonAdi1.Location = new System.Drawing.Point(135, 6);
            this.txtSalonAdi1.Name = "txtSalonAdi1";
            this.txtSalonAdi1.Size = new System.Drawing.Size(152, 20);
            this.txtSalonAdi1.TabIndex = 1;
            // 
            // txtKoltuksayisi1
            // 
            this.txtKoltuksayisi1.Location = new System.Drawing.Point(135, 35);
            this.txtKoltuksayisi1.Name = "txtKoltuksayisi1";
            this.txtKoltuksayisi1.Size = new System.Drawing.Size(123, 20);
            this.txtKoltuksayisi1.TabIndex = 1;
            // 
            // btnsaloncreate
            // 
            this.btnsaloncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaloncreate.Location = new System.Drawing.Point(360, 6);
            this.btnsaloncreate.Name = "btnsaloncreate";
            this.btnsaloncreate.Size = new System.Drawing.Size(75, 49);
            this.btnsaloncreate.TabIndex = 2;
            this.btnsaloncreate.Text = "Salon Oluştur";
            this.btnsaloncreate.UseVisualStyleBackColor = true;
            this.btnsaloncreate.Click += new System.EventHandler(this.btnsaloncreate_Click);
            // 
            // btnsatis
            // 
            this.btnsatis.Enabled = false;
            this.btnsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsatis.Location = new System.Drawing.Point(14, 75);
            this.btnsatis.Name = "btnsatis";
            this.btnsatis.Size = new System.Drawing.Size(75, 69);
            this.btnsatis.TabIndex = 2;
            this.btnsatis.Text = "SATIŞ";
            this.btnsatis.UseVisualStyleBackColor = true;
            // 
            // btniade
            // 
            this.btniade.Enabled = false;
            this.btniade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniade.Location = new System.Drawing.Point(147, 75);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(75, 69);
            this.btniade.TabIndex = 2;
            this.btniade.Text = "İADE";
            this.btniade.UseVisualStyleBackColor = true;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // grpboxrapor
            // 
            this.grpboxrapor.Controls.Add(this.btnKoltukSayisi);
            this.grpboxrapor.Controls.Add(this.btnBakiye);
            this.grpboxrapor.Controls.Add(this.button5);
            this.grpboxrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxrapor.Location = new System.Drawing.Point(305, 84);
            this.grpboxrapor.Name = "grpboxrapor";
            this.grpboxrapor.Size = new System.Drawing.Size(261, 202);
            this.grpboxrapor.TabIndex = 3;
            this.grpboxrapor.TabStop = false;
            this.grpboxrapor.Text = "Rapor";
            // 
            // grpboxsatisIade
            // 
            this.grpboxsatisIade.Controls.Add(this.btniade);
            this.grpboxsatisIade.Controls.Add(this.chkindirim);
            this.grpboxsatisIade.Controls.Add(this.lblinfo);
            this.grpboxsatisIade.Controls.Add(this.btnsatis);
            this.grpboxsatisIade.Controls.Add(this.groupBox1);
            this.grpboxsatisIade.Enabled = false;
            this.grpboxsatisIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxsatisIade.Location = new System.Drawing.Point(12, 84);
            this.grpboxsatisIade.Name = "grpboxsatisIade";
            this.grpboxsatisIade.Size = new System.Drawing.Size(261, 202);
            this.grpboxsatisIade.TabIndex = 3;
            this.grpboxsatisIade.TabStop = false;
            this.grpboxsatisIade.Text = "Satış - İade";
            // 
            // grpboxdurum
            // 
            this.grpboxdurum.Controls.Add(this.lblBİlgi);
            this.grpboxdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxdurum.Location = new System.Drawing.Point(12, 304);
            this.grpboxdurum.Name = "grpboxdurum";
            this.grpboxdurum.Size = new System.Drawing.Size(261, 158);
            this.grpboxdurum.TabIndex = 3;
            this.grpboxdurum.TabStop = false;
            this.grpboxdurum.Text = "Durum";
            // 
            // chkindirim
            // 
            this.chkindirim.AutoSize = true;
            this.chkindirim.Enabled = false;
            this.chkindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkindirim.Location = new System.Drawing.Point(59, 30);
            this.chkindirim.Name = "chkindirim";
            this.chkindirim.Size = new System.Drawing.Size(74, 21);
            this.chkindirim.TabIndex = 3;
            this.chkindirim.Text = "İndirimli";
            this.chkindirim.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(287, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor";
            // 
            // btnKoltukSayisi
            // 
            this.btnKoltukSayisi.Enabled = false;
            this.btnKoltukSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKoltukSayisi.Location = new System.Drawing.Point(152, 75);
            this.btnKoltukSayisi.Name = "btnKoltukSayisi";
            this.btnKoltukSayisi.Size = new System.Drawing.Size(91, 69);
            this.btnKoltukSayisi.TabIndex = 2;
            this.btnKoltukSayisi.Text = "KoltukSayısı";
            this.btnKoltukSayisi.UseVisualStyleBackColor = true;
            this.btnKoltukSayisi.Click += new System.EventHandler(this.btniade_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(22, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 69);
            this.button5.TabIndex = 2;
            this.button5.Text = "İADE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btniade_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.Enabled = false;
            this.btnBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakiye.Location = new System.Drawing.Point(22, 76);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(91, 69);
            this.btnBakiye.TabIndex = 2;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btniade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Sayısı :";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(56, 158);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 17);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(599, 474);
            this.Controls.Add(this.grpboxdurum);
            this.Controls.Add(this.grpboxsatisIade);
            this.Controls.Add(this.grpboxrapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsaloncreate);
            this.Controls.Add(this.txtKoltuksayisi1);
            this.Controls.Add(this.txtSalonAdi1);
            this.Controls.Add(this.lblSalonAdi1);
            this.Name = "Form1";
            this.grpboxrapor.ResumeLayout(false);
            this.grpboxsatisIade.ResumeLayout(false);
            this.grpboxsatisIade.PerformLayout();
            this.grpboxdurum.ResumeLayout(false);
            this.grpboxdurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKoltukSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalonAdı;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpRapor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkboxIndirim;
        private System.Windows.Forms.GroupBox grpDurum;
        private System.Windows.Forms.Label lblBİlgi;
        private System.Windows.Forms.Label lblSalonAdi1;
        private System.Windows.Forms.TextBox txtSalonAdi1;
        private System.Windows.Forms.TextBox txtKoltuksayisi1;
        private System.Windows.Forms.Button btnsaloncreate;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.Button btniade;
        private System.Windows.Forms.GroupBox grpboxrapor;
        private System.Windows.Forms.GroupBox grpboxsatisIade;
        private System.Windows.Forms.CheckBox chkindirim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpboxdurum;
        private System.Windows.Forms.Button btnKoltukSayisi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Label label1;
    }
}

