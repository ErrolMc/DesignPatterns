
namespace DesignPatterns.Architectural.AbstractFactory
{
    // Abstract Factory
    //  - Defines methods to create each of the abstract products
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
