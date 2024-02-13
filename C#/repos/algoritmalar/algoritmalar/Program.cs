using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmalar
{
    class Program
    {/*
      static int SonluAritmetikDiziMi(int[] A)
        {
            int ortakFark = 1;
            int sonuc;
            int diziBoyutu = A.Length;
            if (diziBoyutu >= 3)
            {
                sonuc = 1;
                ortakFark = A[1] - A[0];
                for (int i = 3; i < diziBoyutu; i++)
                {
                    if (A[i] - A[i - 1] != ortakFark)
                    {
                        sonuc = 0;
                        break;
                    
                    
                    }
                    
                }

                return sonuc;
            
            
            }
            return 0;
        
        
        }
        static void Main(string[] args)
        {

            int[] A = {3,6,9,12,15,18,19 };
            if (SonluAritmetikDiziMi(A) == 1)
            {
                Console.WriteLine("Bu dizi bir aritmetik dizidir. "); 
            }
            else Console.WriteLine("Bu dizi bir aritmetik dizi değildir.")
      */


        /* static void Main(string[] args)
        {
            int[] A = { 26,44,11,2,4,6,8,10,12,3,6,9,12,15,18,21,5,10,15,7};
            int diziBoyutu = A.Length;
            int alt = 0;
            int ust = 0;
            int maksZincirUz = 1;
            int zincirUz;
            for (int i = 0; i < diziBoyutu-2; i++)
            {
                for (int j = i+2; j < diziBoyutu; j++)
                {
                    if (EnUzunSonluAritmetikDizi(A, i, j) == 1)
                    {
                        zincirUz = (j - i + 1);
                        if (zincirUz > maksZincirUz)
                        {
                            maksZincirUz = zincirUz;
                            alt = i;
                            ust = j;
                        
                        }
                    
                    
                    }

                }
                
            }

            if (maksZincirUz != 1)
            {
                for (int i = alt; i <=ust; i++)
       
KUZEM SANAL 31: for (int i = alt; i <=ust; i++)
                {
                    Console.Write(A[i]+" ");
                }
            
            
            }
            else Console.WriteLine("Aritmetik dizi yok.");
            Console.ReadKey();

        }
    }
MU*/

        static int aritmatikDiziMi(int[] A)
        {
            int kontrol=1;
            int ortakKat = A[1] - A[0];
            if (A.Length > 3) 
            {
               for(int i=3;i<A.Length;i++)
                {
                    int sonuc=A[i] - A[i-1];
                    if(sonuc!=ortakKat)
                    {
                        kontrol = -1;
                        break;
                    }
                }
            }
            return kontrol;
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7,9};
            int sonuc=aritmatikDiziMi(dizi);

            if (sonuc == 1)
            {
                Console.WriteLine("Aritmatik bir dizidir");
            }
            else
            {
                Console.WriteLine("Aritmatik bir dizi değildir.");
            }
            Console.ReadLine();
        }
    }
}
