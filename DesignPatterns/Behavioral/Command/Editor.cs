
namespace DesignPatterns.Behavioral.Command
{
    // Receiver
    public class Editor
    {
        private string clipboard = "";
        private string text = "";

        public void Copy()
        {
            Console.WriteLine("[Command] Copied to clipboard.");
            clipboard = "Text to be pasted";
        }

        public void Paste()
        {
            Console.WriteLine("[Command] Pasted from clipboard.");
            clipboard = "Text to be pasted";
        }

        public string GetClipboard() => clipboard;

        public string GetText() => text;

        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetClipboard(string text)
        {
            clipboard = text;
        }
    }
}
