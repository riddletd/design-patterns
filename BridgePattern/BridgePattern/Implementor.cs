using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Implementor : IImplementor
    {
        public void printType()
        {
            Console.WriteLine("Yoyo! I'm of type Implementor!");
        }
    }
}
