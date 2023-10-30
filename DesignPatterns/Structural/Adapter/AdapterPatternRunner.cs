
namespace DesignPatterns.Structural.Adapter
{
    public class AdapterPatternRunner : PatternRunner
    {
        public override void Run()
        {
            IGraphicsLibrary openglAdapter = new OpenGLAdapter();
            IGraphicsLibrary directxAdapter = new DirectXAdapter();

            GameEngine openglGame = new GameEngine(openglAdapter);
            GameEngine directxGame = new GameEngine(directxAdapter);

            Console.WriteLine("[Adapter] OpenGL Game:");
            openglGame.StartEngine();

            Console.WriteLine("\n[Adapter] DirectX Game:");
            directxGame.StartEngine();
        }
    }
}
