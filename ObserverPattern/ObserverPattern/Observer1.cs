using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Observer1 : IObserver
    {
        private string message;

        public void Update(string message)
        {
            this.message = message;
            ResponseToUpdate();
        }

        public void ResponseToUpdate()
        {
            Console.WriteLine("Blah... I hate " + message + "...");
        }
    }
}
