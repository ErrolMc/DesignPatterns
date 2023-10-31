
namespace DesignPatterns.Behavioral.Command
{
    // Command
    public abstract class Command
    {
        protected Editor editor;
        protected bool hasExecuted = false;

        public Command(Editor editor)
        {
            this.editor = editor;
            hasExecuted = false;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
