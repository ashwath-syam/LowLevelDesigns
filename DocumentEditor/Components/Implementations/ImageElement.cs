using DocumentEditor.Components.Definitions;

namespace DocumentEditor.Components.Implementations
{
    public class ImageElement(string imagePath) : IDocumentElement
    {
        private readonly string _imagePath = imagePath;

        public string Render()
        {
            return _imagePath;
        }
    }
}