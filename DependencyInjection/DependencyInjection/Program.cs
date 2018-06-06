using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dependent sup = Dependent.create(new Dependency1());
            Dependent sup2 = Dependent.create(new Dependency2());

            sup.PrintSomthing();
            sup2.PrintSomthing();
        }
    }
}
