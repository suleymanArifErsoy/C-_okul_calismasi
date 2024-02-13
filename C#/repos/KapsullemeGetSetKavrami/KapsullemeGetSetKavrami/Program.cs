using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeGetSetKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Müsteri m1 = new Müsteri();
            m1.TcNo = "3b414359048";
            m1.isim = "suleyman";
            m1.Soyİsim = "Ersoy";
            Console.WriteLine(m1.EmailAdres);


        }
    }
}
