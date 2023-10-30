
namespace DesignPatterns.Structural.Bridge
{
    // https://refactoring.guru/design-patterns/bridge
    public class BridgePatternRunner : PatternRunner
    {
        public override void Run()
        {
            IDevice tv = new TV();
            IDevice radio = new Radio();

            RemoteControl tvRemote = new StandardRemoteControl(tv);
            RemoteControl radioRemote = new StandardRemoteControl(radio);

            tvRemote.TurnOn();
            tvRemote.SetVolume(20);
            tvRemote.PrintDeviceStatus();

            radioRemote.TurnOn();
            radioRemote.SetVolume(10);
            radioRemote.PrintDeviceStatus();

            tvRemote.TurnOff();
            tvRemote.PrintDeviceStatus();

            radioRemote.TurnOff();
            radioRemote.PrintDeviceStatus();

            SpecialRemoteControl specialTVRemote = new SpecialRemoteControl(tv);
            specialTVRemote.TurnOn();
            specialTVRemote.Mute();
            specialTVRemote.UnMute();
        }
    }
}
