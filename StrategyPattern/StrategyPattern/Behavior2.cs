using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Behavior2 : IBehavior
    {
        public void greeting()
        {
            Console.WriteLine("Yo yo yo!");
        }
    }
}
