using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapsıalProgramlamaKalıtımDersi
{
    class Ogrenci:İnsan //sealed class ogrenci => sealed anahatar kelimesi var ise kalıtım yapılamaz 
    {
        public string  okulAdı { get; set; }
        public bool  bursMuKrediMi { get; set; }
        public string dersAdi { get; set; }
        public int dersSaati { get; set; }
        public int alınanDersKredisi { get; set; }
        public int ogrNo { get; set; }
    }
}
