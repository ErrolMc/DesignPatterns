
namespace DesignPatterns.Behavioral.Memento
{
    // Originator
    public class TextEditor
    {
        private string text = "";

        public string Text
        {
            get 
            { 
                return text; 
            }
            set
            {
                Console.WriteLine($"[Memento] Setting text to: {value}");
                text = value;
            }
        }

        public TextMemento Save()
        {
            Console.WriteLine("[Memento] Saving state");
            return new TextMemento(text);
        }

        public void Restore(TextMemento memento)
        {
            text = memento.Text;
            Console.WriteLine($"[Memento] Restored to state: {text}");
        }
    }
}
