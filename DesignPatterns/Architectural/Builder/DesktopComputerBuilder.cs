
namespace DesignPatterns.Architectural.Builder
{
    // Concrete Builder
    public class DesktopComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public DesktopComputerBuilder()
        {
            computer = new Computer();
        }

        public void SetCPU(string CPU)
        {
            computer.CPU = CPU;
        }

        public void SetGPU(string GPU)
        {
            computer.GPU = GPU;
        }

        public void SetRAM(string RAM)
        {
            computer.RAM = RAM;
        }

        public void SetStorage(string Storage)
        {
            computer.Storage = Storage;
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
