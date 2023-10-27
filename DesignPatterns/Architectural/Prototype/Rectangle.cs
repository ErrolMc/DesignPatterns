
namespace DesignPatterns.Architectural.Prototype
{
    // Concrete Prototype
    public class Rectangle : IShape
    {
        public string Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(string color, int width, int height)
        {
            Color = color;
            Width = width;
            Height = height;
        }

        public IShape Clone()
        {
            return new Rectangle(Color, Width, Height);
        }

        public void Draw()
        {
            Console.WriteLine($"[Prototype] Drawing a {Color} rectangle with dimensions {Width}x{Height}.");
        }
    }
}
