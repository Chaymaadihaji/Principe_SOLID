using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Avant
{
    using System;

    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }

    public class Triangle
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }

   /* class Program
    {
        static void Main(string[] args)
        {
            // Création d'instances de différentes formes géométriques
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4);

            // Appel des méthodes CalculateArea pour chaque forme et affichage du résultat
            Console.WriteLine("Aire du cercle : " + circle.CalculateArea());
            Console.WriteLine("Aire du rectangle : " + rectangle.CalculateArea());
            Console.WriteLine("Aire du triangle : " + triangle.CalculateArea());
            Console.ReadKey();
        }
    }
   */
}
