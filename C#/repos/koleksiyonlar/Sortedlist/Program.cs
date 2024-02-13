using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList SortedL = new SortedList();
            SortedL.Add(100, "yüz");
            SortedL.Add(1, "Bir");
            SortedL.Add(900, "dokuzyüz");
            /*SortedL.Add("a", "b");
             *Bu komutta bütün değişkenler ya bir sayı olacak ya da bir kelimeden oluşacak 
             *SortedList komutu verileri küçükten büyüğe doğru sıralar. 
             */ 

        }
    }
}
