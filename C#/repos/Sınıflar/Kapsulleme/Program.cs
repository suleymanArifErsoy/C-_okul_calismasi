using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Müşteri M1 = new Müşteri();
            M1.id = 1;
            M1.isim = "Süleyman Arif";
            M1.soyisim = "Ersoy";
            //Class
            //Field
            //Property
            //Get & Set
            //M1.emailAdres = "s.arifersoy61@gmail.com.";(Field)

            //genel olarak kapsulleme konusuna giriş yaptık 
            M1.EmailAdres = "s.arifersoy61@gmail.com.";
            Console.WriteLine(M1.EmailAdres);

            // 1. Field deger ataması yapılmasın ama deger okunabilsin.

            Console.WriteLine("Müsteri ID degeri=" + M1.ID.ToString());
            //M1.ID = 10; deger atama işlemi gerceklesmez.
        }
    }
}
