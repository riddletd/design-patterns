using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Class1 : AbClass
    {
        protected override void operation1()
        {
            Console.WriteLine("operation1");
        }

        protected override void operation2()
        {
            Console.WriteLine("operation2");
        }

        protected override void operation3()
        {
            Console.WriteLine("operation3");
        }

        protected override void operation4()
        {
            Console.WriteLine("operation4");
        }

        protected override void operation5()
        {
            Console.WriteLine("operation5");
        }

        protected override void operation6()
        {
            Console.WriteLine("operation6");
        }
    }
}
