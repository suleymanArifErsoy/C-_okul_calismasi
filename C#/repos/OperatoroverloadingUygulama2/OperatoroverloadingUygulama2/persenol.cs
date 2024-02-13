using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoroverloadingUygulama2
{
    class persenol
    {
        public decimal maas;

        public static persenol operator+(persenol b1,persenol b2)
        {
            persenol temp = new persenol();
            temp.maas = b1.maas + b2.maas;
            return temp;
        }
    }
}
