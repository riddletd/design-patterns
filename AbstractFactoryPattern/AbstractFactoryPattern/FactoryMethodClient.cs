using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class FactoryMethodClient
    {
        static void Main(string[] args)
        {
            AnimalFactory rf = new RandomFactory();
            for (int i = 0; i < 50; i++)
            {
                Animal a = rf.FactoryMethod();
                a.printType();
            }
        }
    }
}
