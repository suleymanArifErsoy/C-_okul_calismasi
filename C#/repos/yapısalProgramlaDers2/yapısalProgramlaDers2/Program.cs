using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapısalProgramlaDers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil o1 = new Otomobil("mercedes","e200",false);
            Otomobil o2 = new Otomobil("renault","clıo","06-DD-61",2015,false,false,75.000,200.000);
            Console.WriteLine("{0}--{1}--{2}--{3}--{4}--{5}",o2.Marka,o2.Model,o2.Plaka,o2.km,o2.TramerVarmı,o2.Sıfırmı);
            Otomobil arac2 = new Otomobil();
            arac2.Marka = Marka.mercedes;
        }
    }
}
