using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class TemplateMethodClient
    {
        static void Main(string[] args)
        {
            AbClass a = new Class1();
            a.TemplateMethod();
        }
    }
}
