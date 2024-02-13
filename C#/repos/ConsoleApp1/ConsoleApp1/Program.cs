using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);  
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
