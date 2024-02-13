using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_konu_anlatımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q1 = new Queue();
            Q1.Enqueue("bir");
            Q1.Enqueue("iki");                    //  Enqueue komutu girilen dataları giriş sırasına göre sıralar
            Q1.Enqueue("üç");                     //  İlk giren ilk çıkar. 
            Q1.Enqueue("dört");

            object O1 = Q1.Peek();    // Datadan alınan değer ilk indexten alınır ve silinmez.
            object O2 = Q1.Dequeue(); // Datadan alınan değer ilk indexten alınır ve silinir.
        }
    }
}
