using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite1 : IComponent
    {
        IComponent component;

        public Composite1(IComponent c)
        {
            component = c;
        }

        public string operation1()
        {
            return component.operation1() + "Composite1 operation1\n";
        }

        public string operation2()
        {
            return component.operation2() + "Composite1 operation2\n";
        }

        public string operation3()
        {
            return component.operation3() + "Composite1 operation3\n";
        }
    }
}
