using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_P2
{
    internal  class Cube : Brique
    {
        public Cube(Point3D centreDeGravite, double cote)
            : base(centreDeGravite, cote, cote, cote)
        {
        }
    }

}
