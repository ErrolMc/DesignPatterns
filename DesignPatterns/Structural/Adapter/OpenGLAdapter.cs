
namespace DesignPatterns.Structural.Adapter
{
    // Adapter
    public class OpenGLAdapter : IGraphicsLibrary
    {
        private OpenGLGraphics openglGraphics = new OpenGLGraphics();

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            openglGraphics.DrawLine(x1, y1, x2, y2);
        }

        public void Initialize()
        {
            openglGraphics.OpenGLInitialize();
        }
    }
}
