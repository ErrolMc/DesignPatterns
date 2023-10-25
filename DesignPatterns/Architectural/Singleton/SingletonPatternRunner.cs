using DesignPatterns;
using System;

namespace DesignPatterns.Architectural.Singleton
{
    // https://refactoring.guru/design-patterns/singleton 

    public class SingletonPatternRunner : PatternRunner
    {
        public override void Run()
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            bool areTheSame = singleton1.Equals(singleton2);

            Console.WriteLine("[Singleton] Are singleton1 and singleton2 the same? " + areTheSame);
        }
    }
}
