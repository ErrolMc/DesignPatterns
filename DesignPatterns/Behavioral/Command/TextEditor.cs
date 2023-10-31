
namespace DesignPatterns.Behavioral.Command
{
    // Invoker
    public class TextEditor
    {
        private List<Command> history;

        public TextEditor()
        {
            history = new List<Command>();
        }

        public void ExecuteCommand(Command command)
        {
            history.Add(command);
            command.Execute();
        }

        public void UndoLastCommand()
        {
            if (history.Count > 0)
            {
                Command lastCommand = history[history.Count - 1];
                lastCommand.Undo();
                history.RemoveAt(history.Count - 1);
            }
        }
    }
}
