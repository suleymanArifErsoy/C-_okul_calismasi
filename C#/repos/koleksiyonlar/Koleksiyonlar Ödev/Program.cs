using System;
using System.Collections;

namespace Koleksiyonlar_Ödev
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
                Console.WriteLine("MEnü");
                Console.WriteLine("1- Değer ekle");
                Console.WriteLine("2-Değer listele");
                Console.WriteLine("3-Değer ara");
                Console.WriteLine("4-Değer düzenle");
                Console.WriteLine("5-Değer sil");
                Console.WriteLine("6-Uygulama çıkış ");
                Console.Write("seçiniz: ");
                kullancııseçimi = Console.ReadLine();

                switch (kullancııseçimi)
                {
                    case ("1"):
                        Console.Write("Eklemek istediğiniz değeri giriniz: ");
                        string değerekle = Console.ReadLine();
                        Değerlistesi.Add(değerekle);
                        break;
                    case ("2"):
                        break;
                    case ("3"):
                        break;
                    case ("4"):
                        break;
                    case ("5"):
                        break;
                    case ("6"):
                        break;
                    default:
                        break;
                }
            } while (kullancııseçimi != "6");

        }
    }
}
