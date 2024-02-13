using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class ogrenci
    {
        public int id { get; set; }
        public int ogrenciId { get; set; }
        public string ogrenciAd { get; set; }
        public string ogrenciSoyad { get; set; }
        public DateTime dogumTarihi  { get; set; }
        public DateTime kayıtTariih  { get; set; }
        public int ogrenciNo { get; set; }
        public string  tcNo { get; set; }
        public Akademikpersonel danısman { get; set; }
        public iletisim[] iletişimBilgileri { get; set; }
        public  Dersler[] dersler { get; set; }

    }
}
