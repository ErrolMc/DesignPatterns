
namespace DesignPatterns.Behavioral.Command
{
    // https://refactoring.guru/design-patterns/command
    public class CommandPatternRunner : PatternRunner
    {
        public override void Run()
        {
            Editor editor = new Editor();
            TextEditor textEditor = new TextEditor();

            Command copyCommand = new CopyCommand(editor);
            Command pasteCommand = new PasteCommand(editor);

            textEditor.ExecuteCommand(copyCommand);
            textEditor.ExecuteCommand(pasteCommand);

            Console.WriteLine("[Command] Undoing the last command:");
            textEditor.UndoLastCommand();
        }
    }
}
