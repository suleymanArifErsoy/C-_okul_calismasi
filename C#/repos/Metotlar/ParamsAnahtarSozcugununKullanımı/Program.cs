using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsAnahtarSozcugununKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {


            topla(11, 12, 45, 96, 23);
        }
        static void topla(params int[] sayılar) /*params anahtar sozcugunden sonra başka bir deger istenirse hata verir.
                                                 * Eğer baska bir değişken almamız gerekirse params anahtar sozcugunden önce yazmamımız gerekir.
                                                 */
        {
            int toplam = 0;
            for (int i = 0; i < sayılar.Length; i++)
            {
                toplam+= sayılar[i];
            }
            Console.WriteLine("Toplam: " + toplam);

        }
    }
}
