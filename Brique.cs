using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_P2
{
    internal class Brique : Forme
    {
        public double Largeur { get; private set; }
        public double Longueur { get; private set; }
        public double Hauteur { get; private set; }

        public Brique(Point3D centreDeGravite, double largeur, double longueur, double hauteur)
            : base(centreDeGravite)
        {
            Largeur = largeur;
            Longueur = longueur;
            Hauteur = hauteur;
        }

        public override void Bouger(double x, double y, double z)
        {
            CentreDeGravite = new Point3D(CentreDeGravite.X + x, CentreDeGravite.Y + y, CentreDeGravite.Z + z);
        }

        public override double CalculerSurface()
        {
            return 2 * (Largeur * Longueur + Largeur * Hauteur + Longueur * Hauteur);
        }

        public override double CalculerVolume()
        {
            return Largeur * Longueur * Hauteur;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nlargeur : {Largeur}\nlongueur : {Longueur}\nhauteur : {Hauteur}";
        }
    }

}
