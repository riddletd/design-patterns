using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class CompositeClient
    {
        static void Main(string[] args)
        {
            IComponent c = new Composite1(new Composite2(new Composite1(new Leaf1())));

            Console.WriteLine(c.operation1());
            Console.WriteLine(c.operation2());
            Console.WriteLine(c.operation3());
        }
    }
}
