using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayinin basamaklarini toplamini bulan programlama vee girilen sayıyı tersten yazmak

            int sonuc = 0;
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            while(sayi>9)
            {
                sonuc = (sayi % 10);
                sayi = sayi / 10;
                Console.Write(sonuc);
            }
            while(sayi>0)
            {
                toplam += (sayi % 10);
                sayi = sayi / 10;
            }
            Console.WriteLine("girdiginiz sayinin rakamlari toplami: "+toplam);
            Console.ReadLine();

        }
    }
}
