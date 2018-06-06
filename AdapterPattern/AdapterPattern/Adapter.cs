using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adapter : ITarget
    {
        Adaptee adaptee;

        public Adapter(Adaptee a)
        {
            adaptee = a;
        }

        public void request()
        {
            adaptee.specificRequest();
        }
    }
}
