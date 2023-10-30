
namespace DesignPatterns.Architectural.Prototype
{
    // https://refactoring.guru/design-patterns/prototype
    public class PrototypePatternRunner : PatternRunner
    {
        public override void Run()
        {
            IShape originalCircle = new Circle("Red", 10);
            IShape clonedCircle = originalCircle.Clone();

            IShape originalRectangle = new Rectangle("Blue", 5, 8);
            IShape clonedRectangle = originalRectangle.Clone();

            originalCircle.Draw();
            clonedCircle.Draw();
            originalRectangle.Draw();
            clonedRectangle.Draw();
        }
    }
}
