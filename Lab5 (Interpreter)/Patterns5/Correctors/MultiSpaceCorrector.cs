namespace Patterns5.Correctors;

public class MultiSpaceCorrector : ICorrector
{
    public string Correct(string text)
    {
        while (text.Contains("  "))
        {
            text = text.Replace("  ", " ");
        }

        return text;
    }
}