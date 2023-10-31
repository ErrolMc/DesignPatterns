
namespace DesignPatterns.Structural.Composite
{
    // Leaf
    public class File : FileSystemComponent
    {
        public File(string name) : base(name) { }

        public override void Print(string indent)
        {
            Console.WriteLine(indent + name);
        }
    }
}
