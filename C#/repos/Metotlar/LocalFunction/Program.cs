using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalfunctionKullanimi(11, 22);

        }

        static void LocalfunctionKullanimi(int sayı1,int sayı2)
        {
            //int toplam = sayı1 + sayı2;

            int topla(int gelensayı1,int gelensayı2)
            {
                return gelensayı1 + gelensayı2;             /* Local Functions kullanımı kod okunurlugunu arttırır. 
                                                             * Yazılan kodun daha kolay kolay anlaşılmasını sağlar.
                                                             */
            }
            int toplamdeger = topla(sayı1,sayı2);
            Console.WriteLine(toplamdeger);

        }

    }
}
