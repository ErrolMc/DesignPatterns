
namespace DesignPatterns.Structural.Decorator
{
    // Concrete Decorator
    public class Milk : CondimentDecorator
    {
        public Milk(Coffee coffee) : base(coffee) { }

        public override string Description => coffee.Description + ", Milk";
        public override double Cost() => coffee.Cost() + 0.25;
    }
}
