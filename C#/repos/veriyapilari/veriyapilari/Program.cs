using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriyapilari
{
    class Program
    {
        class Block
        {
            public int data;
            public Block next;
        }
        static void Main(string[] args)
        {
            Block head = null;
            Block last = null;
            bool var_mı = false;

            for (int i = 0; i < 10; i++)
            {
                Block temp = new Block();
                temp.data = i;
                if (head==null)
                {
                    head = temp;
                    last = temp;
                }
                else
                {
                    last.next = temp;
                    last = temp;
                }
                Console.WriteLine(last.data);
                if (last.data==10)
                {
                    var_mı = true;
                }
            }


           if (var_mı)
           {
               Console.WriteLine(var_mı);
               Console.WriteLine("listede aradiniz  deger bulundu.");
           }
            else
            {
                Console.WriteLine("liste aradıgınız deger bulunamadı.");
            }
            Console.ReadLine();
        }
    }
}
