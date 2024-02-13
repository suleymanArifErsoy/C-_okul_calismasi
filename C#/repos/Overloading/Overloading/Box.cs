using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Box
    {
        double lenght;
        double breadth;
        double height;

        public double getVolume()
        {
            return lenght * breadth * height;
        }

        public void SetLength(double _leng)
        {
            lenght = _leng;
        }
        public void SetHeight(double _Heig)
        {
            height = _Heig;
        }
        public void Setbreadth(double _brea)
        {
            breadth = _brea;
        }
        public static Box operator+ (Box c1,Box c2)
        {
            Box tempBox = new Box();
            tempBox.height = c1.height + c2.height;
            tempBox.lenght = c1.lenght + c2.lenght;
            tempBox.breadth = c1.breadth + c2.breadth;
            return tempBox;
        }
        public static bool operator ==(Box c1, Box c2)
        {
            bool sonuc = false;
            if (c1.lenght== c2.lenght && c1.height==c2.height && c1.breadth==c2.breadth)
            {
                sonuc = true;
            }
            return sonuc;
        }
        public static bool operator !=(Box c1 ,Box c2)
        {
            bool sonuc = false;
            if(c1.lenght!=c2.lenght && c2.height!=c1.height && c1.breadth != c2.breadth)
            {
                sonuc = true;
            }
            return sonuc;  
        }
        public static bool operator <(Box c1,Box c2)
        {
            bool sonuc = false;
            if (c1.lenght < c2.lenght && c1.height < c2.height && c1.breadth < c2.breadth && c1.getVolume()<c2.getVolume())
            {
                sonuc = true;
            }
            return sonuc;
        }
        public static bool operator >(Box c1, Box c2)
        {
            bool sonuc = false;
            if (c1.lenght > c2.lenght && c1.height > c2.height && c1.breadth > c2.breadth && c1.getVolume()<c2.getVolume())
            {
                sonuc = true;
            }
            return sonuc;
        }
        public static bool operator >=(Box c1, Box c2 )
        {
            bool sonuc = false;
            if (c1.lenght >= c2.lenght && c2.height >= c1.height && c1.breadth >= c2.breadth)
            {
                sonuc = true;
            }
            return sonuc;
        }
        public static bool operator <=(Box c1, Box c2)
        {
            bool sonuc = false;
            if (c1.lenght <= c2.lenght && c2.height <= c1.height && c1.breadth <= c2.breadth)
            {
                sonuc = true;
            }
            return sonuc;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", lenght, height, breadth);   
        }

    }
}
