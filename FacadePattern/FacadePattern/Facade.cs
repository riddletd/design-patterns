using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Facade
    {
        Class1 class1;
        Class2 class2;
        Class3 class3;

        public Facade(Class1 c1, Class2 c2, Class3 c3)
        {
            class1 = c1;
            class2 = c2;
            class3 = c3;
        }

        public void Class1Method1()
        {
            class1.Method1();
        }

        public void Class1Method2()
        {
            class1.Method2();
        }

        public void Class1Method3()
        {
            class1.Method3();
        }

        public void Class2Method1()
        {
            class2.Method1();
        }

        public void Class2Method2()
        {
            class2.Method2();
        }

        public void Class2Method3()
        {
            class2.Method3();
        }

        public void Class3Method1()
        {
            class3.Method1();
        }

        public void Class3Method2()
        {
            class3.Method2();
        }

        public void Class3Method3()
        {
            class3.Method3();
        }
    }
}
