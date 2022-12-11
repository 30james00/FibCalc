using FibCalc.Services;

namespace FibCalc.UnitTests;

public class FibonacciServiceTests
{
    [TestCase(0UL, 0UL)]
    [TestCase(1UL, 1UL)]
    [TestCase(2UL, 1UL)]
    [TestCase(3UL, 2UL)]
    [TestCase(15UL, 610UL)]
    [TestCase(50UL, 12586269025UL)]
    public void Calculate_Values_FibonacciValue(ulong value, ulong expResult)
    {
        var fibonacci = FibonacciService.Calculate(value);

        Assert.AreEqual(expResult, fibonacci);
    }
}