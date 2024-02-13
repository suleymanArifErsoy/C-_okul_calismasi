using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotödev1 
{
     public class Ogrenci
    {
        public void Ogrencinothesapla(String Ad, String Soyad, Decimal Not1, Decimal Not2, Decimal Not3)
        {
            {
                Console.WriteLine("Öğrencinin bilgileri asagiadaki gibidir.");

                Console.Write("Ad Soyad: {0} {1}", Ad, Soyad);
                Console.Write(" Not1 : " + Not1);
                Console.Write(" Not2: " + Not2);
                Console.Write(" Not3: " + Not3);
                Decimal Ortalama = (Not1 + Not2 + Not3) / 3;
                if (Ortalama <= 45)
                {
                    Console.Write("Ortalama: {0} - Kaldınız", Ortalama);
                }
                else
                {
                    Console.Write(" Ortalama: {0} - Geçtiniz", Ortalama);
                }
            }
        }
    }
}
