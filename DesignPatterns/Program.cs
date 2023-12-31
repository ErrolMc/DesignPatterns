﻿using DesignPatterns.Architectural.Builder;
using DesignPatterns.Architectural.FactoryMethod;
using DesignPatterns.Architectural.Prototype;
using DesignPatterns.Architectural.Singleton;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Proxy;

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
            RunBehavioral();
        }

        private void RunArchitectural()
        {
            Console.WriteLine("[ ---- Architectural Patterns ---- ]");

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
            Console.WriteLine("[ ---- Structural Patterns ---- ]");

            AdapterPatternRunner adapterPatternRunner = new AdapterPatternRunner();
            adapterPatternRunner.RunWithNewLine();

            BridgePatternRunner bridgePatternRunner = new BridgePatternRunner();
            bridgePatternRunner.RunWithNewLine();

            DecoratorPatternRunner decoratorPatternRunner = new DecoratorPatternRunner();
            decoratorPatternRunner.RunWithNewLine();

            CompositePatternRunner compositePatternRunner = new CompositePatternRunner();
            compositePatternRunner.RunWithNewLine();

            ProxyPatternRunner proxyPatternRunner = new ProxyPatternRunner();
            proxyPatternRunner.RunWithNewLine();
        }

        public void RunBehavioral()
        {
            Console.WriteLine("[ ---- Behavioral Patterns ---- ]");

            CommandPatternRunner commandPatternRunner = new CommandPatternRunner();
            commandPatternRunner.RunWithNewLine();

            ObserverPatternRunner observerPatternRunner = new ObserverPatternRunner();
            observerPatternRunner.RunWithNewLine();

            StatePatternRunner statePatternRunner = new StatePatternRunner();
            statePatternRunner.RunWithNewLine();

            StrategyPatternRunner strategyPatternRunner = new StrategyPatternRunner();
            strategyPatternRunner.RunWithNewLine();

            MementoPatternRunner mementoPatternRunner = new MementoPatternRunner();
            mementoPatternRunner.RunWithNewLine();

            IteratorPatternRunner iteratorPatternRunner = new IteratorPatternRunner();
            iteratorPatternRunner.RunWithNewLine();
        }
    }
}
