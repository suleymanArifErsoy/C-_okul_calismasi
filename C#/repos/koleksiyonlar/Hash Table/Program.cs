using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Yeni değer ekleme
            Hashtable H1 = new Hashtable();
            H1.Add("House", "Ev");
            H1.Add("Car", "Araba");
            H1.Add("Cars", "Araba");
            //H1.Add("Cars", "Arabalar"); Key değeri benzersiz olmak zorundadır.
            #endregion

            #region  Yardımcı metotlar 
            bool kontrol1 = H1.Contains("House"); //Burada kontrol değeri true olarak okunur 
            bool koontrol2 = H1.Contains("Door"); //Burada kontrol değeri false olarak okunur.

            bool kontrol3 = H1.ContainsKey("House");
            bool kontrol4 = H1.ContainsValue("Araba");
            H1.Remove("Cars");
            H1.Clear();
            int kullanıcıiçindekitoplamdeğer = H1.Count;
            H1["House"] = "Villa";
            #endregion


        }
    }
}
    