
namespace DesignPatterns.Structural.Decorator
{
    // https://refactoring.guru/design-patterns/decorator
    public class DecoratorPatternRunner : PatternRunner
    {
        public override void Run()
        {
            Coffee espresso = new Espresso();
            Console.WriteLine("[Decorator] Order: " + espresso.Description);
            Console.WriteLine("[Decorator] Cost: $" + espresso.Cost());

            Coffee houseBlend = new HouseBlend();
            houseBlend = new Milk(houseBlend);
            houseBlend = new Sugar(houseBlend);

            Console.WriteLine("\n[Decorator] Order: " + houseBlend.Description);
            Console.WriteLine("[Decorator] Cost: $" + houseBlend.Cost());
        }
    }
}
