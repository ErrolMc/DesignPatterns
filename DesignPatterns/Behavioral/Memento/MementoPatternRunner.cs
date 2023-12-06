
namespace DesignPatterns.Behavioral.Memento
{
    public class MementoPatternRunner : PatternRunner
    {
        public override void Run()
        {
            TextEditor editor = new TextEditor();
            TextHistory history = new TextHistory();

            editor.Text = "Hello, World!";
            history.SaveState(editor);

            editor.Text = "Design Patterns are awesome!";
            history.SaveState(editor);

            history.Undo(editor);
        }
    }
}
