
namespace DesignPatterns.Behavioral.Command
{
    // Concrete Command
    public class CopyCommand : Command
    {
        private string backup;

        public CopyCommand(Editor editor) : base(editor) 
        {
            backup = string.Empty;
        }

        public override void Execute()
        {
            backup = editor.GetClipboard();
            editor.Copy();
            hasExecuted = true;
        }

        public override void Undo()
        {
            if (hasExecuted)
            {
                Console.WriteLine("[Command] Undo Copy");

                editor.SetClipboard(backup);
                hasExecuted = false;
            }
        }
    }
}
