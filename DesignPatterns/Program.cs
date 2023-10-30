using DesignPatterns.Architectural.Builder;
using DesignPatterns.Architectural.FactoryMethod;
using DesignPatterns.Architectural.Prototype;
using DesignPatterns.Architectural.Singleton;
using DesignPatterns.Structural.Adapter;

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

            PrototypePatternRunner prototypePatternRunner = new PrototypePatternRunner();
            prototypePatternRunner.RunWithNewLine();

            AdapterPatternRunner adapterPatternRunner = new AdapterPatternRunner();
            adapterPatternRunner.RunWithNewLine();
        }
    }
}
