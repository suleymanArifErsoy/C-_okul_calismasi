using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaKalıtımÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlem Yapmak istediginiz ev türü");
            string EvTipi=Console.ReadLine();
            if (EvTipi.Equals("Satılık"))
            {
                SatılıkEv ev1 = new SatılıkEv();
                ev1.il = "Ankara";
                ev1.ilçe = "Altındağ";
                ev1.OdaSayısı = 4;
                ev1.ısınma = "Merkezi";
                ev1.emlakçı = "MErkez emlak";
                ev1.Fiyat = 450000000;
                ev1.SatilikEvGoster();
                ev1.özelliklGöster();
            }
            else if (EvTipi.Equals("Kirakik"))
            {
                KiralıkEv kiralık1 = new KiralıkEv();
                kiralık1.il = "Kırıkkale";
                kiralık1.ilçe = "Merkez";
                kiralık1.Adres = "Adres Temp";
                kiralık1.OdaSayısı = 5;
                kiralık1.KiralıkBedeli = 3500;
                kiralık1.ısınma = "Merkezi";
                kiralık1.depozito = 10000;

                kiralık1.kiralikÖzellikGöster();
                kiralık1.özelliklGöster();
            }
            else
            {
                Console.WriteLine("Yanlış giriş yapıldı.");
            }

           


        }
    }
}
