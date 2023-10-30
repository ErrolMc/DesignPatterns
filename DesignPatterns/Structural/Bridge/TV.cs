
namespace DesignPatterns.Structural.Bridge
{
    // Concrete implementation
    public class TV : IDevice
    {
        private bool isOn;
        private int volume;

        public bool IsOn => isOn;

        public int Volume => volume;

        public void PrintStatus()
        {
            Console.WriteLine("[Bridge] TV is " + (isOn ? "on" : "off") + ", Volume: " + volume);
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("TV");
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("TV");
        }
    }
}
