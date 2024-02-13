using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statick_Kavramı
{
    public class Ogrenci
    {
        public string Isim{get ;set;}
        public string soyIsim { get; set ;}
        public string EmailAdres { get; set;}

        public void Test1()
        {
            Console.WriteLine("Nesne ornegi alındıktan sonra calısan metot");
            Test2();// Statik olmayan bir metor static olan bir metodu cagırabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne ornegi ALINMADAN kullanılabilir.");
            //Test1
            // Static olan bir metot static olmayan bir metodu vb... cagıramaz.
        }
    }
}
