namespace Patterns5.Correctors;

public class MultiEnterCorrector : ICorrector
{
    public string Correct(string text)
    {

        while (text.Contains("\n\n"))
        {
            text = text.Replace("\n\n", "\n");
        }
        
        while (text.Contains("\n\r\n\r"))
        {
            text = text.Replace("\n\r\n\r", "\n\r");
        }

        while (text.Contains("\r\n\r\n"))
        {
            text = text.Replace("\r\n\r\n", "\r\n");
        }

        return text;
    }
}