
namespace DesignPatterns.Architectural.Builder
{
    public class BuilderPatternRunner : PatternRunner
    {
        // https://refactoring.guru/design-patterns/builder
        public override void Run()
        {
            MSYDirector director = new MSYDirector();
            IComputerBuilder builder = new DesktopComputerBuilder();

            Computer computer = director.BuildComputer(builder);

            Console.WriteLine("[Builder] Desktop Computer Specs:");
            Console.WriteLine("[Builder] CPU: " + computer.CPU);
            Console.WriteLine("[Builder] RAM: " + computer.RAM);
            Console.WriteLine("[Builder] Storage: " + computer.Storage);
            Console.WriteLine("[Builder] GPU: " + computer.GPU);
        }
    }
}
