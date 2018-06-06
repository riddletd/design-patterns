using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TurnOnCommand : ICommand
    {
        IReceiver receiver;

        public TurnOnCommand(IReceiver r)
        {
            receiver = r;
        }

        public void Execute()
        {
            receiver.On();
        }

        public void Undo()
        {
            receiver.Off();
        }
    }
}
