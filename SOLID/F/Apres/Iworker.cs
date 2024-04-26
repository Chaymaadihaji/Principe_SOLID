using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Apres
{
    // Après ISP
    public interface IWorker
    {
        void Work();
        void Rest();
    }

    public interface IMachine
    {
        void Work();
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

    public class Machine : IMachine
    {
        public void Work()
        {
            Console.WriteLine("Machine is working.");
        }
    }

}
// a revoir 
