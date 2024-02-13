
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Isletim_Sistemi_Thread_Mutex
{
    class Program
    {
       static object kontrol1 = new object();
       static object kontrol2 = new object();


        /*static Mutex  m=new Mutex();
        static void T2()
         {
             for(int i =0;i<100;i++)
             {
                 m.WaitOne();
                 Console.Write("2");
                 m.ReleaseMutex();
                 m.WaitOne();
                 Console.Write("4");
                 m.ReleaseMutex();
             }
         }
         static void T1()
         {
             for(int i=0;i<100;i++)
             {
                 m.WaitOne();
                 Console.Write("1");
                 m.ReleaseMutex();
                 m.WaitOne();
                 Console.Write("3");
                 m.ReleaseMutex();
             }
         }*/

        /*static void Lock2()
        {
            lock (kontrol2)
            {
                Console.Write("2");
                Thread.Sleep(100);
            }
            lock (kontrol1)
                Console.Write("4");
        }
       static void Lock1()
       {
            lock (kontrol1)
            {
                Console.Write("1");
                Thread.Sleep(100);

                lock (kontrol2)
                    Console.Write("3");
                
            }
       }*/
        /*static Mutex mutex = new Mutex();
        static void arttir()
        {
            Console.WriteLine("Gelen Thread: "+Thread.CurrentThread.Name);
            mutex.WaitOne();
            try
            {
                Console.WriteLine("basarili: " + Thread.CurrentThread.Name);
                Thread.Sleep(2000);
                Console.WriteLine("bitti: "+ Thread.CurrentThread.Name);
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }*/
        /*
        static int sayac = 0;
        static int kont = 0;
        static Mutex mutex = new Mutex();
        static void yaz1()
        {
            for (int i = 0; i < 100; i++)
            {
                mutex.WaitOne();
                Console.WriteLine(Thread.CurrentThread.Name);
                sayac++;
                mutex.ReleaseMutex();
            }
            kont++;
            
        }
        static void yaz2()
        {
            for (int i = 0; i < 100; i++)
            {
                mutex.WaitOne();
                Console.WriteLine(Thread.CurrentThread.Name);
                sayac++;
                mutex.ReleaseMutex();
            }
            kont++;
        }*/






        /*
        static int sayi = 0;
        static object obj = new object();
        static object obj1 = new object();
        static void arttir()
        {
           lock(obj)
            {
                Console.Write("1");
                lock(obj1)
                    Console.Write("3");
            }
        }

        static void arttir2()
        {
            lock (obj1)
            {
                Console.Write("2");
            }
                lock(obj)
                    Console.Write("4");
            
        }*/


        static int[] dizi = { 1, 0, 1, 0, 0, 1, 1, 1, 1,0 };
        static int sayac = 0;
        static Mutex mutex = new Mutex();
        static void hesapla(int start , int end)
        {
            for (int i = start; i < end; i++)
            {
                if (dizi[i] == 1)
                {
                    Interlocked.Increment(ref sayac);
                }
            }
        }
        static void Main(string[] args)
        {
            int sayac = 0;
            Thread t1 = new  Thread(()=> hesapla(0, 5));
            Thread t2 = new Thread(() => hesapla(5,10));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            float oran = (sayac / dizi.Length) ;
            Console.WriteLine(sayac+" Dizi boyutu: "+dizi.Length);
            Console.WriteLine("Doluluk oranı: %"+oran);
            Console.ReadKey();
        }
    }
}
