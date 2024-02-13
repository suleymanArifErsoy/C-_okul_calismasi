using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_yapı_ile_2_boyutlu_dizilerde_toplama
{
    class Program
    {
        
        static int topla(int[,] x ,int  sonuc,int i,int j)
        {

            
        }


        static void Main(string[] args)
        {
           


            Random rnd = new Random();
            int[,] x = new int[10, 100];
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    x[i,j] = rnd.Next(1, 20);
                }
            }
            Console.WriteLine("sayıların toplamı =" + topla(x, 0, 0, 0));
            Console.ReadLine();



        }
    }
}
