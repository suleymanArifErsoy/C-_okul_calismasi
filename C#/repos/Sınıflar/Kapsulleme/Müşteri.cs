using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Müşteri
    {
        // Class=>Field 
        public Müşteri()
        {
            this.id = IDUret();
        }

        private int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public string isim;
        public string soyisim;

        private string emailAdres;//(Field)

        public string EmailAdres//(Property)
        {
            set { this.emailAdres = value; }//dış dunyadan alınan iceride private olarak saklanan field icerisine deger atandıgı kısım
            get { return this.emailAdres; }//Database veya farklı bir veri kaynagı...Class cagıran programcıya datayı gosterdigimiz kısım...
        }

        private int IDUret()
        {
            Random rnd = new Random();
          return rnd.Next(10000, 90000);
        }
    }
}
