
namespace DesignPatterns.Structural.Adapter
{
    // Target
    public interface IGraphicsLibrary
    {
        void Initialize();
        void DrawLine(int x1, int y1, int x2, int y2);
    }
}
