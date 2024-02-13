using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Musteri
    {
        //Yapıcı Metotlar (ctor yaz çift tab yap)

        public Musteri()
        {

        }
        public Musteri(string _isim,string _soyisim)
        {
            İsim = _isim;
            soyisim = _soyisim;
        }
        public Musteri(string _Tckimlikno,string _isim,string _soyisim)
        {
            TcKimlikNumarası = _Tckimlikno;
            İsim = _isim;
            soyisim = _soyisim;
        }
        public Musteri(string _isim)
        {
            İsim = _isim;
        }

        public string TcKimlikNumarası;
        public string İsim;
        public string soyisim;
        public int    Cinsiyet;// 717770001=bay  - 71777  0002=bayan


    }
}
