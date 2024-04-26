using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Apres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un rectangle
            Shape rectangle = new Rectangle(4, 5);
            Console.WriteLine("Rectangle : Width = " + ((Rectangle)rectangle).Width + ", Height = " + ((Rectangle)rectangle).Height);
            Console.WriteLine("Area = " + rectangle.Area());

            // Création d'un carré
            Shape square = new Square(4);
            Console.WriteLine("Square : Side = " + ((Square)square).Side);
            Console.WriteLine("Area = " + square.Area()); // Cela devrait afficher l'aire du carré
            Console.ReadKey();
        }
    }
