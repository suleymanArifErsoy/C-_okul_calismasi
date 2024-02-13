using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormlarDers2
{
    class sinema
    {
        int toplamKoltukSayisi;
        int koltukSayisi;
        int boskoltuksayisi;
        double bakiye;
        string salonAdi;

        const double Tam = 35;
        const double ogrenci = 25;

        public sinema(string _salonadi,int _koltukSayisi)
        {
            this.salonAdi = _salonadi;
            this.toplamKoltukSayisi = _koltukSayisi;
            bakiye = 0;

        }
        public void Biletsat(bool indirimliMi)
        {
            boskoltuksayisi--;
            if (indirimliMi)
            {
                bakiye += ogrenci;
            }
            else
            {
                bakiye += Tam; 
            }
        }
        public void Biletiade(bool indirimliMi)
        {
            boskoltuksayisi--;
            if (indirimliMi)
            {
                bakiye -= ogrenci;
            }
            else
            {
                bakiye -= Tam;
            }
        }
        public double BakiyeOgren()
        {
            return bakiye;
        }
        public int BoskoltukOgren()
        {
            return boskoltuksayisi;

        }
    }
}
