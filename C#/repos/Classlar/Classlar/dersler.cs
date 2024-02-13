using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Dersler
    {
        public int id { get; set; }
        public  string derskodu { get; set; }
        public string dersAdı { get; set; }
        public int AKTS { get; set; }
        public int kredi { get; set; }
        public int yıl { get; set; }
        public string donem{ get; set; }
        public double vizeNotu { get; set; }
        public double finalNotu { get; set; }
        public const int VizeYuzdesi = 40;
        public const int finalYuzdesi = 60;
        public const int gecmeNotu = 50;
        public Akademikpersonel dersiveren { set; get; }

        public Dersler(int _id)
        {
            this.id = _id;
        }

        public double ortalamahesap()
        {

            double ort = 0;
            ort = ((vizeNotu * VizeYuzdesi) + (finalNotu * finalYuzdesi)) / 2;
            return ort;
        }
        public Boolean DersGecme()
        {
            double ort = ortalamahesap();
            if (ort>gecmeNotu)
            {
                return true;            }
            else
            {
                return false;
            }
        }

    }
}
