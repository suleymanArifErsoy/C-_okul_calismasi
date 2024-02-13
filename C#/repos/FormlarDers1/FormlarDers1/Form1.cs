using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarDers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kullanıcıAdı_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            // kullanıcı Adı=admin
            // şifre=admin
            string username = txtkullaniciAdi.Text;
            string pasaword = txtsifre.Text;

            if (username=="admin" & pasaword=="admin")
            {
                lblSonuc.Text = "Gİriş Başarılı";
            }
            else
            {
                lblSonuc.Text = "Giriş Başarısız";
            }
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
