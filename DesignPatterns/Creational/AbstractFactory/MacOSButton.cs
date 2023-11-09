
namespace DesignPatterns.Architectural.AbstractFactory
{
    internal class MacOSButton : IButton
    {
        public void AddCallback(Action callback)
        {
            Console.WriteLine("[AbstractFactory] Adding MacOS Button callback");
        }

        public void Render()
        {
            Console.WriteLine("[AbstractFactory] Render MacOS Button");
        }
    }
}
