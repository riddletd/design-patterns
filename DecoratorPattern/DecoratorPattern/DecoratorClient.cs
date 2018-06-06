using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DecoratorClient
    {
        static void Main(string[] args)
        {
            Beverage CaramelEspresso = new Mocha(new Caramel(new Espresso()));
            Console.WriteLine(CaramelEspresso.Cost());
        }
    }
}
