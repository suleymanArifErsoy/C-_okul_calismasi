using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUyglulamsı
{
    public class Personel
    {
        public static string domainadres;
        public string isim { get; set; }
        public int cinsiyet { get; set; }
        public string soyisim { get; set; }

        private string _emailadres;
        public string EmailAdres
        {
            get 
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainadres; 
            }
        }

        public Personel() 
        {
            Console.WriteLine("Her orneklemede calısan metot. "); 
        }
        // Static yapcıcı metot standart yapıcı metoda göre daha once calısır.
        
        static Personel()
        {
            domainadres = "firmam.com";
        }   
    }
}
