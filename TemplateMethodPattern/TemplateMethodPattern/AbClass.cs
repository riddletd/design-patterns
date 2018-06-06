using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    abstract class AbClass
    {
        public void TemplateMethod()
        {
            operation1();
            operation2();
            operation3();
            operation4();
            operation5();
            operation6();
        }

        protected abstract void operation1();
        protected abstract void operation2();
        protected abstract void operation3();
        protected abstract void operation4();
        protected abstract void operation5();
        protected abstract void operation6();
    }
}
