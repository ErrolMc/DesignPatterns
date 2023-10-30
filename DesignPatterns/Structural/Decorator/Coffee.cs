
namespace DesignPatterns.Structural.Decorator
{
    // Component
    public abstract class Coffee
    {
        public abstract string Description { get; }
        public abstract double Cost();
    }
}
