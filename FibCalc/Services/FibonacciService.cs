namespace FibCalc.Services;

public static class FibonacciService
{
    public static ulong Calculate(ulong value)
    {
        if (value == 0) return 0;
        if (value == 1) return 1;
        ulong a = 0;
        ulong b = 1;
        for (ulong i = 2; i <= value; i++)
        {
            var c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}