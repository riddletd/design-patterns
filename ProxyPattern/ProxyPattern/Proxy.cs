using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Proxy : ISubject
    {
        ISubject subject;
        bool condition;

        public Proxy(ISubject subject, bool condition)
        {
            this.subject = subject;
            this.condition = condition;
        }
        public void request()
        {
            if (condition)
            {
                subject.request();
            }
            else
            {
                Console.WriteLine("You do not have access to this object!");
            }
        }
    }
}
