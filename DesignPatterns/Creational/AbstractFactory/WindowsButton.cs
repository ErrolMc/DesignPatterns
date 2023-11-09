
namespace DesignPatterns.Architectural.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void AddCallback(Action callback)
        {
            Console.WriteLine("[AbstractFactory] Adding Windows Button callback");
        }

        public void Render()
        {
            Console.WriteLine("[AbstractFactory] Render Windows Button");
        }
    }
}
