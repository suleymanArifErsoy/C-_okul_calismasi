using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraAsırıYuklenme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); /*Consol.Writline'nın üzerine geldiğimizde 1of19 yazısını görürüz
                                 /*Bu yazı bize Console Sınıfının 19 tane farklı kullanısı oldugunu gosterir.
                                 */
            Topla(12,10);
        }
        static void Topla(int sayı1,int sayı2)
        {
            int Toplam;
            Toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam: " + Toplam);
        }
        static void Topla(Decimal sayı1, decimal sayı2)
        {
            decimal Toplam;
            Toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam1:" + Toplam);
        }
        static void Topla(string metin1, string metin2)
        {
            string Toplam;
            Console.WriteLine(metin1 + " " + metin2);
        }

    }
}
