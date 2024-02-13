using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapsısalPrıogramlamaFİnalÖncesiCalısma
{
    class personel:insan
    {
        public personel(string _ad, double _hayatSigortasi) : base(_ad, _hayatSigortasi)
        {
        }
        public string kurumSicilNo { get; set; }
        public string KurumAdi { get; set; }
        public string KurumAdresi { get; set; }
        public string PersonelUnvan { get; set; }

        

        public override string ToString()
        {
            return $"personel: {ad} {soyad}. Kurum Sicil No: {kurumSicilNo} ";
        }

    }
}
