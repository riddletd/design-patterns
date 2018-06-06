using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Caramel : AddonDecorator
    {
        private Beverage beverage;

        public Caramel(Beverage b)
        {
            beverage = b;
        }
        public override double Cost()
        {
            return beverage.Cost() + 1.0;
        }
    }
}
