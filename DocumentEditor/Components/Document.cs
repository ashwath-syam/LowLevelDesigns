using System.Text;
using DocumentEditor.Components.Definitions;

namespace DocumentEditor.Components
{
    public class Document
    {
        public List<IDocumentElement> Elements = [];

        public void AddElement(IDocumentElement element)
        {
            Elements.Add(element);
        }

        public string Render()
        {
            StringBuilder renderedContent = new();

            foreach (var element in Elements)
            {
                renderedContent.Append(element.Render());
            }

            return renderedContent.ToString();
        }
    }
}