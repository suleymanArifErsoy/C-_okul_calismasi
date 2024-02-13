using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeÖdev
{
    public class Müsteri
    {
        private string _tckimliknuamrası;
        public string TCKimlikNumarası
        {
            get
            {
                return _tckimliknuamrası.Substring(0,3);
            }
            set
            {
                if (value.Length==11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            //sayısal deger girilmiş demektir...
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("TC kimlik numarsı sadece sayısal degerlerden oluşmaktadır.");
                    }
                    else
                    {
                        this._tckimliknuamrası = value;     
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır!!");
                }
            }
        } 



    }
}
