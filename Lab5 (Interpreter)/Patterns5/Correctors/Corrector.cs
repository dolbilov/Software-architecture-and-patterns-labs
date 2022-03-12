namespace Patterns5.Correctors;

public class Corrector : ICorrector
{
    private readonly List<ICorrector> _correctors;

    public Corrector()
    {
        _correctors = new List<ICorrector>()
        {
            new MultiSpaceCorrector(),
            new WrongSpaceCorrector(),
            new MultiEnterCorrector(),
            new DashCorrector(),
            new TabulationCorrector(),
            new QuoteCorrector()
        };
    }

    public string Correct(string text)
    {

        foreach (var corrector in _correctors)
        {
            text = corrector.Correct(text);
        }

        return text;
    }
}