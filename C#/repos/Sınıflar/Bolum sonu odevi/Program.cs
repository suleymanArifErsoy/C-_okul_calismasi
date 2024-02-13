using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bolum_sonu_odevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1 ;
            M1.isim = "suleyman";
            M1.soyisim = "ersoy";
            M1.kullaniciadi = "Sulo61";
            M1.emailAdres = "s.arifersoy61@gmail.com";
            M1.şifre = "123";

            Musteri.MusteriEkle(M1);


            Musteri M2 = new Musteri();
            M2.musteriID = 3;
            M2.isim = "mehmet";
            M2.soyisim = "yılmaz";
            M2.kullaniciadi = "mehmet.yılmaz";
            M2.emailAdres = "firmam.@gmail.com";
            M2.şifre = "a75e95";

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri() // hızlı nesne ogrekleme!!
            { 
                 musteriID=33,
                  isim="veli",
                   soyisim="kavlak",
                    kullaniciadi="veli.61kavlak",
                     emailAdres="s.arifersoy61@gmail.com",
                      şifre="12345",
            };
            Musteri.MusteriEkle(M3);



        }
    }
}
