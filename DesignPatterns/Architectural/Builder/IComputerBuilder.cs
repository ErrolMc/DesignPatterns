
namespace DesignPatterns.Architectural.Builder
{
    // Builder
    public interface IComputerBuilder
    {
        void SetCPU(string CPU);
        void SetRAM(string RAM);
        void SetGPU(string GPU);
        void SetStorage(string Storage);
        Computer Build();
    }
}
