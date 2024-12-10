namespace CalculatorApp.Tests;
public static class CustomAssertions
{
    public static void AssertIsPositive(int value)
    {
        Assert.That(value, Is.GreaterThan(0), "Value should be positive.");
    }
}
