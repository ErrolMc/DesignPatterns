using DesignPatterns.Architectural.FactoryMethod;

namespace DesignPatterns.Architectural.FactoryMethod
{
    // Concrete Creator
    public class ResumeCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Resume();
        }
    }
}
