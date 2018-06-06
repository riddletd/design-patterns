using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StateClient
    {
        static void Main(string[] args)
        {
            Context context = new Context(new State1(new Context()));

            context.transition1();
            context.transition2();
            context.transition3();
            context.transition1();
            context.transition4();
            context.transition2();
            context.transition1();
        }
    }
}
