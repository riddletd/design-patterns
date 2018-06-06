using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Lollipop : Food
    {
        public void printType()
        {
            Console.WriteLine("Lollipop");
        }
    }
}
