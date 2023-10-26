
namespace DesignPatterns.Architectural.AbstractFactory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
