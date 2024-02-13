using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaSonDers
{
    class Program
    {
        static void Main(string[] args)
        {
            Metal araba1 = new araba();
            string ses=araba1.arabasesi();
            Console.WriteLine(ses);

            Metal araba2 = new marka();
            string ses1=araba2.arabasesi();
            Console.WriteLine(ses1);

            Metal lambo = new lambo();
            string ses2 = lambo.arabasesi();
            Console.WriteLine(ses2);

            Metal metalses = new Metal();
            string ses12 = metalses.arabasesi();
            Console.WriteLine(metalses);
            Console.ReadKey();

        }
    }
}
