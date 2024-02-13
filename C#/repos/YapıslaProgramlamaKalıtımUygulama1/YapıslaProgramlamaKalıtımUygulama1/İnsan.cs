using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıslaProgramlamaKalıtımUygulama1
{
    class İnsan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public string isimYazdır()
        {
            return $"Ad: {Ad} Soyad :{Soyad} Yaş: {Yas}";
        }
    }
}
