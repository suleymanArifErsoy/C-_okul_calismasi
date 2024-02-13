using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUyglulamsı
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel o1 = new Personel();
            o1.isim = "Süleyman";
            o1.soyisim = "Ersoy";
            o1.cinsiyet = 717770001; //Bay     Bayan=717770002

            Helper.emailGönder("s.arif@gmail.com", "proje ile ilgili", "Süleyman arif ersoy");

        }
    }
}
