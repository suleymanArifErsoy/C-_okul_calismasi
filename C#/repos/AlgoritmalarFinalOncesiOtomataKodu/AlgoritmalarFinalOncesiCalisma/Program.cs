using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmalarFinalOncesiCalisma
{
    class Program
    {

        static int max(int a,int b) // Hocanın çözduğu subSequence sorusunda kullanılan metot 
        {
            if (a > b) return a;  // iki boyutlu dizide üst ile solundaki değeri kıyaslayıp buyuk olanı geri donduruyor .
            else return b;
        }

        static void Main(string[] args)
        {
            // 1 . Soru  4( 1/1 - 1/3 + 1/5 - 1/7 + 1/9 ...) ==> Pi sayisinin açılımı 

            // İlk 10000 terimin toplamını bulan algoritma 

            float sayi =0;
            int flag = 1;
            for (int i = 1; i < 10000; i=i+2)
            {
                sayi = sayi + (float)1 / i * flag;
                flag = flag * -1;
            }
            Console.WriteLine(4*sayi);




            // 2.Soru 

            // daha önceden lcs longest commen substirng problemini çözmüştük .
            // sub sequence ==> subString'ten farkli olarak yanyana olmak zorunda değil arada başka karakterler olabilir 

            string a1 = "abcdefgh";
            string a2 = "axjbdch";
            string sq = "";

            // Benim çözümüm 

            int k = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                for (int j =k; j < a1.Length; j++)
                {
                    if (a2[i] == a1[j])
                    {
                        sq += a2[i];
                        k = j;
                        break;
                    }
                }
            }
            Console.WriteLine(sq);

            // Hocanın Çözümü Çalışmıyor :)
            //int adet = 0;
            //int[,] sequence = new int[a1.Length,a2.Length];

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    for (int j = 0; j < a2.Length; j++)
            //    {
            //        if (a2[i] == a1[j])
            //        {
            //            if(i==0 || j == 0)
            //            {
            //                sequence[i, j] = 1;
            //            }
            //            else
            //            {
            //                sequence[i, j] = sequence[i - 1, j] + 1;
            //            }
            //            if (sequence[i, j] > adet) adet += 1;
            //        }
            //        else
            //        {
            //            if(i==0 && j == 0)
            //            {
            //                sequence[i, j] = 0;
            //            }
            //            else
            //            {
            //                if (i == 0) sequence[i, j] = sequence[i, j - 1];
            //                if (j == 0) sequence[i, j] = sequence[i - 1, j];
            //                if(i!=0 && j!=0) sequence[i, j] = max(sequence[i - 1, j], sequence[i, j - 1]);
            //            }
            //        }
            //    }
            //}



            //  ----------------------------- !!!!!!! State Programalama !!!!!!!!!!!! -------------------------------------------------------------------------------------

            string  girisKumesi= "abcdefgh";
            string kural = "de"; // Arka arkaya de harflerini kabul eden otomata 


            // q0 'da 3=(d) gelirse 1=q1'e git 
            // q0 'da 3 disinda bir sayi gelirse (abcefgh'dan biri) 0=q0'a git
            // q1 'de 4=(e) gelirse q2'ye git                                                q0 --d--> q1 --e--> q2 
            // q1 'de 3 =(d) gelirse kendine git == 1 q1'e git 
            // q1 'de 3,4 hariç=(abcfgh'harflerinden biri) q0=0 'a git  
            
            // Kurallarımızı koydugumuz kısım (statelerin ilerlemesi sonucu oluşan durumları manuel olarak yazdığımız kısım )

            int[,] qD = new int[3, 10];
            for (int i = 0; i < 10; i++)
            {
                qD[0, i] = 0;
            }
            qD[0, 3] = 1;
            
            for (int i = 0; i < 10; i++)
            {
                qD[1, i] = 0;
            }
            qD[1, 4] = 2;
            qD[1, 3] = 1;

            for (int i = 0; i < 10; i++)
            {
                qD[2, i] = 2;
            }

            // Run etme kısmı 

            int state = 0;
            bool kontrol = false;
            for (int i = 0; i < girisKumesi.Length; i++)
            {
                state = qD[state, girisKumesi[i] - 'a']; // --> girisKumesi[i]-'a' ==> giriş kumesindeki char ifadesi ile a char ifadesinin askii değeri çıkarılıyor 
                if (state == 2) 
                {
                    kontrol = true;
                    break; 
                } 
            }
            if (kontrol) Console.WriteLine("Otomata Çalıştı");
            else Console.WriteLine("Otomata Çalışmadı");




            // Soru 

            // ab' den "hemen" sonra en az bir tane c gelecek ve pattern en az bir dafa gelmiş olacak 

            // abc kabul eder 
            // aabc kabul eder 
            // ggggghhhhhhshhshdhdhabccccccc kabul eder 

            // aaaaaaaa kabul etmez 
            // ab kabul etmez 

            //string kume = "abc";

            string input = "abbcc";
            
            int[,] qDi = new int[5,3];

            qDi[0, 0] = 1;
            qDi[0, 1] = 0;
            qDi[0, 2] = 4;

            qDi[1, 0] = 1;  // değerleri manuel olarak elle giriyoruz 
            qDi[1, 1] = 2;
            qDi[1, 2] = 4;

            qDi[2, 0] = 4;
            qDi[2, 1] = 4;
            qDi[2, 2] = 3;

            qDi[3, 0] = 1;
            qDi[3, 1] = 2;
            qDi[3, 2] = 3;

            int state_ = 0;
            for (int i = 0; i < input.Length; i++)
            {
                state_ = qDi[state_, input[i] - 'a'];
                if (state_ == 4)
                {
                    Console.WriteLine("Dead State'e Düştü ");
                    break; 
                }
            }
            if (state_ == 3) Console.WriteLine("Başarılı bir şekilde çalıştı");
            else Console.WriteLine("Çalışmaz ");



            // Soru 

            // Çift sayida 0 gelirse otomata çalışır aksi durumda çalışmaz 

            // 00100111111 çalışır 
            // boş kümede çalışır

            // 00011111 çalışmaz 

            // küme ={0,1}
            string girilenSayilar = "00011100";
            

            int[,] stateDizisi = new int[2,2];

            stateDizisi[0, 0] = 1;
            stateDizisi[0, 1] = 0;    // q0 final state 

            stateDizisi[1, 0] = 0;
            stateDizisi[1, 1] = 1;

            int sayi_ = 0;
            int stateNo = 0;
            for (int i = 0; i < girilenSayilar.Length; i++)
            {
                sayi_ = Convert.ToInt32(girilenSayilar[i]);
                stateNo = stateDizisi[stateNo, sayi_ - '0'];
            }

            if (stateNo == 0) Console.WriteLine("Otomata ++++ perfect ");
            else Console.WriteLine("input this otomata in is not found!!!");



            // Soru 
            // arka arkaya 3 sıfır gelirse otomata çalışmaz onun dişında tüm durumlarda çalışır

            // 111001110010 Çalışır  
            // 000110 çalışmaz
            // 01000 çalışmaz 


            int[,] qState = new int[4,2];
            string inputString = "1101001000";

            qState[0, 0] = 1;
            qState[0, 1] = 0;

            qState[1, 0] = 2;
            qState[1, 1] = 0;

            qState[2, 0] = 3;
            qState[2, 1] = 0;

            qState[3, 0] = 3;
            qState[3, 1] = 3;


            int qNo = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                qNo = qState[qNo, Convert.ToInt32(inputString[i])-'0'];
                if (qNo == 3)
                {
                    Console.WriteLine("Otomata Çalllşımaz not found");
                    break;
                }
            }

            if (qNo != 3) Console.WriteLine("Otomata çalıştıııııı yesssss ");









            // Soru 

            // abc def ghi den oluşan 9 harf var 

            // abc ' den bir tanesi gelecek 
            // def ' den bir tanesi gelecek 
            // ghi ' den bir tanesi gelecek 

            // a reddecek 
            // abdf reddecek 
            // adg kabul edecek
            // 

            // abc 'den bir tanesi geldiğinde başlamiş olacak bunlar dışında bir harf gellirse dead state'e gidecek 
            // daha sonra def 'den bir harf gelecek bunlar dışında bir harf gelirse dead state'e gidecek 
            // dongunun en sonunda da ghi' den bir tanesi gelecek eğer bunlar dışında bir harf gelirse dead state'e düşecek
            // ve dongu bitirilecek ve final state bu durumda olacak 


            string kumelerListesi = "abcdefghi";
            string inputDegerleri = "adgada"; // çalışır 
            int[,] qd = new int[5, 9];

            // state durumlarını ayarladık 

            // q0 'da iken 
            for (int i = 0; i < 9; i++)
            {
                if (i < 3) qd[0, i] = 1; // sonraki q1 state'ine gitmiş olacak
                if (i >= 3) qd[0, i] = 4; // 4 dead state'i temsil ediyor 
            }

            // q1' de iken 
            for (int i = 0; i < 9; i++)
            {
                if (i >= 3 && i < 5) qd[1, i] = 2;
                else qd[1, i] = 4; // dead State'e gidecek 
            }

            // q2' de iken 

            for (int i = 0; i < 9; i++)
            {
                if (i > 5) qd[2, i] = 3; // final State'e gelindi 
                else qd[2, i] = 4; // dead State'e gidecek 
            }

            // q3'de iken

            for (int i = 0; i < 9; i++)
            {
                if (i < 3) qd[3, i] = 1; // q1'e goturduk q0 a goturseydik eğer q1'e gitmek için abc'den birini tekrar kullanacaktık 
                else qd[3, i] = 4;
            }

            // q4'de iken 
            for (int i = 0; i < 9; i++)
            {
                qd[4, i] = 4;
            }



            // Run etme kodu

            int stateNerede = 0;
            for (int i = 0; i < inputDegerleri.Length; i++)
            {
                stateNerede = qd[stateNerede, inputDegerleri[i] - 'a'];
                if (stateNerede == 4)
                {
                    Console.WriteLine("Dead State'e düştü!!.");
                    break;
                }
            }
            if (stateNerede == 3) Console.WriteLine("Otomata Başarılı bir şekilde çalışıuototo ");
            else Console.WriteLine("Otomata çalışmıyor.");






            // Soru Bir tık zor soru 
            // 0 ve 1'in tanımlı olduğu bir kümemiz var
            // girilen binary sayının 5'e bölümünden kalan 2 olan sayilari bu otomatamız kabul edecektir 
            // state programlama yöntemi ile çözünüz 


            int[,] stateler = new int[5, 2];
            string binary = "1011110011001";

            stateler[0, 0] = 0;
            stateler[0, 1] = 1;

            stateler[1, 0] = 2; // Final State'imiz 2. state
            stateler[1, 1] = 3;

            stateler[2, 0] = 4;
            stateler[2, 1] = 0;

            stateler[3, 0] = 1;
            stateler[3, 1] = 2;

            stateler[4, 0] = 3;
            stateler[4, 1] = 4;


            int stateDurumNe = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                stateDurumNe = stateler[stateDurumNe, binary[i] - '0'];

            }
            switch (stateDurumNe)
            {
                case 0:
                    {
                        Console.WriteLine("{0} sayısının 5 ile bölümünden kalan {1}'dir", binary, stateDurumNe);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("{0} sayısının 5 ile bölümünden kalan {1}'dir",binary,stateDurumNe);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("{0} sayısının 5 ile bölümünden kalan {1}'dir",binary,stateDurumNe);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("{0} sayısının 5 ile bölümünden kalan {1}'dir", binary, stateDurumNe);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("{0} sayısının 5 ile bölümünden kalan {1}'dir", binary, stateDurumNe);
                        break;
                    }
                default:
                    break;
            }



            Console.ReadKey();
           

        }
    }
}
