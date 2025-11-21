using DocumentEditor.Components.Definitions;

namespace DocumentEditor.Components.Implementations
{
    public class TextElement(string text) : IDocumentElement
    {
        private readonly string _text = text;

        public string Render()
        {
            return _text;
        }
    }
}