using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Apres
{
    using System;

    class Program
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

}
