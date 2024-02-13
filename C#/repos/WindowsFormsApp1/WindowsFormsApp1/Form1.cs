using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıadi = txtKullanıcıAdı.Text;
            string şifre = txtŞifre.Text;

            if (kullanıcıadi=="admin" && şifre=="123" )
            {

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Bilgileri");
            }
        }   

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
