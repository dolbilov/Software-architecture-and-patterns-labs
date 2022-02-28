+namespace Patterns3;

public static class Rnd
{
    private static readonly Random _random = new();

    public static int RandomInt(int min, int max)
    {
        return _random.Next(min, max);
    }
}