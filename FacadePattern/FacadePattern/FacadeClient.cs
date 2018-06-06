using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class FacadeClient
    {
        static void Main(string[] args)
        {
            Facade f = new Facade(
                new Class1(),
                new Class2(),
                new Class3()
                );

            f.Class1Method1();
            f.Class1Method2();
            f.Class1Method3();

            f.Class2Method1();
            f.Class2Method2();
            f.Class2Method3();

            f.Class3Method1();
            f.Class3Method2();
            f.Class3Method3();
        }
    }
}
