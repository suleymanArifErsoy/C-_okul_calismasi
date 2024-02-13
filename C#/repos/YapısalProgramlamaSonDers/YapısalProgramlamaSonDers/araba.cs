using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapısalProgramlamaSonDers
{
    class marka : Metal
    {
        public override string arabasesi()
        {
            return $"saaapppşlalalaa";
        }
    }
    class lambo : araba
    {
        public override string arabasesi()
        {
            return $"supaaraaaaa";
        }
    }
    class araba:Metal
    {
        public override  string arabasesi()
        {
            return $"BAsssss";
        }
    }
}
