
namespace DesignPatterns.Structural.Composite
{
    // Composite
    public class Folder : FileSystemComponent
    {
        private List<FileSystemComponent> children;

        public Folder(string name) : base(name) 
        {
            children = new List<FileSystemComponent>();
        }

        public void AddChild(FileSystemComponent child)
        {
            if (!children.Contains(child))
                children.Add(child);
        }

        public void RemoveChild(FileSystemComponent child)
        {
            if (children.Contains(child))
                children.Remove(child);
        }

        public override void Print(string indent)
        {
            Console.WriteLine(indent + name + " (Folder)");
            foreach (var child in children)
            {
                child.Print(indent + "  ");
            }
        }
    }
}
