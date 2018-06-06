using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adaptee
    {
        internal void specificRequest()
        {
            Console.WriteLine("I'm a specific request in the Adaptee class called from the Adapter!");
        }
    }
}
