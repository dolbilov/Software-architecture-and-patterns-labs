using Patterns5.Correctors;

namespace Patterns5;

public static class Program
{
    private const string Prefix = "../../../res/";
    private const string OriginalTextFileName = Prefix + "original.txt";
    private const string FormattedTextFileName = Prefix + "formatted.txt";

    private static void Main()
    {
        try
        {
            if (!File.Exists(OriginalTextFileName))
            {
                throw new FileNotFoundException("File with original text not found");
            }

            using var originalFile = new StreamReader(OriginalTextFileName);
            var text = originalFile.ReadToEnd();

            Corrector corrector = new();
            text = corrector.Correct(text);

            using var FormattedFile = new StreamWriter(FormattedTextFileName);
            FormattedFile.Write(text);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Text was formatted.");
            Console.ResetColor();
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Some error occurred: {e.Message}");
            Console.ResetColor();

            Environment.Exit(-1);
        }
    }
}