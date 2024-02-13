using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaKalıtımÖrnek
{
    public class Ev
    {
        public string il { get; set; }
        public string ilçe { get; set; }
        public string Adres { get; set; }
        public int OdaSayısı { get; set; }
        public string ısınma { get; set; }
        
        public void özelliklGöster()
        {
            Console.WriteLine($"Evin Ozellikleri"+
                              $"il:{il} İlçe: {ilçe} Adres: {Adres} OdaSayısı:{OdaSayısı} Isınma:{ısınma}");

        }
    }
}
