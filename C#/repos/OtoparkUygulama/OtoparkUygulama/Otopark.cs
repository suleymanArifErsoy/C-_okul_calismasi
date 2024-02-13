using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkUygulama
{
    class Otopark
    {
        int toplamAracKapsitesi;
        int bosaracsayisi;
        double bakiye;
        string otoparkAdı;

        const int buyukArac = 50;
        const int kucukArac = 20;

        public Otopark(string p_otoparkAdı, int p_toplamAracKapasitesi)
        {
            this.otoparkAdı = p_otoparkAdı;
            this.toplamAracKapsitesi = p_toplamAracKapasitesi;
            bakiye = 0;
            bosaracsayisi = p_toplamAracKapasitesi;
        }

        public void BiletSatis(bool BuyukAracMı)
        {
            bosaracsayisi--;
            if (BuyukAracMı)
            {
                bakiye += buyukArac;
            }
            else
            {
                bakiye += kucukArac;
            }
        }
        public void BiletIade(bool BuyukAracMı)
        {
            if(bosaracsayisi==toplamAracKapsitesi)
            {
                Console.WriteLine("Otoparkda araç Bulunmuyor.");
                return;
            }
            bosaracsayisi++;
            if (BuyukAracMı)
            {
                bakiye -= buyukArac;
            }
            else
            {
                bakiye -= kucukArac;
            }
        }
        public double bakiyeSorugula()
        {
            return bakiye;
        }
        public int KalanYerSayisii()
        {
            return bosaracsayisi;
        }

        public override string ToString()
        {
            return $"otopark Adı: {otoparkAdı} Fiyat: {buyukArac}";
        }

    }
}
