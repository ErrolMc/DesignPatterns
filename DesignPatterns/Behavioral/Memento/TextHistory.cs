
namespace DesignPatterns.Behavioral.Memento
{
    // Caretaker
    public class TextHistory
    {
        private List<TextMemento> history = new List<TextMemento>();

        public void SaveState(TextEditor editor)
        {
            history.Add(editor.Save());
        }

        public void Undo(TextEditor editor)
        {
            if (history.Count > 0)
            {
                TextMemento memento = history[history.Count - 1];
                editor.Restore(memento);
                history.RemoveAt(history.Count - 1);
            }
        }
    }
}
