using DesignPatterns.Architectural.FactoryMethod;
using System.Text;

namespace DesignPatterns.Architectural.FactoryMethod
{
    // Concrete Product
    public class Resume : IDocument
    {
        public string CreateDocumentContents()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Resume Header");
            stringBuilder.AppendLine("Past work experience");
            stringBuilder.AppendLine("References");

            return stringBuilder.ToString();
        }
    }
}
