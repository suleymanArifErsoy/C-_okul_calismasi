using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace işletim_sistemi_soru1
{
    class Program
    {
        static int dolu = 0;
        static int bos = 0;
        static void hesapla(int[] dizi,int baslangic,int son)
        {
            for (int i = baslangic; i <son; i++)
            {
                if(dizi[i]!=0)
                    Interlocked.Increment(ref dolu);
                else 
                    Interlocked.Decrement(ref bos);
            }
        }
        static void Main(string[] args)
        {
            /*
             int[] a =new int[100000] dizimiz var bu dizideki elemanlar 0 ve 1 degerlerinden oluşmaktadir.Buradaki 0 değeri dolu 1 değeri boşu ifade etmektedir. 
             Her eleman bir cluster'a bakmaktadır. Dizinin elemanlarına göre doluluk oranı 4 adet thread ile safe mode da hesaplayınız. 
             */

            int[] a = new int[100000];
            double doluluk = 0;
            Thread th1 = new Thread(()=> hesapla(a,0,25000)); // Lambda ile birlikte Thread tanımlası yapılıp metot icerisine parametre gonderildi.   
            Thread th2 = new Thread(() => hesapla(a, 25001, 50000));
            Thread th3 = new Thread(() => hesapla(a, 50001, 75000));
            Thread th4 = new Thread(() => hesapla(a, 75001, 100000));
            
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();

            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();

            doluluk = dolu * a.Length * 100;
            Console.WriteLine($"Dizinin Doluluk Oranı: {doluluk} \tDizinin Bos olan yerlerinin sayisi: {bos}");

        }
    }
}
