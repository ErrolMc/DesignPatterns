using DesignPatterns.Architectural.FactoryMethod;
using System.Text;

namespace DesignPatterns.Architectural.FactoryMethod
{
    // Creator, can also be an interface, but as an abstract class this can also perform some business logic
    public abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();

        public string CreateDocumentContentsWithDateFooter()
        {
            IDocument document = CreateDocument();

            StringBuilder stringBuilder = new StringBuilder(document.CreateDocumentContents());
            stringBuilder.AppendLine("-- " + DateTime.Now + " --");

            return stringBuilder.ToString();
        }
    }
}
