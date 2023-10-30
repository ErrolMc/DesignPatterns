
namespace DesignPatterns.Structural.Bridge
{
    // Concrete implementation
    public class Radio : IDevice
    {
        private bool isOn;
        private int volume;

        public bool IsOn => isOn;

        public int Volume => volume;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Radio");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Radio");
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
        }

        public void PrintStatus()
        {
            Console.WriteLine("Radio is " + (isOn ? "on" : "off") + ", Volume: " + volume);
        }
    }
}
