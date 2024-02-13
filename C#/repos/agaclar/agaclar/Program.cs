using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agaclar
{
    class Program
    {
        static void btreeyaz(int a)
        {
            if (a > 15) return;
            btreeyaz(2 * a + 1);
            btreeyaz(2 * a + 2);
            Console.WriteLine(a);

        }
        static void Main(string[] args)
        {
           
            btreeyaz(0);
            Console.ReadKey();
        }
    }
}
