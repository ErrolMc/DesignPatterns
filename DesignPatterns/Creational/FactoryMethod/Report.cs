using DesignPatterns.Architectural.FactoryMethod;
using System.Text;

namespace DesignPatterns.Architectural.FactoryMethod
{
    // Concrete Product
    public class Report : IDocument
    {
        public string CreateDocumentContents()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Report Header");
            stringBuilder.AppendLine("Report Body");

            return stringBuilder.ToString();
        }
    }
}
