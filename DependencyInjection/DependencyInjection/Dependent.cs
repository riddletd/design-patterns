using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{

    class Dependent
    {
        IDependency injectedClass;

        private Dependent(IDependency inject)
        {
            injectedClass = inject;
        }

        public static Dependent create(IDependency inject)
        {
            return new Dependent(inject);
        }

        public void PrintSomthing()
        {
            injectedClass.PrintSomething();
        }
    }
}
