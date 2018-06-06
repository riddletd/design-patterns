using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ObserverClient
    {
        static void Main(string[] args)
        {
            IObservable food = new Observable1(new List<IObserver>());

            food.Add(new Observer1());
            food.Add(new Observer1());
            food.Add(new Observer2());
            food.Add(new Observer1());
            food.Add(new Observer2());

            food.Notify("pecans");
            food.Notify("biscuits");
            food.Notify("bananas");
        }
    }
}
