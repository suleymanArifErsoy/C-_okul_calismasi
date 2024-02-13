using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapısalProgramlamaUygulamaDersi2
{
    class Personel
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }

        public Personel() { }
        public Personel(int _id)
        {
            this.id = _id;
        }
        public Personel(string _Ad, string _soyad, decimal _Maas)
        {
            this.Ad = _Ad;
            this.Soyad = _soyad;
            this.Maas = _Maas;
        }
        
    }
    
}
