using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmalarVizeOncesiCalisma
{
    class Program
    {

        /*static int FibonacciHesapla(int seriBoyutu)
        {
            int ilkSayi = 0, ikinciSayi = 1, sonuc = 0;
            if (seriBoyutu == 1) return 0;
            if (seriBoyutu == 2) return 1;
            for (int i = 0; i < seriBoyutu-2; i++)
            {
                sonuc = ilkSayi + ikinciSayi;
                ilkSayi = ikinciSayi;
                ikinciSayi = sonuc;
            }
            return sonuc;
        }
        static int FiboHesaplaRecursive(int seriboyutu)
        {
            if (seriboyutu == 1) return 0;
            if (seriboyutu == 2) return 1;

            return FiboHesaplaRecursive(seriboyutu - 1) + FiboHesaplaRecursive(seriboyutu - 2);
        }
      
        public static int basamakToplami(int sayi)
        {
            if (sayi == 0) return 0;
            return sayi%10+basamakToplami(sayi / 10);
        }*/



        //                                A dizisi içerisinde B dizisi mevcut mu sıralı bir şekilde //

        /*public static int subString(int[] A, int[] B)
        {
            int diziUzunlukA = A.Length;
            int diziUzunlukB = B.Length;
            int kontrol = 0;

            if (diziUzunlukA < diziUzunlukB) return kontrol;
            else
            {
                for (int i = 0; i <= diziUzunlukA-diziUzunlukB; i++)
                {
                    if (A[i] == B[0])
                    {
                        kontrol = 1;
                        for (int j = 1; j < diziUzunlukB; j++)
                        {
                            if (A[i + j] != B[j])
                            {
                                return kontrol-1;
                            }
                        }
                    }
                    
                }
            }
            return kontrol;

           

        }*/


        //                                           Bir diziyi saga kaydırma   ///
        
         public static int[] sagaKaydir(int[] dizi,int kaydirmaSayisi)
        {

            int diziUzunluk = dizi.Length;
            if (kaydirmaSayisi % diziUzunluk == 0) return dizi;
            for (int j = 0; j < kaydirmaSayisi; j++)
            {
                int temp = dizi[diziUzunluk - 1];
                for (int i = diziUzunluk - 1; i > 0; i--)
                {
                    dizi[i] = dizi[i - 1];
                }
                dizi[0] = temp;
            }
         
            return dizi;
        }
        // Sonlu aritmatik dizi mi ?
        public static bool SonluAritmatikDizi(int[] dizi)
        {
            int sonuc;
            int ortakFark=  dizi[1] - dizi[0];
            bool kontrol = true;
            int diziUzunluk = dizi.Length;
            if (diziUzunluk >= 3)
            {
                for (int i = 1; i < diziUzunluk; i++)
                {
                    sonuc = dizi[i] - dizi[i - 1];
                    if (sonuc != ortakFark)
                    {
                        kontrol = false;
                        break;
                    }
                }
            }
            else return !kontrol;
            return kontrol;
            
        }
        // Bir dizi içerisinde en uzun Sonlu aritmatik diziyi bulan metot
        
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

        //Karesiz sayi 
        List<int> asalCarpanVektoru(int n)
        {
            List<int> asalCarpanList = new List<int>();
            int i = 2;
            while (i * i <= n)
            {
                while ((n % i) == 0)
                {
                    asalCarpanList.Add(i);
                    n = n / i;
                }
                if (i == 2) i = 3;
                else i = i + 2;
            }
            if (n > 1) { asalCarpanList.Add(n); }
            return asalCarpanList;
        }
        // Karesiz sayi  
        bool elemanlariFarkliMi(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j]) { return false; }

                }
            }
            return true;
        }



        static uint bitSayisi(uint b,uint c=0x80000000)
        {
            if (c == 0) return b;
            if ((b & c) != 0)
                return 1 + bitSayisi(b, c >> 1);
            else
                return bitSayisi(b, c >>1);
        }

        // 2 lik sayiyi 10 luk sayiya donusturme recursive ile 

        static int ondalikDonusturucu(int sayi,int carpan,int maske)
        {
            if (maske == 0) return 0;
            if ((sayi & maske) != 0) return 1 * carpan + ondalikDonusturucu(sayi, carpan * 2, maske << 1);
            return ondalikDonusturucu(sayi, carpan * 2, maske << 1);
        }

        static void Main(string[] args)
        {
            /*
            int[] A = { 26, 44, 11, 2, 4, 6, 8, 10, 12, 3, 6, 9, 12, 15, 18, 21, 5, 10, 15, 7 };
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
            if (maksZincirUz != 1)
            {
                for (int i = alt; i <= ust; i++)
                {
                    Console.Write(A[i] + " ");
                }


            }
            else Console.WriteLine("Aritmetik dizi yok.");*/





            // bitwise Konu anlatımı 


            //  11111111 255 
            //  negatif sayilari nasıl gostericez ? 
            // int q1 ; int da negatif sayilari tutabilirsin 
            // uint q2; uint (unassigned= işaretsiz) sadece pozitif sayilari tutarız 
            // en soldaki bit MSB sign bit işaret bitidir 
            // en soldaki bit 1 ise sayi negatiftir. 

            // 0011 => 3 
            // 1011 =?  en soldaki biti 1 oldugu için negatif bir sayidir ama -3 değildir !!!!!!
            // nasıl bulunur ??

            // 1- ilk önce bu sayının değilini al 
            // 1011 
            // 0100 değili 
            // 0001 ile topla 
            // 0101 => -5    1011 => -5 'miş. 


            uint sayi = 11;// uintler ile calışmak daha rahat isaret biti yok 8 bitin tamamını kullanabiliyoruz

            // ÖNEMLİ !!! 

            // sagdan itibaren ilk bitteki değeri değiştirme nasıl yapılır ?
            // Maskeleme yöntemi kullanılacaktır 

            // xxxx xxxx xxxx xxxx xxxx xxxx xxxx xxxx sayımız bu olsun 
            // 1111 1111 1111 1111 1111 1111 1111 1110 son bitini 0 yapmak için bu maskeyi kullanırız 

            uint maske = 0xfffffffe; // f=1111 e=1110
            sayi = sayi & maske;

            // sayi =0 
            // sayi =~sayi 


            // sayiyi shif etmek saga sola !!!!! ÖNEMLİ 

            // 1010 sayisini sola 1 shift kaydırırsak 
            // 0100 olur 
            // en sağdaki 1 değeri dışarı atilir
            // bir shift daha yapılırsa 
            // 1000 olur 
            // 1 shift daha yapılırsa değer 
            // 0000 olmuş olur 

            sayi = 1;
            sayi = sayi << 1; // sola 1 shift kaydır 

            // bitwise opertatorleri ile sayi tek mi cift mi?? nasıl anlarız ??
            // bit sayimizin en soldaki biti 1 ise tek 0 ise çiftir 

            // 1. Çözüm 
            //maske = 0x1;
            //if ((sayi & 1) == 1) // if içi true gelirse sayimiz tek olur 

            // 2.Çözüm 
            // if((sayi>>1)<<1==sayi) // if içerisi true ise sayimiz çift olur 




            // Soru 2 ÖNEMLİ !!!!!

            // 0001111011001011011 sayimizin bit değerlerinde kaç adet bir vardir 

            sayi = 0xffffffff;
            int adet = 0;
            int maske1 = 0x1;
            for (int i = 0; i < 32; i++)
            {
                if ((sayi & 0x1) == 1) adet++;  // burada sayinin en soldaki bit değerine bakılıyor 
                sayi = sayi >> 1;               // eğer 1  adet arttır 
            }                                   // daha sonra sayiyi 1 shift saga kaydir 

            // Burada sayimizi surekli shift ettigimiz icin sayi değerimiz değişti
            // Sayi yerine maskemizi shift edersek sayi değerimiz kaybolmamamiş olur 
            for (int i = 0; i < 32; i++)
            {
                if ((sayi & maske) != 0) adet++;
                maske = maske << 1;
            }

            // Girilen sayiyi ikilik sayi sistemine göre yazalım 
            uint sayi1 = 0xa;
            uint maske2 = 0x80000000;
            bool kontrol = false;
            uint[] bitDizisi = new uint[32];
            for (int i = 0; i < 32; i++)
            {
                if ((sayi1 & maske2) != 0)
                    bitDizisi[i] = 1;
                else
                    bitDizisi[i] = 0;
                maske2 = maske2 >> 1;
            }
            for (int i = 0; i < bitDizisi.Length; i++)
            {
                if (bitDizisi[i] != 0) { kontrol = true; }
                if (kontrol)
                {
                    Console.Write(bitDizisi[i]);
                }
            }

            Console.WriteLine();
            // a ve b sayıları aynı mı değil mi ? 

            int a = 21;
            int b = 1;

            if ((a & b) == a && (a & b) == b) { Console.WriteLine("sayilar eşit"); }
            else Console.WriteLine("sayilar farkli ");

            // Binary sayinin 10 luk sayiya donustürülmesi 

            sayi = 0xa;
            maske = 0x1;
            int carpan = 1;
            int sonuc = 0;
            Console.WriteLine(sayi);
            for (int i = 0; i < 32; i++)
            {
                if ((sayi & maske) != 0)
                {
                    sonuc += carpan;
                }
                maske = maske << 1;
                carpan *= 2;
            }
            Console.WriteLine(sonuc);



            // subString AltKüme 

            //  a   b 
            //  0   0   boş 
            //  0   1   b
            //  1   0   a   
            //  1   1   ab

            // string küme = 'abc'   a b c kümesinin alt kümeleri 
            for (a = 0; a < 2; a++)
            {
                for (b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        if (a == 1) Console.Write("a");
                        if (b == 1) Console.Write("b");
                        if (c == 1) Console.Write("c");
                        Console.WriteLine("");
                    }

                }
            }

            // ÖNEMLİ !!!!!!!

            // Yukarıda 3 tane iç içe dongu yazdık 
            // eğer eleman sayimiz 3 ten yuksek yani 20 ,30 gibi bir sayi olsaydi iç içe 20 ,30 tane döngü yazmamız mümkün değil 
            // bunun yerine bir eleman dizisi oluşturup iki while dongusuyle istediğimiz sayida elamanı içe içe donguymus gibi çalıştırabiliriz


            int[] dongu = new int[4];
            while (dongu[3] == 0)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dongu[j] == 1) Console.Write((char)(j + 'a'));

                }
                Console.WriteLine();
                int i = 0;
                dongu[0]++;

                while (dongu[i] == 2)
                {
                    dongu[i] = 0;
                    i++;
                    dongu[i]++;

                }

            }

            string kume = "abc";
            int kumeElemanlari = (int)Math.Pow(2, kume.Length); // 2^n tane alt kumesi vardır 
            maske = 1;
            for (int i = 0; i < kumeElemanlari; i++)
            {

                for (int j = 0; j < kume.Length; j++)
                {
                    if ((i & maske) != 0) Console.Write(kume[j]);
                    maske = maske << 1;
                }
                maske = 0x1;
                Console.WriteLine();

            }






            // bir kümenin elemanları 1 ile 10 arasındadır 
            // bu kümenin tüm alt kümelerinden alt küme toplamı 55 olan kaç adet alt küme vardır 

            int k = 1;
            int[] sayiKumesi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
            int elemanSayisi = 0;
            for (int i = 1; i < 1024; i++)
            {
                toplam = 0;
                for (int j = 0; j < 10; j++)
                {
                    if ((i & k) != 0) toplam += sayiKumesi[j];
                    k <<= 1;
                }
                k = 1;
                if (toplam == 52)
                {
                    elemanSayisi++;
                }
            }
            Console.WriteLine(elemanSayisi);



            // 1 den 7 ye kadar olan bir int dizisinin rakamları ile oluşturulabilecek tam sayilari siralayın 

            int[] newKume = { 1, 2, 3, 4, 5, 6, 7 };
            int m = 1;
            string uretilenSayi = "";

            List<int> sayiListesi = new List<int>();
            for (int i = 1; i < 128; i++)
            {
                int toplamDeger = 0;
                uretilenSayi = "";
                for (int j = 0; j < 7; j++)
                {
                    if ((i & m) != 0)
                    {
                        uretilenSayi += newKume[j];
                        toplamDeger += Convert.ToInt32(newKume[j]);

                    }
                    m <<= 1;
                }
                m = 0x1;
                int gelenSayi = Convert.ToInt32(uretilenSayi);
                sayiListesi.Add(gelenSayi);
                if (toplamDeger == 15)   // alt kümeler ile oluşturulan sayının basamak değerleri toplama 15 ise 
                {
                    Console.WriteLine(gelenSayi);
                }

            }

            sayiListesi.Sort();
            for (int i = 0; i < sayiListesi.Count; i++)
            {
                Console.WriteLine(i + 1 + "-" + sayiListesi[i]);
            }

            Console.WriteLine("\t\t\t");





            // SONN DERSSSS VİZE ÖNCESİ 

            int abc = 1234;
            string s = "";


            while (abc > 0)
            {
                s = (char)('0' + (abc - abc / 10 * 10)) + s;
                abc = abc / 10;
            }
            Console.WriteLine(s);


            string s1 = "abcdef";
            string s2 = "abc    ";
            int[,] euss = new int[s2.Length, s1.Length];
            int maxeuss = 0;

            // Ortak Stringlerine bakalım
            // 3 tane subString var ab jkl fgh
            // 2 string'in en uzun ortak Stringlerini bulacaz 
            // long common subString 

            for (int i = 0; i < s2.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[j] == s2[i])
                    {
                        if (i == 0 || j == 0)
                            euss[i, j] = 1;
                        else
                            euss[i, j] = euss[i - 1, j - 1] + 1;

                        if (maxeuss < euss[i, j])
                            maxeuss = euss[i, j];
                    }
                }
            }
            Console.WriteLine(maxeuss);

            // s3 stringinin en uzun palindormik kelimesinin uzunluğu kaçtır??
            string s3 = " ahmet 1234321 adet mum satsana";
            int[,] palindormikDizi = new int[s3.Length, s3.Length];
            for (int i = s3.Length-1; i >= 0; i--)
            {
                for (int j = 0; j < s3.Length; j++)
                {
                    if (s3[i] == s3[j])
                    {
                        if (i == 0 || j == 0) palindormikDizi[i, j] = 1;
                        else
                        {
                            palindormikDizi[i, j] = palindormikDizi[i - 1, j - 1] + 1;
                        }
                    }
                }
            }





            // OTOMATA ile ÇÖZÜM 


            string k1 = "abcdefghjkl";
            string k2 = "def";

            int[,] q = new int[4, 40]; // 4 değeri state sayısı
                                       // 40 değeri giriş sayisi
            int state = 0;

            // a=0 b=1 c=2 d=3 e=4 f=5 ...... z=29 gibi 
            // Bu ifadeleri k1[i]-'a' ya göre yazıyoruz ..!!!

            q[0, 4] = 1; // eğer 0. statedeysek 4 yani d gelirse 1.state'a git 
            q[1, 5] = 2; 
            q[2, 6] = 3; // 2 . statede iken 6 değeri yani    
            q[1, 4] = 1; // 1. statede iken 4 değeri yani d harfi gelirse kendine git 
            q[2, 4] = 1;
            for (int i = 0; i < k1.Length; i++)
            {
                state =q[state, (byte)k1[i] - 'a'];
                if (state == 3) Console.WriteLine("bulundu");
            }


            //ÖNEMLİ İİİİ 

            // her ab'den sonra en az bir c gelmeli 
            // abhhhfhfhhfhsC olur 
            //abhhhhhab olmaz 

            int[,] q1 = new int[5, 40];

            k1 = "abc";
            // for donguleri kullanarak daha düzenli bir sistem geliştirilebilir.
            
            for (int i = 0; i < 40; i++)
            {
                q1[0, i] = 0;
            }
            q1[0, 0] = 1;
            q1[0, 2] = 4;

            for (int i = 0; i < 40; i++)
            {
                q1[1, i] = 1;
            }
            q1[1, 1] = 2;

            for (int i = 0; i < 40; i++)
            {
                q1[2, i] = 2;
            }

            for (int i = 0; i < 40; i++)
            {
                q1[3, i] = 2;
            }
            q1[2, 2] = 0; // 0. state final state'e gelmiş olduk
            q1[2, 0] = 3;

            q1[3, 1] = 4; // Dead State 'e gelinmiş oldu 
            q1[3, 0] = 3;
            q1[3, 2] = 0; // final'a goturdu gelen c değeri 

            for (int i = 0; i <k1.Length ; i++)
            {
                state = q1[state, (byte)(k1[i]) - 'a'];
                if (state == 4) { Console.WriteLine("Otomata kabul etmedi."); break; }
            }
            if (state == 2) Console.WriteLine("reddediyoruz");
            if (state == 0) Console.WriteLine("Kabul Ediyoruz");
            if (state == 3) Console.WriteLine("Reddediyoruz");

            Console.ReadKey();
          
        }
       }
    }

