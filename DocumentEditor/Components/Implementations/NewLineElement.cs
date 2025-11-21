using DocumentEditor.Components.Definitions;

namespace DocumentEditor.Components.Implementations
{
    public class NewLineElement : IDocumentElement
    {

        public string Render()
        {
            return "\n";
        }
    }
}