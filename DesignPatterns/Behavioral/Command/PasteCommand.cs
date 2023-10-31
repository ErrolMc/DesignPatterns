
namespace DesignPatterns.Behavioral.Command
{
    // Concrete Command
    public class PasteCommand : Command
    {
        private string backup;

        public PasteCommand(Editor editor) : base(editor) 
        {
            backup = string.Empty;
        }

        public override void Execute()
        {
            backup = editor.GetText();
            editor.Paste();
            hasExecuted = true;
        }

        public override void Undo()
        {
            if (hasExecuted)
            {
                Console.WriteLine("[Command] Undo Paste");

                editor.SetText(backup);
                hasExecuted = false;
            }
        }
    }
}
