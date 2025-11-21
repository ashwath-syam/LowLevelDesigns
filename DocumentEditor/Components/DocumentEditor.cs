using DocumentEditor.Components;
using DocumentEditor.Components.Definitions;
using DocumentEditor.Components.Implementations;

namespace DocumentEditor.Components
{
    public class DocumentEditor(Document document)
    {
        private readonly Document _document = document;

        public void AddText(string text)
        {
            _document.AddElement(new TextElement(text));
        }

        public void AddImage(string url)
        {
            _document.AddElement(new ImageElement(url));
        }

        public void AddNewLine()
        {
            _document.AddElement(new NewLineElement());
        }
        
    }
}