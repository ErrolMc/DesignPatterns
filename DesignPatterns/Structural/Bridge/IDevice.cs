
namespace DesignPatterns.Structural.Bridge
{
    // Implementation
    public interface IDevice
    {
        bool IsOn { get; }
        int Volume { get; }
        void TurnOn();
        void TurnOff();
        void SetVolume(int volume);
        void PrintStatus();
    }
}
