using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmalar_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bitwise işlemler {and} {or}

            int a;
            a = 0x1245;
            Console.WriteLine(a);

            if ((a & 1) == 1) 
            {
                Console.WriteLine("tek sayi");
            }
            else
            {
                Console.WriteLine("cift sayi");
            }
            Console.Read();


        }
    }
}
