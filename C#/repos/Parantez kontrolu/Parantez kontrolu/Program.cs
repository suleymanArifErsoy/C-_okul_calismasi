using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parantez_kontrolu
{
    class Program
    {
        static int[] stack = new int[100];
        static int sp= -1;
        static void push(int data)
        {
            sp++;
            stack[sp]= data;
        }
        static int pop()
        {
            int data = stack[sp];
            sp--;
            return data;
        }
        static void Main(string[] args)
        {
            string sol = "{([";
            string sag = "})]";

            string kontrol = "([])";
            bool hata = false;

            for (int i = 0; i < kontrol.Length; i++)
            {
                if (sol.IndexOf(kontrol[i])!=-1)
                {
                    push(kontrol[i]);
                    continue;
                }               
                if(sag.IndexOf(kontrol[i])!=-1)
                {
                    if(stack.Count()==0)
                    {
                        hata = true;
                        continue;
                    }
                    if(pop()!=sol.IndexOf(kontrol[i]))
                    {

                        hata = true;
                        break;
                    }
                }
            }
            if (stack.Count()>=1)
            {
                hata = true;
            }
            if(hata)
            {
                Console.WriteLine("hata");
            }
            else
            {
                Console.WriteLine("dogru");
            }
            Console.ReadLine();
        }
    }
}
