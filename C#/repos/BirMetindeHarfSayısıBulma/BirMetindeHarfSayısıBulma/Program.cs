using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirMetindeHarfSayısıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            // kaç karakterin harf olduğu, kaç karakterin rakam ve kaç özel karakterin olduğu programı yazınız.
            string metin;
            int karakterSayısı = 0, harfSayısı = 0, rakamSayısı = 0, ozelHarfSayısı = 0;
            Console.WriteLine("**********************************************************");
            Console.WriteLine("********************************************************");
            Console.Write("girmek istediginiz paragrafı yazınız.");
            metin = Console.ReadLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");
            

            char[] array = metin.ToCharArray();
            foreach (var item in array)
            {
                if (char.IsDigit(item))
                {
                    rakamSayısı++;
                }
                if (char.IsLetter(item))
                {
                    harfSayısı++;
                }
                if (!char.IsLetterOrDigit(item))
                {
                    ozelHarfSayısı++;
                }
                karakterSayısı++;
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Girilen metin :" + metin);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("girilen karakter sayısı:" + karakterSayısı);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("girilen rakam sayısı:" + rakamSayısı);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("girilen harf sayısı:" + harfSayısı);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("girilen ozel harf sayısı:" + ozelHarfSayısı);
            Console.WriteLine("-------------------------------------------------------");
            Console.ReadLine();
        }

    }
}
