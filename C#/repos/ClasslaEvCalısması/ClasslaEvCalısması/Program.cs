using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslaEvCalısması
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İletisim Tipi
            iletisimTipi iletisimtipi1 = new iletisimTipi();
            iletisimtipi1.id = 1;
            iletisimtipi1.veri = "E-posta";

            iletisimTipi iletisimTipi2 = new iletisimTipi();
            iletisimTipi2.id = 2;
            iletisimTipi2.veri = "Adres";

            iletisimTipi iletisimTipi3 = new iletisimTipi();
            iletisimTipi3.id = 3;
            iletisimTipi3.veri = " Telefon No";
            #endregion
             
            #region İletisim

            İletisim iletisim1 = new İletisim();
            iletisim1.id = 1;
            iletisim1.veri = "05554357412";
            iletisim1.iletisimTipi = iletisimTipi3;

            İletisim iletisim2 = new İletisim();
            iletisim2.id = 2;
            iletisim2.veri = "s.arifersoy@gmail.com";
            iletisim1.iletisimTipi = iletisimtipi1;

            İletisim[] iletisimDizi = new İletisim[3];
            iletisimDizi[0] = iletisim1;
            iletisimDizi[1] = iletisim2;
            #endregion

            #region Unvan
            Unvan unvan1 = new Unvan();
            unvan1.id = 1;
            unvan1.akademikveri = "profesor";
            unvan1.akademikMi = true;

            Unvan unvan2 = new Unvan();
            unvan2.id = 2;
            unvan2.akademikveri = "dr.ogretim uyesi";
            unvan2.akademikMi = true;
            #endregion

            #region Akademik personel
            AkademikPersonel apersonel1 = new AkademikPersonel();
            apersonel1.id = 1;
            apersonel1.personelAdi = "Ahmet";
            apersonel1.personelSoyadi = "demir";
            apersonel1.personelTc = "1231231234";
            apersonel1.sicilNo = "A-3241";
            apersonel1.iletisimBilgisi = iletisim1;
            apersonel1.iletisimBilgisi = iletisim2;
            apersonel1.akademikUnvan = unvan2;

            AkademikPersonel apersonel2 = new AkademikPersonel();
            apersonel2.id = 2;
            apersonel2.personelAdi = "Mahmut";
            apersonel2.personelSoyadi = "Yılmaz";
            apersonel2.personelTc = "45586333210";
            apersonel2.sicilNo = "B-1493";
            apersonel2.akademikUnvan = unvan1;
            apersonel2.iletisimBilgisi = iletisim2;
            #endregion

            #region Dersler
            Dersler ders1 = new Dersler();
            ders1.id = 1;
            ders1.dersAdi = "Nesnelerin İnterneti";
            ders1.dersiveren = apersonel1;
            ders1.dersKodu = "Bİl2003";
            ders1.donem = "Bahar";
            ders1.yıl = 2022;
            ders1.AKTS = 6;
            ders1.kredi = 5;

            Dersler ders2 = new Dersler();
            ders2.id = 2;
            ders2.dersAdi = "Algoritmalar";
            ders2.AKTS = 5;
            ders2.dersKodu = "Bil3002";
            ders2.donem = "bahar";
            ders2.kredi = 6;
            ders2.dersiveren = apersonel2;

            Dersler[] derslerDizi = new Dersler[6];
            derslerDizi[0] = ders1;
            derslerDizi[1] = ders2;
            #endregion

            #region
            Ogrenci ogr1 = new Ogrenci();
            ogr1.id = 10;
            ogr1.ogrenciAdi = "ali";
            ogr1.ogrenciSoyadı= "Kaya";
            ogr1.ogrenciNo = 200205001;
            ogr1.tcNO = 124477388;
            ogr1.ogrenciID = 453;
            ogr1.girisTarihi = DateTime.Parse("24,10,2022");
            ogr1.dogumTarihi = DateTime.Parse("12,05,2001");
            ogr1.dersBilgileri = derslerDizi;
            ogr1.danısman = apersonel2;
            ogr1.iletisimBilgileri =iletisimDizi;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.ogrenciAdi = "melike";
            ogr2.ogrenciSoyadı = "Demirhan";
            ogr2.id = 21;
            ogr2.ogrenciNo = 19005050;
            ogr2.ogrenciID = 111;
            ogr2.danısman = apersonel1;
            ogr2.dersBilgileri = derslerDizi;
            ogr2.dogumTarihi = DateTime.Parse("21,3,2000");
            ogr2.girisTarihi = DateTime.Parse("8,7,2019");
            ogr2.iletisimBilgileri = iletisimDizi;
            ogr2.tcNO = 123984890;
            #endregion



        }
    }
}
