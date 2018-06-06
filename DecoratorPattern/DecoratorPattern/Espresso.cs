using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {
        public override double Cost()
        {
            return 1.5;
        }
    }
}
