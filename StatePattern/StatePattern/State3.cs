using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class State3 : IState
    {
        Context c;

        public State3(Context c)
        {
            this.c = c;
        }

        public void transition1()
        {
            Console.WriteLine("Still in State3");
        }

        public void transition2()
        {
            Console.WriteLine("Still in State3");
        }

        public void transition3()
        {
            Console.WriteLine("Still in State3");
        }

        public void transition4()
        {
            Console.WriteLine("Moved to in State4");
            this.c.changeState(new State4(c));
        }
    }
}
