
namespace DesignPatterns.Architectural.AbstractFactory
{
    // Abstract Product
    public interface ICheckBox
    {
        void Render();
        bool IsChecked();
        void SetChecked(bool value);
    }
}
