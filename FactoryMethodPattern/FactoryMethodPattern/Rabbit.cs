using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Rabbit : Animal
    {
        public void printType()
        {
            Console.WriteLine("Rabbit");
        }
    }
}
