using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariDers2_listeyi_tersten_yazdirma
{
    class Program
    {
        class Block
        {
            public int data;
            public Block next;
        }
        static void yaz(Block temp)
        {

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
        static void rec(Block temp)
        {                                                   //liste yontemi 
              //recursive yapı..                           //recursive yapısı ile daha az masrafsiz cozum...
            if (temp==null) { return; }
            Console.WriteLine(temp.data);
            rec(temp.next);
        }
        static void Main(string[] args)
        {
            //baslangıc elemani head olan bir listeyi 
            // baslangıc elemani first olan adrese kopyalayın 
            //ve tersten yazdırın.
            //head; 12,45,71,6 olsun
            //firs; 6,71,45,12  
            
            Block head = new Block();
            head.data = 12;
            head.next = new Block();
            head.next.data = 45;
            head.next.next = new Block();
            head.next.next.data = 71;
            head.next.next.next= new Block();
            head.next.next.next.data = 6;
            head.next.next.next.next = null;

            Block temp = head;
            rec(temp); 



            int[] x = new int[10];
            int adet = 0;

            while(temp!=null)
            {
                x[adet] = temp.data;
                adet++;
                temp = temp.next;
            }
            Block first = null;
            Block last = null;
            Block copy = null;

            for (int i = adet-1; i >= 0; i--)
            {
                Block bl = new Block();
                bl.data = x[i];
               
                if (first==null)
                {
                    first = bl;
                    last = bl;
                }
                else
                {
                    last.next = bl;
                    last = bl;
                }
            }

            for (int i = 0; i <= adet-1; i++)
            {
                Block w = new Block();
                w.data = x[i];

                if (copy == null)
                {
                    copy = w;
                    last = w;
                }
                else
                {
                    last.next = w;
                    last = w;
                }
            }

            yaz(head);
            Console.WriteLine("reverse");
            yaz(first);
            Console.WriteLine("kopyası");
            yaz(copy);
            Console.ReadLine();

        }
    }
}
