using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class AbstractFactoryClient
    {
        static void Main(string[] args)
        {
            Factory a = new RandomFactory();
            Animal b = a.GetAnimal();
            b.printType();

            Console.WriteLine("eats a");

            Factory f = new RandomFactory();
            Food c = f.GetFood();
            c.printType();
        }
    }
}
