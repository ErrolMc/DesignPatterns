
namespace DesignPatterns.Structural.Decorator
{
    // Decorator
    public abstract class CondimentDecorator : Coffee
    {
        protected Coffee coffee;

        public CondimentDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public override string Description => coffee.Description;
    }
}
