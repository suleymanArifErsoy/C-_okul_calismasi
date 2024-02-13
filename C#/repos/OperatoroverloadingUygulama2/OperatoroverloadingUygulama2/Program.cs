using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoroverloadingUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {

            persenol p1 = new persenol();
            p1.maas = 9500;
            persenol p2 = new persenol();
            p2.maas = 4500;
            persenol toplamMaas = new persenol();
            toplamMaas = p1 + p2;
            Console.WriteLine(toplamMaas.maas);
            Console.ReadLine();
            return;
            Box[] dizi = new Box[4];
            dizi[0] = new Box();
            dizi[0].width = 5;
            dizi[0].height = 10;
            dizi[1] = new Box();
            dizi[1].width = 10;
            dizi[1].height = 6;
            dizi[2] = new Box();
            dizi[2].width = 5;
            dizi[2].height = 5;
            dizi[3] = new Box();
            dizi[3].width = 11;
            dizi[3].height = 5;
            Box d = new Box();
            for (int i = 0; i < dizi.Length; i++)
            {
                d += dizi[i];
            }
            Console.WriteLine(d.height);
            Console.WriteLine(d.width);
            for (int i = 0; i < dizi.Length; i++)
            {
                d *= dizi[i];
            }
            Console.WriteLine(d.height);
            Console.WriteLine(d.width);
            Console.ReadLine();
        }
    }
}
