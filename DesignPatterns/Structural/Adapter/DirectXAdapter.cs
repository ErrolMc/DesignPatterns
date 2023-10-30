
namespace DesignPatterns.Structural.Adapter
{
    // Adapter
    class DirectXAdapter : IGraphicsLibrary
    {
        private DirectXGraphics directXGraphics = new DirectXGraphics();

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            directXGraphics.DrawLine(x1, y1, x2, y2);
        }

        public void Initialize()
        {
            directXGraphics.DirectXInitialize();
        }
    }
}
