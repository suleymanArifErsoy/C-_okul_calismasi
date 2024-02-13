using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoraitmalarFinalOncesiHoffmanAlgoritmasi
{
    class Program
    {

        class btree
        {
            public int data;
            public string huffman;
            public int ch;
            public btree left;
            public btree right;

        }
        static void createBtree(btree[] bt)
        {
            if (bt[1] == null) return;

            btree b = new btree();
            b.right = bt[1];
            b.left = bt[0];
            b.data = bt[0].data + bt[1].data;

            bt[0] = b;
            bt[1] = null;


            Array.Sort(bt, (object x, object y) =>
             {
                 int a = 0;
                 if (x == null && y == null) return 0;
                 if (x == null) return 1; if (y == null) return -1;

                 if (((btree)x).data < ((btree)y).data) a = -1;
                 if (((btree)x).data > ((btree)y).data) a = 1;

                 return a;
             });

            createBtree(bt);
        }


        static void huffmanYaz(btree bt,string yon)
        {
            if (bt == null) return;

            if (bt.left == null) bt.huffman = yon;
            huffmanYaz(bt.left, yon + "0");

            if (bt.right == null) bt.huffman = yon;
            huffmanYaz(bt.right, yon + "1");

        }

        static void hufmannYazdir(btree bt)
        {
            if (bt == null) return;

            if (bt.left == null) Console.WriteLine("{0} {1}",(char)bt.ch,bt.huffman);
            hufmannYazdir(bt.left);
            hufmannYazdir(bt.right);
        }
        static string huffmanFind(btree bt,int ch)
        {
            if (bt == null) return "";
            if (bt.ch == ch) return bt.huffman;
           return huffmanFind(bt.left, ch) + huffmanFind(bt.right, ch);  
        }

        // Zeynep Atilla'nın yerine girip en son derste işledi
        static int Knapsack(int kapasite, int[] ağırlık, int[] değerler, int n)
        {
            if (n == 0 || kapasite == 0) return 0;
            if (ağırlık[n - 1] > kapasite)
                return Knapsack(kapasite, ağırlık, değerler, n - 1);

            int dahilEtmeSonucu = değerler[n - 1] + Knapsack(kapasite - ağırlık[n - 1], ağırlık, değerler, n - 1);
            int hariçBırakmaSonucu = Knapsack(kapasite, ağırlık, değerler, n - 1);

            return Math.Max(dahilEtmeSonucu, hariçBırakmaSonucu);
        }

        static void Main(string[] args)
        {
            string s = "abbacd";
            int[] f = new int[5];
            btree[] bt = new btree[4]; // s string ifadesinde 4 tane harf tanımlı olduğu için

            for (int i = 0; i < s.Length; i++)
            {
                f[s[i] - 'a']++;   // string bir ifadenin her bir elemanından kaç tane bulunuyor onu gösterir
            }
            
            for (int i = 0; i < 4; i++)
            {
                bt[i] = new btree();
                bt[i].data = f[i];
                bt[i].ch = 'a' + i;
            }

            Array.Sort(bt, (object x, object y) =>
             {
                 int a = 0;

                 if (x == null && y == null) return 0;
                 if (x == null) return 1; if (x == null) return -1;

                 if (((btree)x).data < ((btree)y).data) return -1;
                 if (((btree)x).data > ((btree)y).data) return 1;
                 return a;
             });

            createBtree(bt);
            huffmanYaz(bt[0], "");
            hufmannYazdir(bt[0]);


            // Zeynep'in Algo sorusu 
            // abcd 4 basamaklı rakamları farklı olan bir sayidir .
            // (ab+cd)^2=abcd eşitliğini doğrlayan Tüm 4 basamklı sayiları ekrana bastirin

            // rakamları farklı en küçük 4 basamaklı sayı => 1023 buradan başlıyacak dongumuz
            // rakamları farklı en büyük 4 basamaklı sayı => 9876 ya kadar gidecek 


            int temp = 0;
            int birlerBas = 0;
            int onlarBas = 0;
            int yuzlerBas = 0;
            int binlerBas = 0;

            List<int> kabulSayilar = new List<int>();
            for (int i = 1023; i <= 9876; i++)
            {
                temp = i;
                birlerBas=temp % 10;
                temp=temp / 10;
                
                onlarBas = temp % 10;
                temp=temp / 10;

                yuzlerBas = temp % 10;
                temp /= 10;

                binlerBas = temp % 10;
                
                if(birlerBas==onlarBas ||birlerBas==yuzlerBas 
                || birlerBas==binlerBas || onlarBas==yuzlerBas 
                || onlarBas==binlerBas || yuzlerBas==binlerBas)
                {}
                else
                {
                    int ilkIkiSayi = 10 * binlerBas + yuzlerBas;
                    int sonIkiSayi = 10 * onlarBas + birlerBas;
                    int esitliginSolu = (ilkIkiSayi + sonIkiSayi) * (ilkIkiSayi + sonIkiSayi);
                    if (esitliginSolu == i)
                    {
                        kabulSayilar.Add(i);
                    }
                }
            }
            foreach (var item in kabulSayilar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
