using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class State2 : IState
    {
        Context c;

        public State2(Context c)
        {
            this.c = c;
        }

        public void transition1()
        {
            Console.WriteLine("Still in State2");
        }

        public void transition2()
        {
            Console.WriteLine("Still in State2");
        }

        public void transition3()
        {
            Console.WriteLine("Moved to in State3");
            this.c.changeState(new State3(c));
        }

        public void transition4()
        {
            Console.WriteLine("Still in State2");
        }
    }
}
