using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable icerisine ENG-TR olarak data eklememiz.
            /*
             *  Yeni kayıt eklemek istiyormusunuz E/H
             *  E:Yeni kayıt ekleme işlemi devam etsin
             *  H: Tüm listeyi yazdırın
             *  
             *  Var olan bir değeri ekliyorsa kullanıcıya bu değer daha önceden kayıt bulunmaktadır.
             */

            Hashtable sozluk = new Hashtable();
            do
            {
                Console.Clear();
                Console.WriteLine("kaydetmek istediğiniz ingilizce kelimeyi yazınız.");
                Console.Write("EN:");
                string ing = Console.ReadLine();

                bool kontrol = sozluk.ContainsKey(ing);
                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmaktadır.{1} değerinin türkçe karşılığıdır.",ing,sozluk[ing].ToString());

                }
                else
                {
                    Console.WriteLine("{0} ingilizce değerinin türkçe karşılığını yazınız.",ing);
                    Console.Write("TR: ");
                    string tr = Console.ReadLine();
                    sozluk.Add(ing, tr);
                    Console.WriteLine("Değer ekleme işlemi başarılı.");

                }
                Console.WriteLine("Yeni kayıt eklemek istermisiniz. (E/H)");

            } while (Console.ReadLine().ToUpper()!="H");

            foreach (var item in sozluk.Keys)
            {
                Console.WriteLine("EN: {0} == TR: {1}", item, sozluk[item]);
            }
            Console.ReadLine();



        }
    }
}
