using System.Text;

namespace Patterns5.Correctors;

public class QuoteCorrector : ICorrector
{
    public string Correct(string _text)
    {
        StringBuilder text = new StringBuilder(_text);
        bool first = true;
        int firstIndex = -1;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '"')
            {
                if (first)
                {
                    first = false;
                    firstIndex = i;
                }
                else
                {
                    first = true;
                    
                    text[firstIndex] = '«';
                    text[i] = '»';
                    firstIndex = -1;
                }
            }
        }

        return text.ToString();
    }
}