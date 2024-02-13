using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotödev1
{
     static class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAd = string.Empty;
            string ogrenciSoyad = string.Empty;
            Decimal Not1 = 0;
            Decimal Not2 = 0;
            Decimal Not3 = 0;
            Decimal Ortalama = 0;
            
            Console.WriteLine("Merhaba girmek istediğiniz öğrencinin bilgilerini giriniz.");

            Console.Write("Ad: ");
            ogrenciAd = Console.ReadLine();

            Console.Write("Soyad:" );
            ogrenciSoyad = Console.ReadLine();

            Console.Write("Not1: " );
            Not1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Not2:" );
            Not2 = Decimal.Parse(Console.ReadLine());

            Console.Write("Not3:" );
            Not3 = Decimal.Parse(Console.ReadLine());

            Ogrenci o = new Ogrenci();
            o.Ogrencinothesapla(ogrenciAd, ogrenciSoyad, Not1, Not2, Not3);
            
        }
    }
}
    
