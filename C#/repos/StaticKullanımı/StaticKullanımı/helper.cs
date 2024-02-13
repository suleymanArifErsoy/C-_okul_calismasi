using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKullanımı
{
    public static class helper
    {
        // Static olarak isaretlenmiş classlar örneklenemez..
        // helper h1=new helper(); 
        /*
            public void test()
        {
            Static olan classlar icerisinde standart(static olamayan) metotlar kullanılamaz...
        }
        public string Tanim{ get; set;}
        *Static olan classlar icerisinde standart field tanimi yapılamaz... 

         */



        /*public helper()
        {
            Her nesne örneği alindiginda uygulama standart yapıcı metodu çalıştırır...
        }
        */
        static helper()
        {
            // Uygulama içerisinde istenildiği kadar cağrılsınlar sadece ilk çağırılmada çalışırlar !!!
        }



    }
}
