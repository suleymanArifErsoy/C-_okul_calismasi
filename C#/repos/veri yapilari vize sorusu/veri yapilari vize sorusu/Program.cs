using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_vize_sorusu
{
    class Program
    {
        class Block
        {
            public  int data;
            public Block next;
            public Block prev;
        }

        static void Main(string[] args)
        {
            /*Soru
                [7,15,20,40] bir dizinin icerisinde bulunan 0. indexi bolge, 1.indexi il, 2.indexi ilce ,3. indexi koy olan bilgiler saklıdır .
            Bu verileri  ilk datasi head olan ciftli linked list'e aktarin. 
            Bolgedeki toplam nufuslari karsilastirin en yuksek nufuslu olan 2. bolgeyi ekrana yazin. 
            */

            int[,,,] x = new int[7,15,20,40];
            Random rnd = new Random();
            x[7, 15, 20, 40] = rnd.Next(50, 500);
            Block head = null;
            Block last= null;
            int[] bolge = new int[7];
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < 7; i++)
            {   
                int bolge_nufus = 0;
                
                for (int j = 0; j < 15; j++)
                {
                    for (int m = 0; m < 20; m++)
                    {
                        for (int k = 0; k < 40; k++)
                        {
                            bolge_nufus += x[i, j, m, k];
                            bolge_nufus = bolge[i];
                        }
                    }
                }
                for (int sayac = 0; sayac <7; sayac++)
                {
                    Block temp = new Block();
;                   temp.data = bolge[i];
                    if (head == null) { head = temp; last = temp; }
                    else
                    {
                        last.next.prev = temp.prev;
                        temp.next.prev = last.next;
                    }
                    if (bolge[i] > max1)
                    {
                        max2 = max1;
                        max1 = bolge[i];
                    }
                    else if (bolge[i]>max2)
                    {
                        max2 = bolge[i];
                    }
                    temp = temp.next;
                }
            }
            Console.Write("en Buyuk nufusa ait bolgenin nufusu:" + max1+"\n");
            Console.Write("En buyuk  2.nufusa ait bolgenin nufusu:" + max2+"\n");


           
    

        }
    }
}
