
namespace DesignPatterns.Structural.Adapter
{
    // Adaptee
    public class DirectXGraphics
    {
        public void DirectXInitialize()
        {
            Console.WriteLine("[Adapter] Initializing DirectX graphics.");
        }

        public void DirectXRender()
        {
            Console.WriteLine("[Adapter] Rendering using DirectX graphics.");
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("[Adapter] Drawing line using DirectX graphics.");
        }
    }
}
