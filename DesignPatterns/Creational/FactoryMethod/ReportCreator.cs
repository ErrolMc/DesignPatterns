using DesignPatterns.Architectural.FactoryMethod;

namespace DesignPatterns.Architectural.FactoryMethod
{
    // Concrete Creator
    public class ReportCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Report();
        }
    }
}
