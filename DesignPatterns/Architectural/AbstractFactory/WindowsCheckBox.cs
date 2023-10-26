
namespace DesignPatterns.Architectural.AbstractFactory
{
    public class WindowsCheckBox : ICheckBox
    {
        private bool _checked = false;

        public bool IsChecked()
        {
            return _checked;
        }

        public void Render()
        {
            Console.WriteLine("[AbstractFactory] Render Windows CheckBox");
        }

        public void SetChecked(bool value)
        {
            _checked = value;
        }
    }
}
