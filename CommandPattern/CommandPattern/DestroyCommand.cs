using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class DestroyCommand : ICommand
    {
        IReceiver receiver;

        public DestroyCommand(IReceiver r)
        {
            receiver = r;
        }

        public void Execute()
        {
            receiver.Destroy();
        }

        public void Undo()
        {
            Console.WriteLine("Too late... The receiver is destroyed.");
        }
    }
}
