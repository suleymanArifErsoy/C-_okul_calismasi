using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapsısalPrıogramlamaFİnalÖncesiCalısma
{
    class insan
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public double hayatSigortasi { get; set; }
        public insan(string _ad,double _hayatSigortasi)
        {
            this.ad = _ad;
            this.hayatSigortasi = _hayatSigortasi;
        }
        public override string ToString()
        {
            return $"Sn:{ad} {soyad}. Dogum Tarihi:{dogumTarihi} ";
        }
        public virtual string yasamDetayı()
        {
            return $"İnsan: {ad} {soyad} {dogumTarihi} sigorta: {hayatSigortasi}";
        }
    }
}
