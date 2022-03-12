namespace Patterns5.Correctors;

public class WrongSpaceCorrector : ICorrector
{
    public string Correct(string text)
    {
        return text
            .Replace("( ", "(")
            .Replace(" )", ")")
            .Replace(" ,", ",")
            .Replace(" .", ".")
            .TrimEnd(' ');
    }
}