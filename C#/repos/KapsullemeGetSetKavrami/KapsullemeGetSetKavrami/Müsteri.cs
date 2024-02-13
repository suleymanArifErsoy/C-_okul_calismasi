using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeGetSetKavrami
{
    class Müsteri
    {
        private const string emailSabiti = "@gmail.com";
        private string _tckimlikNo;
        public string TcNo
        {
            private get
            {
                return this._tckimlikNo;
            }
            set
            {
                if (value.Length==11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karekter = char.IsNumber(value[i]);  // char.IsNumber metodu icindeki degeri alır ve bu deger 
                        if (karekter)                            // hakkında kullanıcıya bu degerin sayısal olup olmadigini  
                        {                                       // bool degiskeni sayesinde geriye doner.
                            // sayısal bir deger 
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Tc kimlik numarasi icindeki degerler sayısal degerlerden farklidir.");
                    }
                    else
                    {
                        this._tckimlikNo = value;
                    }
                }
                else
                {
                    Console.WriteLine("İşlem yapmak için 11 haneli tc kimlik numarasi girmeniz gerekemektedir.");
                }
                

            }
        }
        public string isim;
        private string _soyisim;
        public string Soyİsim
        {
            get
            {
                return this._soyisim;
            }
            set
            {
                bool kontrol = false;
                for (int i = 0; i < value.Length; i++)
                {
                    bool karakter = char.IsLetter(value[i]); 
                    if (karakter)
                    {
                    }
                    else
                    {
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol)
                {
                    Console.WriteLine("Girdiginiz soyisim hatali girilmistir.Soyisimde sayi ve emoji olamaz...");
                }
                else
                {
                    this._soyisim = value;
                    this.emailAdres = emailAdresOlustuma();
                }
            }
        }
        private string emailAdres;
        public string EmailAdres
        {
            get
            {
                return this.emailAdres;
            }
            private set
            {
                this.emailAdres = value;
            }
        }
        private string emailAdresOlustuma()
        {
            string emailAdresolustur = string.Format("{0}.{1}{2}", isim, _soyisim,emailSabiti);
            return emailAdresolustur;
        }

    }
}
