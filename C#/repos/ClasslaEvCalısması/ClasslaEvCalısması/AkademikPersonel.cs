using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslaEvCalısması
{
    class AkademikPersonel
    {
        public int id { get; set; }
        public string sicilNo { get; set; }
        public string personelAdi { get; set; }
        public string personelSoyadi { get; set; }
        public string personelTc { get; set; }
        public İletisim iletisimBilgisi { get; set; }
        public Unvan akademikUnvan { get ; set;}
    }
}
