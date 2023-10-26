
namespace DesignPatterns.Architectural.AbstractFactory
{
    // Abstract Product
    public interface IButton
    {
        void Render();
        void AddCallback(System.Action callback);
    }
}
