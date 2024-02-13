using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Personel
    {
        public string isim { get; set; }
        public string Soyad { get; set; }
        public string akademikUnvan { get; set; }
        public string unvan { get; set; }
        public string hitaphazırlama(Personel personel1)
        {
           
            string hitap = string.Format("sn.{0} {1} {2}" + personel1.akademikUnvan, personel1.isim, personel1.Soyad);
            return hitap;
            
        }

    }
}
