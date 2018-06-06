using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Dependency1 : IDependency
    {
        void IDependency.PrintSomething()
        {
            Console.WriteLine("Dependency1 was injected!");
        }
    }
}
