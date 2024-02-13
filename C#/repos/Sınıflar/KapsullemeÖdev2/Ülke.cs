using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeÖdev2
{
    class Ülke
    {
        private string ulkeAd;
        public string UlkeAd
        {
            get { return this.ulkeAd;}
            set { ulkeAd = value;}
        }

        private string paraBirimi;
        public string ParaBirimi
        {
            get { return this.paraBirimi;}
            set { paraBirimi = value;}
        }
        private string baskent;
        public string Baskent
        {
            get { return this.baskent;}
            set { baskent = value;}
        }
        private int nufus;
        public int Nufus
        {
            get { return this.nufus;}
            set { nufus = value;}
        }
        public void Yazdır()
        {
            Console.WriteLine("Ülke Adı            :" + ulkeAd);
            Console.WriteLine("Başkent             :" + baskent);
            Console.WriteLine("Nüfüs               :" + nufus);
            Console.WriteLine("Para Birimi         :" + paraBirimi);
            Console.WriteLine("=====================================");
        }

    }
}
