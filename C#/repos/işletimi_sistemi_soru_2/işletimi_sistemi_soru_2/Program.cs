using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace işletimi_sistemi_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Boyutu 10.000 olan bir int Fat32 dizimiz var.Bu dizi bir fat32 sistemine bakmaktadır. 0 boş değeri işaret etmektedir.
             ve End of File değeri 4.000.000.000 'dır. Buna göre en uzun dosyayı bulunuz. 
             (En uzun bir adet dosya oldugu varsayılmaktadir.)
             */

            uint[] fat32 = new uint[10000];
            uint eof = 4000000000; // int 2.000.000.000 'a kadar deger almaktadir. Bunu yerine uint kullandık.
            int uzunluk = 0;
            int enBuyukUzunluk = 0;
            for (int i = 0; i < fat32.Length; i++)
            {
                if (fat32[i] == 0)
                {
                    // bos degeri işaret ediyor uzunluk olarak sayılmayacak ya da dosya bozuk olarak mı kabul ediliyor??
                    // bozuk olarak kabul edildigi için uzunluk degerini sifirlaycak mıyız??
                    uzunluk = 0;
                }
                else if (fat32[i] == eof) // dosya sonuna gelinir ve daha önceki dosya sonundaki uzunluk ile kıyaslama yapılır.
                {
                    if (enBuyukUzunluk < uzunluk)
                    {
                        enBuyukUzunluk = uzunluk;
                        uzunluk = 0;
                    }
                }
                else if (fat32[i] == 1) // dosya icerisindeki clusterlar 1 ile işaretlendiyseler dolu oldugu anlamına geliyor.
                {
                    uzunluk++;
                }
            }
            Console.WriteLine($" En Buyuk dosya uzunlugu {enBuyukUzunluk}");
            
        }
    }
}
