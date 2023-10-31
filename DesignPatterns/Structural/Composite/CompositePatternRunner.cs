
namespace DesignPatterns.Structural.Composite
{
    // https://refactoring.guru/design-patterns/composite
    public class CompositePatternRunner : PatternRunner
    {
        public override void Run()
        {
            var root = new Folder("Root");
            var documents = new Folder("Documents");
            var file1 = new File("Document1.txt");

            root.AddChild(documents);
            documents.AddChild(file1);

            var music = new Folder("Music");
            var file2 = new File("Song1.mp3");

            documents.AddChild(music);
            music.AddChild(file2);

            Console.WriteLine("[Composite]");
            root.Print("");
        }
    }
}
