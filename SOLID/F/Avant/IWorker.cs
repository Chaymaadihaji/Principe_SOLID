using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Avant
{
    // Avant ISP
    public interface IWorker
    {
        void Work();
        void Rest();
    }

    public class Employee : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Employee is working.");
        }

        public void Rest()
        {
            Console.WriteLine("Employee is resting.");
        }
    }

    public class Machine : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Machine is working.");
        }

        public void Rest()
        {
            Console.WriteLine("Machine is resting."); // Les machines n'ont pas besoin de se reposer !
        }
    }

}
