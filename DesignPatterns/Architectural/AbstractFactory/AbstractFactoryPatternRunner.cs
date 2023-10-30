
namespace DesignPatterns.Architectural.AbstractFactory
{
    // https://refactoring.guru/design-patterns/abstract-factory
    public class AbstractFactoryPatternRunner : PatternRunner
    {
        public override void Run()
        {
            IGUIFactory windowsFactory = new WindowsFactory();
            IButton windowsButton = windowsFactory.CreateButton();
            ICheckBox windowsCheckBox = windowsFactory.CreateCheckBox();
            windowsCheckBox.SetChecked(false);
            windowsButton.AddCallback(() => Console.WriteLine("Windows button pressed"));
            windowsButton.Render();
            windowsCheckBox.Render();

            IGUIFactory macOSFactory = new MacOSFactory();
            IButton macOSButton = macOSFactory.CreateButton();
            ICheckBox macOSCheckBox = macOSFactory.CreateCheckBox();
            macOSCheckBox.SetChecked(true);
            macOSButton.AddCallback(() => Console.WriteLine("MacOS button pressed"));
            macOSButton.Render();
            macOSCheckBox.Render();
        }
    }
}
