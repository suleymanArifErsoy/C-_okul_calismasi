using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Bolum_sonu_odevi
{
    public class Musteri
    {
        #region Sanal Database  
        static ArrayList musteriDatabase;
        #endregion
        #region Static Yapıcı Metot
        public Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion
        #region Field
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string  soyisim { get; set; }
        public string emailAdres { get; set; }
        public string şifre { get; set; }
        #endregion
        #region Kapsulleme
        private string _kullaniciadi;
        public string kullaniciadi
        {
            get {return this._kullaniciadi; }
            set
            {
                bool kullanıcıadikontrol = MusteriKullaniciAdiKontrol(value);
                if (kullanıcıadikontrol)
                {
                    Console.WriteLine("Eklemek istediginiz kullanıcı adı daha önceden eklenmiştir.");
                    this._kullaniciadi = string.Empty;
                }
                else
                {
                    this._kullaniciadi= value;
                }
            }

        }
        #endregion
        #region Static metotlar 
        static bool MusteriKullaniciAdiKontrol(string _kullaniciadi)
        {
            bool kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.kullaniciadi==_kullaniciadi)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
        public static void MusteriEkle(Musteri M)
        {
            #region Parametre Konrtol 
            if (M !=null && !string.IsNullOrEmpty(M.kullaniciadi) && string.IsNullOrEmpty(M.emailAdres)) 
            {
                bool emailAdresKontrol = MusteriEmailAdresKontrol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz email adres sistemde kayıtlı.");
                }
                else
                {
                    musteriDatabase.Add(M);
                }

            }
            #endregion
        }
        static bool MusteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.emailAdres==_emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }
        #endregion
    }
}
