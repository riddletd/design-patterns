using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class LightReceiver : IReceiver
    {
        public void On()
        {
            Console.WriteLine("Light On");
        }
        public void Off()
        {
            Console.WriteLine("Light Off");
        }
        public void Destroy()
        {
            Console.WriteLine("Light Destroyed");
        }
    }
}
