using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface Factory
    {
        Animal GetAnimal();
        Food GetFood();
    }
}
