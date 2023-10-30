
namespace DesignPatterns.Structural.Decorator
{
    // Concrete Component
    public class Espresso : Coffee
    {
        public override string Description => "Espresso";
        public override double Cost() => 1.99;
    }
}
