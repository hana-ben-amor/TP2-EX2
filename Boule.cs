using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_P2
{
    internal class Boule : Forme
    {
        public double Rayon { get; private set; }

        public Boule(Point3D centreDeGravite, double rayon)
            : base(centreDeGravite)
        {
            Rayon = rayon;
        }

        public override void Bouger(double x, double y, double z)
        {
            CentreDeGravite = new Point3D(CentreDeGravite.X + x, CentreDeGravite.Y + y, CentreDeGravite.Z + z);
        }

        public override double CalculerSurface()
        {
            return 4 * Math.PI * Math.Pow(Rayon, 2);
        }

        public override double CalculerVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Rayon, 3);
        }

        public override bool Equals(object obj)
        {
            if (obj is Boule other)
            {
                return CentreDeGravite.Equals(other.CentreDeGravite) && Rayon == other.Rayon;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nrayon : {Rayon}";
        }
    }

}
