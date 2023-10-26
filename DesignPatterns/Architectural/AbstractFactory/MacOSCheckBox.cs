
namespace DesignPatterns.Architectural.AbstractFactory
{
    public class MacOSCheckBox : ICheckBox
    {
        private bool _checked = false;

        public bool IsChecked()
        {
            return _checked;
        }

        public void Render()
        {
            Console.WriteLine("[AbstractFactory] Render MacOS CheckBox");
        }

        public void SetChecked(bool value)
        {
            _checked = value;
        }
    }
}
