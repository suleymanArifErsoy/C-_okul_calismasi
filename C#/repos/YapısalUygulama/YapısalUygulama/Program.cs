using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Departman Tanımlama
            Departman dep1 = new Departman();
            dep1.id = 1;
            dep1.Ad = "Ar-Ge";
            Departman dep2 = new Departman();
            dep2.id = 2;
            dep2.Ad = "Satış Uzmanı";
            Departman dep3 = new Departman();
            dep2.id = 3;
            dep3.Ad = "Halkla ilişkiler";
            Departman dep4 = new Departman();
            dep4.id = 4;
            dep4.Ad = "Muhasebe";
            #endregion

            #region personel Tanımlama
            Personel per1 = new Personel();
            per1.Ad = "Suleyman";
            per1.Soyad = "Ersoy";
            per1.id = 1;
            per1.Maas = 7500;
            per1.SicilNo = "B-1542";
            per1.departman = dep1;
            Personel per2 = new Personel();
            per2.Ad = "Mehmet";
            per2.Soyad = "Yılmaz";
            per2.id = 2;
            per2.Maas = 6400;
            per2.SicilNo = "Hİ-1245";
            per2.departman = dep3;
            #endregion


            #region İK Tanımlama
            Personel[] perdizi = new Personel[2];
            perdizi[0] = per1;
            perdizi[1] = per2;
            İK ik1 = new İK();
            ik1.Yonetici = per1;
            ik1.ZamYap(per1, 1500);
            ik1.OdemeYap(per2);
            ik1.personelYazdır(perdizi);
            ik1.TopluOdeme(perdizi);
            #endregion
            İK per4 = new İK(per1);
        }
    }
}
