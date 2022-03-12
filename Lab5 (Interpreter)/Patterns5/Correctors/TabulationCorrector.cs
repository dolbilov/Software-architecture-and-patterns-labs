namespace Patterns5.Correctors;

public class TabulationCorrector : ICorrector
{
    public string Correct(string text)
    {
        while (text.Contains("\t\t"))
        {
            text = text.Replace("\t\t", "\t");
        }

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == '\n' && text[i + 1] != '\t')
            {
                text = text.Insert(i + 1, "\t");
            }
        }

        return text;
    }
}