using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class State4 : IState
    {
        Context c;

        public State4(Context c)
        {
            this.c = c;
        }

        public void transition1()
        {
            Console.WriteLine("Moved to in State1");
            this.c.changeState(new State1(c));
        }

        public void transition2()
        {
            Console.WriteLine("Still in State4");
        }

        public void transition3()
        {
            Console.WriteLine("Still in State4");
        }

        public void transition4()
        {
            Console.WriteLine("Still in State4");
        }
    }
}
