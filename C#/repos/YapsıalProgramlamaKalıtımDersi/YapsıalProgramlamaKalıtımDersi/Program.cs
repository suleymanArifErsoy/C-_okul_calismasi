using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapsıalProgramlamaKalıtımDersi
{
    class Program
    {
        static void Main(string[] args)
        {

            İnsan insan1 = new İnsan();
            insan1.Ad = "hasan";
            insan1.Soyad = "yılamz";

            Personel personel1 = new Personel();
            personel1.Ad = "Ali";
            personel1.Soyad = "Veli";
            personel1.maas = 8000;
            personel1.çalısmaSaati = "6";

        }
    }
}
