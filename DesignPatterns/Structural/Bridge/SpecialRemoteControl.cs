
namespace DesignPatterns.Structural.Bridge
{
    // Refined abstraction
    public class SpecialRemoteControl : RemoteControl
    {
        int lastMuteVolume;
        bool muted = false;

        public SpecialRemoteControl(IDevice device) : base(device)
        {
            muted = false;
        }

        public void Mute()
        {
            if (!device.IsOn || muted) return;

            lastMuteVolume = device.Volume;
            muted = true;

            device.SetVolume(0);

            Console.WriteLine("[Bridge] Mute: " + device.GetType().Name);
        }

        public void UnMute()
        {
            if (!device.IsOn || !muted) return;

            device.SetVolume(lastMuteVolume);
            muted = false;

            Console.WriteLine("[Bridge] UnMuted: " + device.GetType().Name);
        }
    }
}
