namespace Patterns5.Correctors;

public class DashCorrector : ICorrector
{
    public string Correct(string text)
    {
        return text.Replace(" - ", " — ");
    }
}