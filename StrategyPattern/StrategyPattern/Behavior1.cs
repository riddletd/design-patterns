using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Behavior1 : IBehavior
    {
        public void greeting()
        {
            Console.WriteLine("Heyo!");
        }
    }
}
