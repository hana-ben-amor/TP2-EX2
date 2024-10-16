using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(10.0, 4.0, 3.0);
            Console.WriteLine("Point 1 : " + point1);

            Boule boule1 = new Boule(point1, 5.0);
            Console.WriteLine("\nBoule 1 : " + boule1);
            Console.WriteLine("Surface de la boule : " + boule1.CalculerSurface());
            Console.WriteLine("Volume de la boule : " + boule1.CalculerVolume());

            Point3D point2 = new Point3D(2.0, 3.0, 4.0);
            Brique brique1 = new Brique(point2, 10.5, 14.3, 4.6);
            Console.WriteLine("\nBrique 1 : " + brique1);
            Console.WriteLine("Surface de la brique : " + brique1.CalculerSurface());
            Console.WriteLine("Volume de la brique : " + brique1.CalculerVolume());

            Cube cube1 = new Cube(point1, 6.0);
            Console.WriteLine("\nCube 1 : " + cube1);
            Console.WriteLine("Surface du cube : " + cube1.CalculerSurface());
            Console.WriteLine("Volume du cube : " + cube1.CalculerVolume());

            Boule boule2 = new Boule(new Point3D(10.0, 4.0, 3.0), 5.0);
            Console.WriteLine("\nBoules égales : " + (boule1.Equals(boule2) ? "Oui" : "Non"));

            brique1.Bouger(1.0, 1.0, 1.0);
            Console.WriteLine("\nAprès avoir bougé la brique : " + brique1);
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(); 

        }
    }
}
