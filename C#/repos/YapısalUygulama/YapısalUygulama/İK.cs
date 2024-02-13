using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalUygulama
{
    class İK
    {
        public Personel Yonetici { get; set; }
        public Personel[] TopluOdeme_ { get; set; }
        public void OdemeYap(Personel per)
        {
            Console.WriteLine( "Adı: {0}    Maaş: {1}",per.Ad,per.Maas);
        }
        public void ZamYap(Personel per,decimal zam)
        {
            decimal sonMaas =(per.Maas + zam);
            Console.WriteLine("Yapılan zam:{0}   Maas Durumu={1}",zam,sonMaas);
        }
        public void TopluOdeme(Personel[] per)
        {
            for (int i = 0; i < per.Length; i++)
            {
                Console.WriteLine("Ad:{0}   Soyad:{1}  Maas:{2}",per[i].Ad,per[i].Soyad,per[i].Maas);
                Console.WriteLine("Odemeniz Yapıldı.");
            }
        }
        public void personelYazdır(Personel[] per)
        {
            foreach (var item in per)
            {
                Console.WriteLine("Ad:{0,5}   Soyad:{1,5}  Id={2,5}  SicilNo={3,5}  Maas={4,5}  departman={5,5} "+
                    "",item.Ad,item.Soyad,item.id,item.SicilNo,item.Maas,item.departman);
            }
               
        }
        public İK(Personel _Yonetici)
        {
            this.Yonetici = _Yonetici;
        }
        public İK() { }


    }
}
