
namespace DesignPatterns.Architectural.Prototype
{
    // Concrete Prototype
    public class Circle : IShape
    {
        public string Color { get; set; }
        public int Radius { get; set; }

        public Circle(string color, int radius)
        {
            Color = color;
            Radius = radius;
        }

        public IShape Clone()
        {
            return new Circle(Color, Radius);
        }

        public void Draw()
        {
            Console.WriteLine($"[Prototype] Drawing a {Color} circle with radius {Radius}.");
        }
    }
}
