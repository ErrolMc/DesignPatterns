using DesignPatterns.Architectural.Builder;
using DesignPatterns.Architectural.FactoryMethod;
using DesignPatterns.Architectural.Prototype;
using DesignPatterns.Architectural.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Decorator;

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
            RunStructural();
        }

        private void RunArchitectural()
        {
            Console.WriteLine("Architectural Patterns:");

            SingletonPatternRunner singletonPatternRunner = new SingletonPatternRunner();
            singletonPatternRunner.RunWithNewLine();

            FactoryMethodPatternRunner factoryMethodPatternRunner = new FactoryMethodPatternRunner();
            factoryMethodPatternRunner.RunWithNewLine();

            BuilderPatternRunner builderPatternRunner = new BuilderPatternRunner();
            builderPatternRunner.RunWithNewLine();

            PrototypePatternRunner prototypePatternRunner = new PrototypePatternRunner();
            prototypePatternRunner.RunWithNewLine();
        }

        public void RunStructural()
        {
            Console.WriteLine("Structural Patterns:");

            AdapterPatternRunner adapterPatternRunner = new AdapterPatternRunner();
            adapterPatternRunner.RunWithNewLine();

            BridgePatternRunner bridgePatternRunner = new BridgePatternRunner();
            bridgePatternRunner.RunWithNewLine();

            DecoratorPatternRunner decoratorPatternRunner = new DecoratorPatternRunner();
            decoratorPatternRunner.RunWithNewLine();
        }
    }
}
