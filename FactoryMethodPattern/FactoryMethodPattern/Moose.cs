using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Moose : Animal
    {
        public void printType()
        {
            Console.WriteLine("Moose");
        }
    }
}
