using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri("Ali", "Atilla");  //Musteri parantezi icerisine musteri sınıfında yapmış oldugumuz 4 yapıcı metottan birirni secmemiz icin bize 1'den 4 kadar indeksleri sıralar.
                                                        //sectigimiz indekse göre ne yazacagımızı görürüz ve ilk değeri 0 veya null olarak girmez ve bizim girdiğimiz deger ilk deger olarak gözukur.
            M1.TcKimlikNumarası = "12345678910";
            M1.İsim = "Süleyman";
            M1.soyisim = "Ersoy";
            M1.Cinsiyet = 71777001;
            Musteri M2 = M1;

            M2.İsim = "Arif";
            M1.soyisim = "Yılmaz";

            M1 = null;
            M2 = null;

           // string isim = M1.İsim;  /*Bu kod parcacıgında bir hata alırız.
                  // Hatanın sebebi de M1 sınıfının ramdaki kayıtı düşer ve o değerlere ulaşamayız.(M2 yazsaydık yine aynısı olurdu
                                     

            Arac A1 = new Arac("Renault",2010,"Clio",21000);
            A1.Aracalisfiyati = 75000;
            A1.Aracsatısfiyati = 81000;
            A1.Aracmaxindirimtutari = 4000;
            //A1.fiyat= kapsülleme Konusu....
            A1.FiyatAta(80000);
            A1.Bilgilerigoruntule();
        }
    }
}
