using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_P2
{
    internal abstract class Forme
    {
        public Point3D CentreDeGravite { get; protected set; }

        public Forme(Point3D centreDeGravite)
        {
            CentreDeGravite = centreDeGravite;
        }

        public abstract void Bouger(double x, double y, double z);
        public abstract double CalculerSurface();
        public abstract double CalculerVolume();

        public override string ToString()
        {
            return $"[{GetType().Name} centre de gravité : {CentreDeGravite}]";
        }
    }

}
