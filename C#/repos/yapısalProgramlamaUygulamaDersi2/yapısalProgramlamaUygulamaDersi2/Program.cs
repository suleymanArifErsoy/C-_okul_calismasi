using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapısalProgramlamaUygulamaDersi2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Uygulama
            Personel per1 = new Personel("Süleyman","Ersoy",5000);
            per1.id = 1;

            Personel per2 = new Personel();
            per2.Ad = "Mehmet";
            per2.Soyad = "Ersoy";
            per2.id = 2;
            per2.Maas = 7500;

            Personel per3 = new Personel(3);
            per3.Ad = "yusuf";
            per3.Soyad = "yılmaz";
            per3.Maas = 6500;
            per3.id = 4;
            #endregion
        }
    }
}
