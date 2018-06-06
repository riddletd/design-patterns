using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class ProxyClient
    {
        static void Main(string[] args)
        {
            ISubject proxySubject = new Proxy(new Subject(), true);
            proxySubject.request();

            proxySubject = new Proxy(new Subject(), false);
            proxySubject.request();
        }
    }
}
