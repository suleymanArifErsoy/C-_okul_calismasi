
namespace OtoparkUygulama
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lblOtoparkAdı = new System.Windows.Forms.Label();
            this.lblOtoparkKapasitesi = new System.Windows.Forms.Label();
            this.txtOtoparkAdı = new System.Windows.Forms.TextBox();
            this.txtOtoparkKapasitesi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKalanKapasite = new System.Windows.Forms.Button();
            this.btnBakiyeSorgula = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAracTipi = new System.Windows.Forms.CheckBox();
            this.btnIade = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(469, 9);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(114, 46);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblOtoparkAdı
            // 
            this.lblOtoparkAdı.AutoSize = true;
            this.lblOtoparkAdı.Location = new System.Drawing.Point(21, 9);
            this.lblOtoparkAdı.Name = "lblOtoparkAdı";
            this.lblOtoparkAdı.Size = new System.Drawing.Size(63, 13);
            this.lblOtoparkAdı.TabIndex = 1;
            this.lblOtoparkAdı.Text = "Otopark Adı";
            // 
            // lblOtoparkKapasitesi
            // 
            this.lblOtoparkKapasitesi.AutoSize = true;
            this.lblOtoparkKapasitesi.Location = new System.Drawing.Point(21, 36);
            this.lblOtoparkKapasitesi.Name = "lblOtoparkKapasitesi";
            this.lblOtoparkKapasitesi.Size = new System.Drawing.Size(96, 13);
            this.lblOtoparkKapasitesi.TabIndex = 2;
            this.lblOtoparkKapasitesi.Text = "Otopark Kapasitesi";
            // 
            // txtOtoparkAdı
            // 
            this.txtOtoparkAdı.Location = new System.Drawing.Point(169, 6);
            this.txtOtoparkAdı.Name = "txtOtoparkAdı";
            this.txtOtoparkAdı.Size = new System.Drawing.Size(239, 20);
            this.txtOtoparkAdı.TabIndex = 3;
            // 
            // txtOtoparkKapasitesi
            // 
            this.txtOtoparkKapasitesi.Location = new System.Drawing.Point(169, 36);
            this.txtOtoparkKapasitesi.Name = "txtOtoparkKapasitesi";
            this.txtOtoparkKapasitesi.Size = new System.Drawing.Size(239, 20);
            this.txtOtoparkKapasitesi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKalanKapasite);
            this.groupBox1.Controls.Add(this.btnBakiyeSorgula);
            this.groupBox1.Location = new System.Drawing.Point(296, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnKalanKapasite
            // 
            this.btnKalanKapasite.Enabled = false;
            this.btnKalanKapasite.Location = new System.Drawing.Point(147, 106);
            this.btnKalanKapasite.Name = "btnKalanKapasite";
            this.btnKalanKapasite.Size = new System.Drawing.Size(120, 69);
            this.btnKalanKapasite.TabIndex = 5;
            this.btnKalanKapasite.Text = "Kalan Kapasite";
            this.btnKalanKapasite.UseVisualStyleBackColor = true;
            this.btnKalanKapasite.Click += new System.EventHandler(this.btnKalanKapasite_Click);
            // 
            // btnBakiyeSorgula
            // 
            this.btnBakiyeSorgula.Enabled = false;
            this.btnBakiyeSorgula.Location = new System.Drawing.Point(15, 106);
            this.btnBakiyeSorgula.Name = "btnBakiyeSorgula";
            this.btnBakiyeSorgula.Size = new System.Drawing.Size(114, 69);
            this.btnBakiyeSorgula.TabIndex = 5;
            this.btnBakiyeSorgula.Text = "Bakiye Sorgula";
            this.btnBakiyeSorgula.UseVisualStyleBackColor = true;
            this.btnBakiyeSorgula.Click += new System.EventHandler(this.btnBakiyeSorgula_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_info);
            this.groupBox2.Location = new System.Drawing.Point(24, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(71, 25);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAracTipi);
            this.groupBox3.Controls.Add(this.btnIade);
            this.groupBox3.Controls.Add(this.btnSatis);
            this.groupBox3.Location = new System.Drawing.Point(24, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 194);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilet Satış-İade";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkAracTipi
            // 
            this.chkAracTipi.AutoSize = true;
            this.chkAracTipi.Enabled = false;
            this.chkAracTipi.Location = new System.Drawing.Point(74, 48);
            this.chkAracTipi.Name = "chkAracTipi";
            this.chkAracTipi.Size = new System.Drawing.Size(89, 17);
            this.chkAracTipi.TabIndex = 6;
            this.chkAracTipi.Text = "BüyükAraçMı";
            this.chkAracTipi.UseVisualStyleBackColor = true;
            // 
            // btnIade
            // 
            this.btnIade.Enabled = false;
            this.btnIade.Location = new System.Drawing.Point(129, 106);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(105, 69);
            this.btnIade.TabIndex = 5;
            this.btnIade.Text = "İade";
            this.btnIade.UseVisualStyleBackColor = true;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Enabled = false;
            this.btnSatis.Location = new System.Drawing.Point(6, 106);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(101, 69);
            this.btnSatis.TabIndex = 5;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOtoparkKapasitesi);
            this.Controls.Add(this.txtOtoparkAdı);
            this.Controls.Add(this.lblOtoparkKapasitesi);
            this.Controls.Add(this.lblOtoparkAdı);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label lblOtoparkAdı;
        private System.Windows.Forms.Label lblOtoparkKapasitesi;
        private System.Windows.Forms.TextBox txtOtoparkAdı;
        private System.Windows.Forms.TextBox txtOtoparkKapasitesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.CheckBox chkAracTipi;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.Button btnKalanKapasite;
        private System.Windows.Forms.Button btnBakiyeSorgula;
    }
}

