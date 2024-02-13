using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HataYönetimi_Form
{
    class OperatorOverLoading
    {
        double lenght;
        double width;
        double height;

        public double getvolume()
        {
            return lenght * width * height;
        }
        public void setWidth(double wid)
        {
            width = wid;
        }
        public void setHeight(double heigh)
        {
            height = heigh;
        }
        public void setLength(double len)
        {
            lenght = len;
        }
        public static OperatorOverLoading operator+ (OperatorOverLoading c1, OperatorOverLoading c2)
        {
            OperatorOverLoading tempBox = new OperatorOverLoading();
            tempBox.setHeight = c1.setHeight + c2.setHeight;
            tempBox.setLength = c1.setLength + c2.setLength;
            tempBox.setWidth = c1.setWidth + c2.setWidth;
            return tempBox;
        }
    }
}
