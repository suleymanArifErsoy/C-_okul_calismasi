using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUyglulamsı
{
    public static class Helper
    {
        public static void emailGönder(string aliciEmail,string konu,string içerik)
        {
            // Static olarak işaretlenmiş olan classlar orneklendirlemez.
            //Helper H1=new Helper();
            /*
             public void Test()
            {
            
            
            }
            1- Static olan classlar icerisinde standart metotlar kullanılamaz.(static olmayan)
            
              public string Tanim {  get; set; }
               
            2- Static olan classlar icerisine static olmayan field tanımı yapilamaz.

             
             */

            //public Helper()
            //{
            //3- Her nesne ornegi alındıgında uygulama standart yapıcı metodunu calıstırır.
            //} 

            //Email gonderme işlemi devam edecek...
            Console.WriteLine("Emailiniz basari ile gonderilmistir... :)");
        } 
        static Helper()
        {
            // Uygulama icersinde istenidigi kadar cagrilsinlar sadece bir kez calisirlar.
        }

    }
}
