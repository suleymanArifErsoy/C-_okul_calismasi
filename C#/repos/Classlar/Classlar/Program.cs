using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region unvanlar
            Unvan unvan1 = new Unvan();
            unvan1.id = 1;
            unvan1.unvanVeri = "profesor";
            unvan1.akademimi = true;

            Unvan unvan2 = new Unvan();
            unvan2.id = 2;
            unvan2.unvanVeri = "docent";
            unvan2.akademimi = true;
            #endregion

            #region akademik Personel
            Akademikpersonel apersonol1 = new Akademikpersonel();
            apersonol1.id = 1;
            apersonol1.kurumsicil = "a-1234";
            apersonol1.ad = "ahmet";
            apersonol1.soyad = "test";
            apersonol1.tc = "121125335";
            apersonol1.akdemikUnvan = unvan1;
            #endregion

            #region Dersler
            Dersler dersler1 = new Dersler(1);
            dersler1.id = 1;
            dersler1.derskodu = "Bil101";
            dersler1.AKTS = 6;
            dersler1.yıl = 2022;
            dersler1.kredi = 5;
            dersler1.dersiveren = apersonol1;
            dersler1.donem = "bahar";
            dersler1.dersAdı = "Yapısal programlama";
            Dersler[] derslerDizi = new Dersler[2];
            derslerDizi[0] = dersler1;
            #endregion

            #region İletişim Tipi
            iletisimTipi tip1 = new iletisimTipi();
            tip1.id = 1;
            tip1.veri = "E-posta";

            iletisimTipi tip2 = new iletisimTipi();
            tip2.id = 2;
            tip2.veri = "Adres";
            #endregion

            #region iletisim
            iletisim iletisim1 = new iletisim();
            iletisim1.id = 1;
            iletisim1.veri = "055223584";
            iletisim1.iletisimTipi = tip1;

            iletisim iletisim2 = new iletisim();
            iletisim2.id = 2;
            iletisim2.veri = "ben@akad.com";
            iletisim2.iletisimTipi = tip2;

            iletisim[] iletisimDizi = new iletisim[3];
            iletisimDizi[0] = iletisim1;
            iletisimDizi[1] = iletisim2;
            #endregion
            
            #region ogrenciler
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.id = 1;
            ogrenci1.ogrenciAd = "ali";
            ogrenci1.ogrenciSoyad = "test";
            ogrenci1.ogrenciNo = 200202050;
            ogrenci1.tcNo = "1225556";
            ogrenci1.dogumTarihi = DateTime.Parse("11.11.2002");
            ogrenci1.kayıtTariih = DateTime.Parse("4.10.2020");
            ogrenci1.danısman = apersonol1;
            ogrenci1.iletişimBilgileri = new iletisim[] { iletisim1,iletisim2 };
            Console.WriteLine(ogrenci1.iletişimBilgileri[0]);
            
            ogrenci1.dersler = derslerDizi;
            
            #endregion

            Personel apersonel3 = new Personel();
            apersonel3.akademikUnvan = Unvan2.DrOgrÜyesi;    // Classları boyle olusturmak daha iyi olur 
            Console.WriteLine(apersonel3.akademikUnvan);

            #region dersler metot kullanımı
            Dersler ders1 = new Dersler(1);
            ders1.vizeNotu = 70;
            ders1.finalNotu = 85;
            double ort = ders1.ortalamahesap();
            bool gectimi = ders1.DersGecme();
            #endregion
            Personel per1 = new Personel();
            per1.unvan = Unvan2.Docent;



            #region ucgen alanCevre hesabı 




            #endregion


        }
    }
}
