using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarDers2
{
    public partial class sinemaOtomasyon : Form
    {
        public sinemaOtomasyon()
        {
            InitializeComponent();
        }
        sinema salon = null;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string ad = txtSalonAdi.Text;
            int kapasite = Int32.Parse(txtKoltukSayisi.Text);
            sinema salon = new sinema(ad,kapasite);
            MessageBox.Show("Sinema oluşturuldu.","sinema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnOlustur.Enabled = false;
            btnsatis.Enabled = true;
            btniade.Enabled = true;
            btnBakiye.Enabled = true;
            btnbosKoltuk.Enabled = true;
        }
        private void btnsatis_Click(object sender, EventArgs e)
        {
            bool indirimliMi = chkboxindirim.Checked;
            salon.Biletsat(indirimliMi);
            lblinfo.Text = "Bilet satıldı. Kalan Koltuk sayısı:" + txtKoltukSayisi;
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            bool indirimlimi = chkboxindirim.Checked;
            salon.Biletiade(indirimlimi);
            lblinfo.Text = "Bilet İade Edildi.Kalan koltuk sayısı:"+txtKoltukSayisi;
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            double bakiye = salon.BakiyeOgren();
            lblinfo.Text = "Güncel Bakiye"+bakiye;
        }

        private void btnbosKoltuk_Click(object sender, EventArgs e)
        {
            int boskoltuk = salon.BoskoltukOgren();
            lblinfo.Text = "Boş koltuk sayısı: " + boskoltuk;
        }

        private void sinemaOtomasyon_Load(object sender, EventArgs e)
        {

        }
    }
}
