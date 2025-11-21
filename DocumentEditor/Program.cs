using DocumentEditor.Components;
using DocumentEditor.Components.Implementations;

namespace DocumentEditor;

public class DocumentEditorClient
{
    public static void Main()
    {
        var document = new Document();
        var editor = new Components.DocumentEditor(document);
        var storage = new FileStorage();

        editor.AddText("Hello, World!");
        editor.AddNewLine();
        editor.AddImage("http://example.com/image.png");
        editor.AddNewLine();
        editor.AddText("This is a sample document.");

        var result = document.Render();
        Console.WriteLine($"\n{result}\n");
        storage.Save(result);
    }
}