
namespace DesignPatterns.Architectural.Builder
{
    // Director
    public class MSYDirector
    {
        public Computer BuildComputer(IComputerBuilder builder)
        {
            builder.SetCPU("Intel i7");
            builder.SetRAM("16GB");
            builder.SetStorage("512GB SSD");
            builder.SetGPU("NVIDIA RTX 3060");

            return builder.Build();
        }
    }
}
