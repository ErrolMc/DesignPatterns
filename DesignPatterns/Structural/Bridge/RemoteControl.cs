
namespace DesignPatterns.Structural.Bridge
{
    // Abstraction
    public abstract class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            Console.Write("[Bridge] Turning on the ");
            device.TurnOn();
        }

        public void TurnOff()
        {
            Console.Write("[Bridge] Turning off the ");
            device.TurnOff();
        }

        public void SetVolume(int volume)
        {
            Console.Write("[Bridge] Setting volume to ");
            device.SetVolume(volume);
        }

        public void PrintDeviceStatus()
        {
            Console.Write("[Bridge] " + device.GetType().Name + ": ");
            device.PrintStatus();
        }
    }
}
