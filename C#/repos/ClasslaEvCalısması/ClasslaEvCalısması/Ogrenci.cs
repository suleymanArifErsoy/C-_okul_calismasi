using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslaEvCalısması
{
    class Ogrenci
    {
        public string ogrenciAdi { get; set; }
        public int id { get; set; }
        public int ogrenciID { get; set; }
        public string ogrenciSoyadı { get; set; }
        public  int ogrenciNo { get; set; }
        public int tcNO { get; set; }
        public DateTime dogumTarihi { get; set; }
        public DateTime girisTarihi { get; set; }
        public Dersler[] dersBilgileri { get; set; }
        public İletisim[] iletisimBilgileri { get; set; }
        public AkademikPersonel danısman { get; set; }
    }
}
