
namespace DesignPatterns
{
    public abstract class PatternRunner
    {
        public abstract void Run();

        public void RunWithNewLine()
        {
            Run();
            Console.WriteLine();
        }
    }
}
