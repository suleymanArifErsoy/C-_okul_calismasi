using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();


            double volume = 0;
            box1.SetLength(4);
            box1.SetHeight(5);
            box1.Setbreadth(3);


            box2.Setbreadth(4);
            box2.SetHeight(4);
            box2.SetLength(2);

            volume = box1.getVolume();
            Console.WriteLine("Kutu1 Volume: " + volume);

            volume = box2.getVolume();
            Console.WriteLine("Kutu2 Volume: "+ volume);

            box3 = box1 + box2;

            Console.WriteLine("Kutu3 Volume: " + box3.getVolume());
            Console.WriteLine("Box3: {0}" + box3.ToString());


            if (box1 > box2)
            {
                Console.WriteLine("Box1 buyuktur.");
            }
            else
            {
                Console.WriteLine("box2 buyuktur.");
            }

            if (box1 == box2)
            {
                Console.WriteLine("Box1 ve box2 eşittir.");
            }
            else
            {
                Console.WriteLine("eşit degildir.");
            }




            /* OPERATOR OVERLOADİNG 
             * + - ! ++ -- OVERLOADİNG edilebilir. 
             * + - * / % OVERLOADİNG    EDİLEBİLİR. 
             *
             *
             *
             */

        }
    }
}
