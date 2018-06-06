using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Context
    {
        IState state;

        public Context()
        {
            state = new State1(this);
        }

        public Context(IState state)
        {
            this.state = state;
        }

        public void changeState(IState s)
        {
            state = s;
        }

        public void transition1()
        {
            state.transition1();

        }

        public void transition2()
        {
            state.transition2();
        }

        public void transition3()
        {
            state.transition3();
        }

        public void transition4()
        {
            state.transition4();
        }
    }
}
