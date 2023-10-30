
namespace DesignPatterns.Structural.Adapter
{
    public class GameEngine
    {
        private IGraphicsLibrary graphicsLibrary;

        public GameEngine(IGraphicsLibrary graphicsLibrary) 
        { 
            this.graphicsLibrary = graphicsLibrary;
        }

        public void StartEngine()
        {
            graphicsLibrary.Initialize();
            graphicsLibrary.DrawLine(0, 0, 10, 10);
        }
    }
}
