using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSinavi
{
    class Program
    {
        public static int EnUzunSonluAritmetikDizi(int[] A, int alt, int ust)
        {
            int diziBoyutu = A.Length;
            int sonuc = 1;
            int ortakFark = 1;
            if ((alt >= 0) && (ust < diziBoyutu) && (ust - alt + 1) >= 3)
            {
                ortakFark = A[alt + 1] - A[alt];
                int i = alt + 2;
                for (; i <= ust; i++)
                {
                    if ((A[i] - A[i - 1]) != ortakFark)
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
            int[] A = { 3, 5, 7, 9, 12, 15, 7, 8, 9, 10, 11, 12 };
            int diziBoyutu = A.Length;
            int alt = 0;
            int ust = 0;
            int maksZincirUz = 1;
            int zincirUz;
            for (int i = 0; i < diziBoyutu - 2; i++)
            {
                for (int j = i + 2; j < diziBoyutu; j++)
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
                    else
                    {

                    }
                }
            }
            int uzunluk_sayisi = 0;
            if (maksZincirUz != 1)
            {
                for (int i = alt; i <= ust; i++)
                {
                    Console.Write(A[i] + " ");
                    uzunluk_sayisi++;
                }
            }
            else Console.WriteLine("Aritmetik dizi yok.");
            Console.WriteLine("\nUzunluk sayisi: "+uzunluk_sayisi);
            
            Console.ReadKey();
        }
       
    }
}

