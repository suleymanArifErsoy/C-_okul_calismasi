using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Otopark otopark1 = null;  
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtOtoparkAdı.Text== "")
            {
                MessageBox.Show("Otopark Adı Zorunludur.");
                return;
            }
            //Int32.Parse --> Çevirmeye çalışıyor çeviremezse hata alıyor.
            //Int32.TryParse --> Çevirmeye çalışır çeviremezse varsayılan bir değer atar.
            //Hata almamızı engeller.
            string a = "123";
            int kapasiteVarsayilanDeger = 20;
            bool cevirmeSonucu = Int32.TryParse(a, out kapasiteVarsayilanDeger);
            //cevirmeSonucu == true cevirme Basarılı - 100 , 10 vb. değer girilirse
            //cevirmeSonucu == false cevirme Basarisiz  - abc melih gibi string bir ifade girilirse 

            if (cevirmeSonucu==false)
            {
                MessageBox.Show("Kapasite integer bir değer almak zorundadır.");
                return;
            }
            MessageBox.Show(otopark1.ToString(); 

            otopark1 = new Otopark(txtOtoparkAdı.Text,kapasiteVarsayilanDeger);
            MessageBox.Show("Otopark oluşturuldu.");

            btnOlustur.Enabled = false;
            btnIade.Enabled = true;
            btnKalanKapasite.Enabled = true;
            btnBakiyeSorgula.Enabled = true;
            btnSatis.Enabled = true;
            chkAracTipi.Enabled = true;

        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (otopark1.KalanYerSayisii() == 0)
            {
                MessageBox.Show("Otoparkımız Boş alan Kalmamıştır.");
                return;
            }
            otopark1.BiletSatis(chkAracTipi.Checked);
            lbl_info.Text = "Bilet Satıldı. Kalan Yer Sayısı: " + otopark1.KalanYerSayisii();
        }

        private void btnKalanKapasite_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "Güncel Kalan Yer: " + otopark1.KalanYerSayisii();

        }

        private void btnBakiyeSorgula_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "Güncel Bakiye: " + otopark1.bakiyeSorugula();
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (otopark1.KalanYerSayisii()==Int32.Parse(txtOtoparkKapasitesi.Text))
            {
                MessageBox.Show("Otoparkda Araç Bulunmamaktadır. İade Yapılamaz.");
                return;
            }
            otopark1.BiletIade(chkAracTipi.Checked);
            lbl_info.Text="Bilet İade Edildi. Kalan Yer Sayısı: " + otopark1.KalanYerSayisii();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
