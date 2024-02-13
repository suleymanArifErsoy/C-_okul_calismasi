
namespace ExceptionUygulamadersi1
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
            this.components = new System.ComponentModel.Container();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btncıkarma = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.lbltoplasonuc = new System.Windows.Forms.Label();
            this.lblçarpımSonuc = new System.Windows.Forms.Label();
            this.lblBölmesonuc = new System.Windows.Forms.Label();
            this.lblCıkarmasonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(60, 93);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(60, 178);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 0;
            this.txtsayi2.TextChanged += new System.EventHandler(this.txtsayi2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölme   :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çarpım  :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Çıkarma :";
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Location = new System.Drawing.Point(57, 64);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(33, 13);
            this.lblsayi1.TabIndex = 5;
            this.lblsayi1.Text = "Sayi1";
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(57, 151);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(33, 13);
            this.lblsayi2.TabIndex = 6;
            this.lblsayi2.Text = "Sayi2";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(522, 178);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(123, 85);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(60, 240);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 8;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btncıkarma
            // 
            this.btncıkarma.Location = new System.Drawing.Point(380, 240);
            this.btncıkarma.Name = "btncıkarma";
            this.btncıkarma.Size = new System.Drawing.Size(75, 23);
            this.btncıkarma.TabIndex = 8;
            this.btncıkarma.Text = "Çıkarma";
            this.btncıkarma.UseVisualStyleBackColor = true;
            this.btncıkarma.Click += new System.EventHandler(this.btncıkarma_Click);
            // 
            // btnBölme
            // 
            this.btnBölme.Location = new System.Drawing.Point(270, 240);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(75, 23);
            this.btnBölme.TabIndex = 8;
            this.btnBölme.Text = "Bölme";
            this.btnBölme.UseVisualStyleBackColor = true;
            this.btnBölme.Click += new System.EventHandler(this.btnBölme_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Location = new System.Drawing.Point(165, 240);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(75, 23);
            this.btncarpma.TabIndex = 8;
            this.btncarpma.Text = "Çarpma";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // lbltoplasonuc
            // 
            this.lbltoplasonuc.AutoSize = true;
            this.lbltoplasonuc.Location = new System.Drawing.Point(597, 48);
            this.lbltoplasonuc.Name = "lbltoplasonuc";
            this.lbltoplasonuc.Size = new System.Drawing.Size(0, 13);
            this.lbltoplasonuc.TabIndex = 9;
            // 
            // lblçarpımSonuc
            // 
            this.lblçarpımSonuc.AutoSize = true;
            this.lblçarpımSonuc.Location = new System.Drawing.Point(597, 74);
            this.lblçarpımSonuc.Name = "lblçarpımSonuc";
            this.lblçarpımSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblçarpımSonuc.TabIndex = 9;
            // 
            // lblBölmesonuc
            // 
            this.lblBölmesonuc.AutoSize = true;
            this.lblBölmesonuc.Location = new System.Drawing.Point(597, 100);
            this.lblBölmesonuc.Name = "lblBölmesonuc";
            this.lblBölmesonuc.Size = new System.Drawing.Size(0, 13);
            this.lblBölmesonuc.TabIndex = 9;
            // 
            // lblCıkarmasonuc
            // 
            this.lblCıkarmasonuc.AutoSize = true;
            this.lblCıkarmasonuc.Location = new System.Drawing.Point(597, 128);
            this.lblCıkarmasonuc.Name = "lblCıkarmasonuc";
            this.lblCıkarmasonuc.Size = new System.Drawing.Size(0, 13);
            this.lblCıkarmasonuc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCıkarmasonuc);
            this.Controls.Add(this.lblBölmesonuc);
            this.Controls.Add(this.lblçarpımSonuc);
            this.Controls.Add(this.lbltoplasonuc);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btncıkarma);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblsayi2);
            this.Controls.Add(this.lblsayi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btncıkarma;
        private System.Windows.Forms.Button btnBölme;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Label lbltoplasonuc;
        private System.Windows.Forms.Label lblçarpımSonuc;
        private System.Windows.Forms.Label lblBölmesonuc;
        private System.Windows.Forms.Label lblCıkarmasonuc;
    }
}

