using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Observable1 : IObservable
    {
        private List<IObserver> observer;

        public Observable1(List<IObserver> o)
        {
            observer = o;
        }

        public void Add(IObserver o)
        {
            observer.Add(o);
        }

        public void Remove(IObserver o)
        {
            observer.Remove(o);
        }

        public void Notify(string message)
        {
            foreach(IObserver o in observer)
            {
                o.Update(message);
            }
        }
    }
}
