using DocumentEditor.Components.Definitions;

namespace DocumentEditor.Components.Implementations
{
    public class FileStorage : IPersistence
    {
        public void Save(string data)
        {
            File.WriteAllText("Document.txt", data);
            Console.WriteLine("Data saved to Document.txt");
        }
    }
}