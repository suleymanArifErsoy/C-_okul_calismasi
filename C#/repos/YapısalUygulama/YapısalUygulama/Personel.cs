using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalUygulama
{
    class Personel
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string SicilNo { get; set; }
        public decimal Maas { get; set; }
        public Departman departman { get; set; }
    }
}
