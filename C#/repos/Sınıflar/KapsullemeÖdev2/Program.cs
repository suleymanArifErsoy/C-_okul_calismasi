using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeÖdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ülke devlet1 = new Ülke();
            devlet1.UlkeAd = "Türkiye";
            devlet1.Baskent = "Ankara";
            devlet1.Nufus = 70000000;
            devlet1.ParaBirimi = "TL";
            devlet1.Yazdır();


            Ülke devlet2 = new Ülke();
            devlet2.UlkeAd = "İngiltere";
            devlet2.Baskent = "Berlin";
            devlet2.Nufus = 45000000;
            devlet2.ParaBirimi = "İnghiliz Sterlini";
            devlet2.Yazdır();
            Console.ReadLine();
        }
    }
}
