using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionUygulamadersi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int sayi1;
        int sayi2;
        double sonuc;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Int32.Parse(txtsayi1.Text);
                sayi2 = Int32.Parse(txtsayi2.Text);
                
            }
            catch(FormatException ex )
            {
                MessageBox.Show("Hata: "+ ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }



        }

        private void btncıkarma_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Int32.Parse(txtsayi1.Text);
                sayi2 = Int32.Parse(txtsayi2.Text);
                sonuc = sayi1 + sayi2;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }

            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Int32.Parse(txtsayi1.Text);
                sayi2 = Int32.Parse(txtsayi2.Text);
                sonuc = sayi1 / sayi2;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Hata: " + ex);
                return;
            }
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Int32.Parse(txtsayi1.Text);
                sayi2 = Int32.Parse(txtsayi2.Text);
                sonuc = sayi1 * sayi2;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hata: "+ex.Message);
                return;
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Int32.Parse(txtsayi1.Text);
                sayi2 = Int32.Parse(txtsayi2.Text);
                sonuc = sayi1 + sayi2;    
            }
            catch(FormatException)
            {
                MessageBox.Show("Girdiginiz veri sayi belirtmesi gerekir.");
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Gİrilecek bölüm boş bırakılamaz!!");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Girilen verilerin toplamı sınırı taşmıstır.!");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
            finally
            {
                txtsayi1.Clear();
                txtsayi2.Clear();
            }

        }

        private void txtsayi2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
