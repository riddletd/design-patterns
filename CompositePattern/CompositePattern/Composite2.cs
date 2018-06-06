using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite2 : IComponent
    {
        IComponent component;

        public Composite2(IComponent c)
        {
            component = c;
        }

        public string operation1()
        {
            return component.operation1() + "Composite2 operation1\n";
        }

        public string operation2()
        {
            return component.operation2() + "Composite2 operation2\n";
        }

        public string operation3()
        {
            return component.operation3() + "Composite2 operation3\n";
        }
    }
}
