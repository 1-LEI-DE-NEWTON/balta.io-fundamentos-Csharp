using System.Text;

namespace EditorHtml;

public class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-----------------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();
        do
        {
            file.Append(Console.ReadLine());
            file.Append((Environment.NewLine));
        } while (Console.ReadKey().Key != ConsoleKey.Delete);
        Console.WriteLine("-----------------");
        Console.WriteLine("Deseja salvar o arquivo?");
        Viewer.Show(file.ToString());
    }
}