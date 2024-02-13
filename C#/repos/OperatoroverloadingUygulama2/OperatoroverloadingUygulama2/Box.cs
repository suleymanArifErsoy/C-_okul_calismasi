using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoroverloadingUygulama2
{
    class Box
    {
        public  Box[] dizi { get; set; }
        public int width;
        public int height;


        public static Box operator+ (Box c1,Box c2)
        {
            Box temp = new Box();
            temp.height = c1.height + c2.height;
            temp.width = c1.width + c2.width;

            return temp;
        }
        public static Box operator *(Box c1, Box c2)
        {
            Box temp = new Box();
            temp.height = c1.height * c2.height;
            temp.width = c1.width * c2.width;

            return temp;
        }
    }
}
