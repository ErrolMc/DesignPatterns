
namespace DesignPatterns.Structural.Decorator
{
    // Concrete Decorator
    public class Sugar : CondimentDecorator
    {
        public Sugar(Coffee coffee) : base(coffee) { }

        public override string Description => coffee.Description + ", Sugar";
        public override double Cost() => coffee.Cost() + 0.10;
    }
}
