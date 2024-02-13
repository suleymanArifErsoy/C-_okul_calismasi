using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackler
{
    
    class Program
    {
        static int sp = -1;
        static char[] stack = new char[100];
        static void push(char value)
        {
            sp++;
            stack[sp] = value;
        }
        static char pop()
        {
            char data = stack[sp];
            sp--;
            return data;
        }
        static int stackCount()
        {
            return sp++;
        }
        static int palindorm_mu(char[] str)
        {
            int lenght = str.Length;

            int i, mid = lenght / 2;

            for (i = 0; i < mid; i++)
            {
                push(str[i]);
            }
            if (lenght%2==1)
            {
                i++;
            }
            while(i<lenght)
            {
                char eleman = pop();
                if (eleman!=str[i])
                {
                    return 0;
                }
                i++;
            }

            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bir ifade giriniz.");
            string ifade = Console.ReadLine();
            char[] deger = $"{ifade}".ToCharArray();
            Console.WriteLine(deger[1]);  
            Console.ReadKey();
            if (palindorm_mu(deger)==1)
            {
                Console.Write("Girdiginiz ifade palındorm bir ifadedir.");
            }
            else
            {
                Console.Write("girdiginz ifade bir palindorm ifadedir.");
            }
            Console.ReadKey();
        }
    }
}
