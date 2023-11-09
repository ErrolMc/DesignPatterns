
namespace DesignPatterns.Architectural.AbstractFactory
{
    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacOSCheckBox();
        }
    }
}
