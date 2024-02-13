using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Arac
    {
        public Arac()
        {

        }
        public Arac(string _model,int _modelyılı,string _marka)
        {
            Aracmarkası = _marka;
            Aracmodeli = _model;
            Aracmodelyılı = _modelyılı;
        }
        public Arac(string _model,string _marka)
        {
            Aracmarkası = _marka;
            Aracmodeli = _model;
        }
        public Arac(string _marka,int _modelyılı,string _model,decimal _KM)
        {
            AracKM = _KM;
            Aracmarkası = _marka;
            Aracmodelyılı = _modelyılı;
            Aracmodeli = _model;
        }
        public string Aracmarkası;
        public string Aracmodeli;
        public int Aracmodelyılı;
        public decimal AracKM;
        public int Aracyakıttipi;
        public int Aracvitestipi;
        public decimal Aracalisfiyati;
        public decimal Aracsatısfiyati;
        public decimal Aracmaxindirimtutari;
        public decimal fiyat;

       public void Bilgilerigoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yıl {2}", Aracmarkası, Aracmodeli, Aracmodelyılı);

        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = Aracsatısfiyati - Aracmaxindirimtutari;
            if (_fiyat<fiyatHesap)
            {
                Console.WriteLine("Gecersiz fiyat girisi yaptınız");
            }
            else
            {
                fiyat =_fiyat   ;
                Console.WriteLine("Fiyat tutarı güncellendi");
            }
        }
    }
}
