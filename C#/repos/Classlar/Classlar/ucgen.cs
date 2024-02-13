using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class ucgen
    {
        public double tabanBoyu { get; set; }
        public double yukseklik  { get; set; }
        public double ilkkenar { get; set; }
        public double ikincikenar { get; set; }
        public double ucuncukenar { get; set; }

        public double ucgenAlanHesabı()
        {
            double sonuc = 0;
            sonuc = (tabanBoyu * yukseklik) / 2;
            return sonuc;
        }
        public double ucgenCevreHesabı()
        {
            double sonuc = 0;
            sonuc = ilkkenar + ikincikenar + ucuncukenar;
            return sonuc;
        }
    }
}
