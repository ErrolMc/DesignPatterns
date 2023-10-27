
namespace DesignPatterns.Architectural.Prototype
{
    // Prototype
    public interface IShape
    {
        void Draw();
        IShape Clone();
    }
}
