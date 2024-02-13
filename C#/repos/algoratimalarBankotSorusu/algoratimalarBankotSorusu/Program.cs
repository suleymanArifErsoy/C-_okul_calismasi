using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoratimalarBankotSorusu
{
    class Program
    {/*
        const int ikiYuzlukBankot = 200;
        const int yuzlukBankot = 100;
        const int ellilikBankot = 50;
        const int yirmilikBankot = 20;
        const int onlukBankot = 10;
        const int beslikBankot = 5;
        const int birlikBankot = 1;
        const double dolarTl = 19;
        public static int ikiYuzlukBankotSayisi =0;
        public static int yuzlukBankotSayisi = 0;
        public static int ellilikBankotSayisi = 0;
        public static int yirmilikBankotSayisi = 0;
        public static int onlukBankotSayisi = 0;
        public static int beslikBankotSayisi = 0;
        public static int birlikBankotSayisi = 0;
        


        public static double BankotVerisi(double lira)
        {
            
            if (lira >= ikiYuzlukBankot)
            {
                ikiYuzlukBankotSayisi = Convert.ToInt32(lira / ikiYuzlukBankot);
                lira -= ikiYuzlukBankot * ikiYuzlukBankotSayisi;
            }
            else if (lira >= yuzlukBankot)
            {
                yuzlukBankotSayisi = Convert.ToInt32(lira / yuzlukBankot);
                lira -= yuzlukBankotSayisi * yuzlukBankot;
            }
            else if (lira >= ellilikBankot)
            {
                ellilikBankotSayisi = Convert.ToInt32(lira / ellilikBankot);
                lira -= ellilikBankotSayisi * ellilikBankot;
            }
            else if (lira >= yirmilikBankot)
            {
                yirmilikBankotSayisi = Convert.ToInt32(lira / yirmilikBankot);
                lira -= yirmilikBankotSayisi * yirmilikBankot;
            }
            else if (lira >= onlukBankot)
            {
                onlukBankotSayisi = Convert.ToInt32(lira / onlukBankot);
                lira -= onlukBankotSayisi * onlukBankot;
            }
            else if (lira >= beslikBankot)
            {
                beslikBankotSayisi = Convert.ToInt32(lira / beslikBankot);
                lira -= beslikBankotSayisi * beslikBankot;
            }
            else if (lira >= birlikBankot)
            {
                birlikBankotSayisi = Convert.ToInt32(lira / birlikBankot);
                lira -= birlikBankotSayisi * birlikBankot;
            }
            else if (lira < 1)
            {
                return 0;
            }
            return BankotVerisi(lira);
            
        }*/
        const int dolarTl =19;
        public static int DolarTldonusturucu(int dolar)
        {
            int tl = dolarTl * dolar;
            return tl;

        }


        public static void dovizTlDonusturucusu(double tl)
        {
            int adet = 0;
            double[] bankotlar = { 200, 100, 50, 20, 10, 5, 1 };
            string[] bankotAdı = { "İkiYüz", "Yüz", "Elli", "yirmi", "On", "Beş", "Bir" };

            for (int i = 0; i < bankotlar.Length; i++)
            {
                adet = Convert.ToInt32(Math.Floor(tl / bankotlar[i]));
                Console.WriteLine(adet +"adet"+bankotAdı[i]);
                tl = tl % bankotlar[i];
                if (tl == 0) { break; }
            }
        }
       
        static void Main(string[] args)
        {
            /*
            Console.Write("Dönüştürmek istediğiniz dolar miktarını giriniz --> ");
            double dolarMiktari = Convert.ToDouble(Console.ReadLine());
            
            
            if (BankotVerisi(DolarTldonusturucu(dolarMiktari)) == 0)
            {
                Console.WriteLine("200'luk bankot : " + ikiYuzlukBankotSayisi);
                Console.WriteLine("100'luk bankot : " + yuzlukBankotSayisi);
                Console.WriteLine("50'luk bankot : " + ellilikBankotSayisi);
                Console.WriteLine("20'luk bankot : " + yirmilikBankotSayisi);
                Console.WriteLine("10'luk bankot : " + onlukBankotSayisi);
                Console.WriteLine("5'luk bankot : " + beslikBankotSayisi);
                Console.WriteLine("1'luk bankot : " + birlikBankotSayisi);
            }
            else
            {
                Console.WriteLine("Bir hata var ");
            }
           
            Console.ReadKey();
         */
            

        }
    }
}
