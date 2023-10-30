
namespace DesignPatterns.Structural.Adapter
{
    // Adaptee
    public class OpenGLGraphics
    {
        public void OpenGLInitialize()
        {
            Console.WriteLine("[Adapter] Initializing OpenGL graphics.");
        }

        public void OpenGLRender()
        {
            Console.WriteLine("[Adapter] Rendering using OpenGL graphics.");
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("[Adapter] Drawing line using OpenGL graphics.");
        }
    }
}
