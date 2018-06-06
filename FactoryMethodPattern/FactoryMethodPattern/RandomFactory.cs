using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class RandomFactory : AnimalFactory
    {
        public Animal FactoryMethod()
        {
            Random r = new Random();
            System.Threading.Thread.Sleep(r.Next(1, 100));
            int rnd = r.Next(1, 4);

            switch(rnd)
            {
                case 1:
                    return new Giraffe();
                case 2:
                    return new Rabbit();
                case 3:
                    return new Moose();
                default:
                    return new Giraffe();
            }
        }
    }
}
