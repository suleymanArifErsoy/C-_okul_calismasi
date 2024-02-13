using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {


            string kullancııseçimi = string.Empty;
            ArrayList Değerlistesi = new ArrayList();
            do
            {   
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1- Değer ekle");
                Console.WriteLine("2-Değer listele");
                Console.WriteLine("3-Değer ara");
                Console.WriteLine("4-Değer düzenle");
                Console.WriteLine("5-Değer sil");
                Console.WriteLine("6-Uygulama çıkış ");
                Console.Write("seçiniz: ");
                yanlışsayı:
                kullancııseçimi = Console.ReadLine();

                switch (kullancııseçimi)
                {
                    case ("1"):
                        Console.Write("Eklemek istediğiniz değeri giriniz: ");
                        string değerekle = Console.ReadLine();
                        Değerlistesi.Add(değerekle);
                        Console.WriteLine("Değerleriniz baaşrılı bir şekilde eklendi.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case ("2"):
                        for (int i = 0; i < Değerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0}.Değer= {1}", (i+1), Değerlistesi[i]);
                        }
                        Console.WriteLine("devam etmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                    case ("3"):
                        Console.WriteLine("Aramak istediğiniz değeri giriniz");
                        string aranandeğer = Console.ReadLine();
                        bool kontrol1 = Değerlistesi.Contains(aranandeğer);
                        if (kontrol1)
                        {

                            Console.WriteLine("Aradığınız değer başarıyla bulundu. ");
                            Console.WriteLine("Devam etmek için bir tuşa basınız.");
                            Console.ReadLine();                           
                        }
                        else
                        {
                            Console.WriteLine("Aradağınız değer bu listede bulunmamaktadır.Girdiğiniz değeri değer listesine eklemek isterseniz `e`tuşuna basınız istemezseniz `h`tuşuna basınız.");
                            string secim = Console.ReadLine();
                            if (secim=="e")
                            {
                                Değerlistesi.Add(aranandeğer);
                                Console.WriteLine("{0} değeri başarı ile kaydedildi.",aranandeğer);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else     
                            {
                                Console.WriteLine("Devam etmek için bir tuşa basınız.");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case ("4"):
                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz");
                        string kullancıdüzenlenecekdeğer = Console.ReadLine();
                        Console.WriteLine("{0} değerini hangi değer ile değiştirmek istiyorsunuz.",kullancıdüzenlenecekdeğer);
                        string kullanıcıyenideğer = Console.ReadLine();
                        if (Değerlistesi.Contains(kullancıdüzenlenecekdeğer))
                        {
                            int kullancıhedefindex = Değerlistesi.IndexOf(kullancıdüzenlenecekdeğer);
                            Değerlistesi[kullancıhedefindex] = kullanıcıyenideğer;
                            Console.WriteLine("değeriniz başarı ile güncellenmiştir.");
                        }
                        break;
                    case ("5"):
                        degerbulunamadı:
                        Console.WriteLine("Tüm değerleri mi silmek istersiniz (E/H). ");
                        string kullanıcısilcavap = Console.ReadLine();
                        if (kullanıcısilcavap.ToUpper()=="E")
                        {
                            Değerlistesi.Clear();
                            Console.WriteLine("tüm değerler başarıyla silinmiştir.");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediğiniz değeri giriniz.");
                            string kullanıcısilmekistenilendeğer = Console.ReadLine();
                            if (Değerlistesi.Contains(kullanıcısilmekistenilendeğer))
                            {
                                Değerlistesi.Remove(kullanıcısilmekistenilendeğer);
                                Console.WriteLine("Silmek istediğiniz değer başarı ile silinmiştir.");
                            }
                            else
                            {
                                Console.WriteLine("Girdiğiniz değer değerlistesinde bulunamadı.Lütfen tekrar deneyiniz.");
                                goto degerbulunamadı;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Giridğiniz sayı menü içerisinde yok. Lütfen tekar deneyiniz.");
                        goto yanlışsayı;
                        break;
                }
            } while (kullancııseçimi != "6");


        }
    }
}
