
namespace DesignPatterns.Structural.Composite
{
    // Component
    public abstract class FileSystemComponent
    {
        protected string name;

        public FileSystemComponent(string name)
        {
            this.name = name;
        }

        public abstract void Print(string indent);
    }
}
