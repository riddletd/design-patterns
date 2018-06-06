using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyClient
    {
        static void Main(string[] args)
        {
            IBehavior heyo = new Behavior1();
            IBehavior yo = new Behavior2();

            heyo.greeting();
            yo.greeting();
        }
    }
}
