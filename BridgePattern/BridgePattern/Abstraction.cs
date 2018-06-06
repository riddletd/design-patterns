using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Abstraction : AbAbstraction
    {
        IImplementor i;

        public Abstraction(IImplementor i) : base(i)
        {
            this.i = i;
        }

        public override void printAbstraction()
        {
            i.printType();
        }
    }
}
