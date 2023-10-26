using DesignPatterns.Architectural.Builder;
using DesignPatterns.Architectural.FactoryMethod;
using DesignPatterns.Architectural.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        #region main
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        #endregion

        public void Run()
        {
            RunArchitectural();
        }

        private void RunArchitectural()
        {
            SingletonPatternRunner singletonPatternRunner = new SingletonPatternRunner();
            singletonPatternRunner.RunWithNewLine();

            FactoryMethodPatternRunner factoryMethodPatternRunner = new FactoryMethodPatternRunner();
            factoryMethodPatternRunner.RunWithNewLine();

            BuilderPatternRunner builderPatternRunner = new BuilderPatternRunner();
            builderPatternRunner.RunWithNewLine();
        }
    }
}
