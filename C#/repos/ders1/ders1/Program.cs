using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk 50 asal sayıyı ekrana yazdıran programı yazınız.

            int sayac = 0;
            int sayac2 = 0;
            int sayac3 = 0;
            int sayı = 2;
            Console.WriteLine("**************************************İLK 50 ASAL SAYI*********************************");
            Console.WriteLine("=======================================================================================");

            while (true)
            {
                sayac = 0;
                if (sayac2==50)
                {
                    break;
                }
                  for (int i = 2; i < sayı; i++)
                 {
                    if (sayı%i==0)
                    {
                        sayac++;
                        break;
                    }
                 }
                if (sayac==0)
                {
                    sayac3++;
                    Console.Write(sayı + "\t");
                    if (sayac3%10==0)
                    {
                        Console.WriteLine();
                    }
                    sayac2++;
                }
                sayı++;
            }
            Console.ReadKey();
        }
    }
}
