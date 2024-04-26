using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Apres
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Machine machine = new Machine();

            Console.WriteLine("Employee:");
            employee.Work();

            Console.WriteLine("\nMachine:");
            machine.Work();
            Console.ReadKey();
        }
    }

}
