using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaKalıtımÖrnek
{
    public class SatılıkEv:Ev
    {
        public decimal Fiyat { get; set; }
        public string emlakçı { get; set; }
        
        public void SatilikEvGoster()
        {
            Console.WriteLine($"Fiyat:{Fiyat} emlakçı:{emlakçı}");
        }

    }
}
