using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Invoker
    {
        ICommand on;
        ICommand off;
        ICommand destroy;

        public Invoker(ICommand on, ICommand off, ICommand destroy)
        {
            this.on = on;
            this.off = off;
            this.destroy = destroy;
        }

        public void On()
        {
            on.Execute();
        }

        public void Off()
        {
            off.Execute();
        }

        public void Destroy()
        {
            destroy.Execute();
        }
    }
}
