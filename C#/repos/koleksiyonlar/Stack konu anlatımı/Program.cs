using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_konu_anlatımı
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack S1 = new Stack();

            S1.Push("bir");             
            S1.Push("iki");                 
            S1.Push("üç");                          // Push komutu ile girilen değerleri en son hangi değer eklendiyse başa alacak şekilde kayıt eder.
            S1.Push("dört");                        // En son giren ilk çıkar.

            object o1 = S1.Peek();  //Peek komutu en son eklenen datayı gönderir ve gönderilen data listeden çıkarılır.
            object o2 = S1.Pop();   //Pop komutu en son eklenen datayı gönderir ve gönderilen data listeden çıkarılamz.   
        }
    }
}
