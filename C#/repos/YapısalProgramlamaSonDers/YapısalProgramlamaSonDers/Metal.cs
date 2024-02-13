using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaSonDers
{
    class Metal
    {
        public string marka { get;set; }
        public string benzin { get; set; }
        public int MetalFiyati { get; set; }

        public virtual string  arabasesi()
        {
            return $"seeesss";
        }

    }
}
