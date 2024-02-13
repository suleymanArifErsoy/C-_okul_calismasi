using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statick_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static:Nesne ornegi alınmadan ulasabildiğimiz field,metot,sınıf...
            //Tip M1=new M1();
            //Tip.

            //stack bolgede pointerımız olustu.
            Ogrenci O1;
            //stack bolgede pointer olustugu zaman statick olan yapıcı metot calıstı ve yine class icerisnde tanımlı olan static field,metot static
            //dediğimiz bolgede olusturuldu 
            Ogrenci.Test2();// Test1 metoduna ulasılmıyor.
            
            O1 = new Ogrenci();
            // stack bolgede pointer => kendisini heap bölgeye tanımladı... Static olmayan tanımlarını tamamladı..
            O1.Test1();// nesne ornegi alındıktan sonra Test1 metoduna ulasabildim.


         }
    }
}
