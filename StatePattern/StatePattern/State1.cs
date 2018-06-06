using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class State1 : IState
    {
        Context c;

        public State1(Context c)
        {
            this.c = c;
        }

        public void transition1()
        {
            Console.WriteLine("Still in State1");
        }

        public void transition2()
        {
            Console.WriteLine("Moved to in State2");
            this.c.changeState(new State2(c));
        }

        public void transition3()
        {
            Console.WriteLine("Still in State1");
        }

        public void transition4()
        {
            Console.WriteLine("Still in State1");
        }
    }
}
