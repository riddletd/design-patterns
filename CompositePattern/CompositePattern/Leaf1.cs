using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Leaf1 : IComponent
    {
        public string operation1()
        {
            return "Leaf1 operation1\n";
        }

        public string operation2()
        {
            return "Leaf1 operation2\n";
        }

        public string operation3()
        {
            return "Leaf1 operation3\n";
        }
    }
}
