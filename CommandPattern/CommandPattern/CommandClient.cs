using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CommandClient
    {
        static void Main(string[] args)
        {
            Invoker lightSwitch = new Invoker(
                new TurnOnCommand(new LightReceiver()), 
                new TurnOffCommand(new LightReceiver()), 
                new DestroyCommand(new LightReceiver())
                );

            Invoker tvRemote = new Invoker(
                new TurnOnCommand(new TvReceiver()),
                new TurnOffCommand(new TvReceiver()),
                new DestroyCommand(new TvReceiver())
                );

            lightSwitch.On();
            lightSwitch.Off();
            lightSwitch.Destroy();

            tvRemote.On();
            tvRemote.Off();
            tvRemote.Destroy();
        }
    }
}
