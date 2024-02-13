using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_HataYönetimi_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //Önemli  Fİnally bolumu SINAVDA cıkabilir.
            try
            {
                //hata ihtimali
                string veri = textBox1.Text;
                int sonuc = Int32.Parse(veri);
                string veri2 = textBox2.Text;
                int sonuc2 = Int32.Parse(veri2);
                int toplam = sonuc + sonuc2;
                MessageBox.Show("toplam sonucu: "+toplam);
            }
            catch (FormatException)
            {
                //Birden fazla hata türüne sahip olabilir.
                MessageBox.Show("Girilen veri Dogru formatta değil.");
                return;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Girilen deger sınır dısındadır.");
                return;
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
                return;
            }
            catch(ArrayTypeMismatchException ex)
            {
                MessageBox.Show("Hata: "+ ex.Message);
                return;
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
            catch(StackOverflowException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (Exception ex)
            {
                // ex exception sınıfının bir nesnesidir.
                MessageBox.Show("Genel Hata: "+ex.Message);
                return;
            }
            
            finally
            {
                //hata olsa da olmasada çalısır.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperatorOverLoading b1 = new OperatorOverLoading();
            b1.setWidth(1);
            b1.setLength(4);
            b1.setHeight(6);
            double sonuc = b1.getvolume();
            MessageBox.Show("1-Hacim: " + sonuc);

            OperatorOverLoading b2 = new OperatorOverLoading();
            b2.setWidth(2);
            b2.setLength(5);
            b2.setHeight(4);
            double sonuc2 = b2.getvolume();
            MessageBox.Show("2-Hacim= " + sonuc2);



        }
    }
}
