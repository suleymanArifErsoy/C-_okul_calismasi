using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace net.fraemworkArrayList 
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int capacity;

            ArrayList A1 = new ArrayList();

            #region tek işlem ekleme
            A1.Add("Süleyman arif");
            capacity = A1.Capacity;
            count = A1.Count;
            A1.Add(100);
            #endregion

            #region  birden fazla işlem ekleme
            ArrayList A2 = new ArrayList();
            A2.Add("YAKUP");
            A2.Add("MEHEMT");
            A1.AddRange(A2);
            #endregion

            #region capacity & count inceleme 
            capacity = A1.Capacity;
            count = A1.Count;
            #endregion

            #region Koleksiyon içindeki değere ulaşma 

            object o1 = A1[3];
            string s1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Hamza";
            #endregion

            #region ArrayListde sıralama
            //dizinin mevcut elemanlarını ters sıralama
            A1.Reverse();
            // A-Z sıralama
            A1.Sort(); // A`dan Z`ye sıralarken koleksiyonun içinde int değer olmaaması lazım!! Bu yüzden burada hata aldık.
            #endregion

            #region koleksiyonlar yardımcı komutlar
            
            object[] D1 = A1.ToArray();// A1 koleksiyonunu diziye çevirir.
            int indexDeğeri = A1.IndexOf("Yakup");// `indexof` komutu istenilen objenin indeks değerini bulmamızı sağlar.
            bool kontrol1 = A1.Contains("Yakup");// burada bool değeri true olur 
            bool kontrol2 = A1.Contains(250); // burada bool 250 değerini A1 koleksiyonu içinde bulamaz ve false değerini verir.
            A1.Clear();// A1 koleksiyonundaki tüm verileri siler .
            A1.TrimToSize();// A1 koleksiyonunun Kapasitesini ayarlar.

            #endregion

            #region arraylist içerisindeki değeri silme
            A1.RemoveAt(3);// 3.indeksi siler. 
            A1.RemoveRange(2, 2);// 2.indeksten başlayıp 2 tane değer siler. 
            A1.Remove("hamza");// A1 arrayListindeki hamza objesini bulur ve siler.
            #endregion

            #region 10 elemanlı (String) ArrayList içindeki değerleri Z-A olacak şekilde sıralayınız.

            ArrayList B1 = new ArrayList();
            B1.Add("ali");
            B1.Add("betül");
            B1.Add("mehmet");
            B1.Add("arif");
            B1.Add("zeynep");
            B1.Add("ömer");
            B1.Add("berra"); 
            B1.Add("hülya");
            B1.Add("zekiye");
            B1.Add("ayşe");
            B1.Sort();
            B1.Reverse();
            #endregion
        }
    }
}
