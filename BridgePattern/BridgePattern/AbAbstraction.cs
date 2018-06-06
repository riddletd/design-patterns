using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class AbAbstraction
    {
        IImplementor implementor;

        public AbAbstraction(IImplementor i)
        {
            implementor = i;
        }

        public abstract void printAbstraction();
    }
}
