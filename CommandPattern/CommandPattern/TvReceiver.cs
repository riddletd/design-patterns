using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TvReceiver : IReceiver
    {
        public void On()
        {
            Console.WriteLine("TV On");
        }
        public void Off()
        {
            Console.WriteLine("TV Off");
        }
        public void Destroy()
        {
            Console.WriteLine("TV Destroyed");
        }
    }
}
