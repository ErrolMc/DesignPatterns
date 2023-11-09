using DesignPatterns.Architectural.FactoryMethod;
using DesignPatterns;

namespace DesignPatterns.Architectural.FactoryMethod
{
    // https://refactoring.guru/design-patterns/factory-method
    public class FactoryMethodPatternRunner : PatternRunner
    {
        public override void Run()
        {
            DocumentCreator reportCreator = new ReportCreator();
            IDocument report = reportCreator.CreateDocument();
            string reportContents = report.CreateDocumentContents();

            DocumentCreator resumeCreator = new ResumeCreator();
            IDocument resume = resumeCreator.CreateDocument();
            string resumeContents = resume.CreateDocumentContents();

            // can have the creator do other stuff too
            string resumeContentsWithFooter = resumeCreator.CreateDocumentContentsWithDateFooter();

            Console.WriteLine("[Factory Method] Report contents: \n" + reportContents.TrimEnd('\n'));
            Console.WriteLine("[Factory Method] Resume contents: \n" + resumeContents.TrimEnd('\n'));
            Console.WriteLine("[Factory Method] Resume contents with footer: \n" + resumeContentsWithFooter.TrimEnd('\n'));
        }
    }
}
