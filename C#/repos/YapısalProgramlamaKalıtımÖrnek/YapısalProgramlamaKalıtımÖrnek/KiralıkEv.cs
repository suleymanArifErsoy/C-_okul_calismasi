using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaKalıtımÖrnek
{
    public class KiralıkEv:Ev
    {
        public double KiralıkBedeli { get; set; }
        public double depozito { get; set; }
        public int sözleşmesSuresi { get; set; }
        
        public void kiralikÖzellikGöster()
        {
            Console.WriteLine($"kiralikBedeli:{KiralıkBedeli} depozito:{depozito} sözleşmeSüresi:{sözleşmesSuresi}");     
        }

    }
}
