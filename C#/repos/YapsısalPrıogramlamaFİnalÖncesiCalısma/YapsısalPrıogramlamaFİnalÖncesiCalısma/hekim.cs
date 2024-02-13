using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapsısalPrıogramlamaFİnalÖncesiCalısma
{
    class hekim:insan
    {
        public hekim(string _hekimDiplomaNo, string ad, double _hayatSigortasi) : base(ad, _hayatSigortasi)
        {
            this.HekimDiplomaNo = _hekimDiplomaNo;
        }

        public string HekimDiplomaNo { get; set; }
        public string kurumSicilNo { get; set; }
        public string personelUnvan { get; set; }
        public string AnaBilimDali { get; set; }
        public int Maas { get; set; }
        public int donerSermaye { get; set; }
        
        public double ToplmaÖdemeHesapla()
        {
            int toplamodeme = 0;
            return toplamodeme = Maas + donerSermaye;
        }
        public string HekimDetay(double toplamOdeme)
        {
            return $"Ad:{ad} {soyad} toplam Ödeme: {toplamOdeme}" +
                $"Ana Bilim Dali: {AnaBilimDali}";
        }

        
        public override string yasamDetayı()
        {
            return $"Hekim: {ad} {soyad} sigorta:{ToplmaÖdemeHesapla()+hayatSigortasi}";
        }

        public static int operator -(hekim h1,hekim h2)
        {
            int sermaye = h1.donerSermaye - h2.donerSermaye;
            if (sermaye<0) { sermaye = sermaye * (-1); }
          
            return sermaye;
        }


    }
}
