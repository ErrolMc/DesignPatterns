
namespace DesignPatterns.Structural.Decorator
{
    // Concrete Component
    public class HouseBlend : Coffee
    {
        public override string Description => "House Blend Coffee";
        public override double Cost() => 0.89;
    }
}
