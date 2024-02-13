using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_konu
{
    class Program
    {
        class Stack
        {
            private int[] dizi;
            private int sp;

            public Stack(int boyut) 
            {
                dizi = new int[boyut];
                sp = -1;
            }
            public void push(int data) 
            {
                sp++;
                dizi[sp] = data;
            }

            public int pop()
            {
                int data = dizi[sp];
                sp--;
                Console.WriteLine(data);
                return data;

            }
        }
        


        static void Main(string[] args)
        {

            Stack s1 = new Stack(10);

            for (int i = 0; i < 10; i++)
            {



            }
            

        }
    }
}
