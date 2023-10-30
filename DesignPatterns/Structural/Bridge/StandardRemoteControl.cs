using System;

namespace DesignPatterns.Structural.Bridge
{
    // Refined abstraction
    public class StandardRemoteControl : RemoteControl
    {
        public StandardRemoteControl(IDevice device) : base(device)
        {

        }
    }
}
