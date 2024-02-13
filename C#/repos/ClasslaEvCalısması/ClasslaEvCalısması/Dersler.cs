using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslaEvCalısması
{
    class Dersler
    {
        public int id { get; set; }
        public string dersAdi { get; set; }
        public int AKTS { get; set; }
        public int kredi { get; set; }
        public int yıl { get; set; }
        public string donem { get; set; }
        public string dersKodu { get; set; }
        public AkademikPersonel dersiveren { get; set; }
    }
}
