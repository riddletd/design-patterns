using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Subject : ISubject
    {
        public void request()
        {
            Console.WriteLine("I'm the thing you want!");
        }
    }
}
