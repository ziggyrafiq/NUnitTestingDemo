namespace CalculatorApp.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ValidInputs_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(8), "It is expected that the Add method will return the sum of two integers.");
    }

    [Test]
    public void Divide_ValidInputs_ReturnsQuotient()
    {
        // Arrange
        int dividend = 10;
        int divisor = 2;

        // Act
        int result = _calculator.Divide(dividend, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(5), "It is expected that the Divide method returns the quotient of the division.");
    }

    [Test]
    public void Divide_DivisorIsZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 10;
        int divisor = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(dividend, divisor));
    }

    [TestCase(1, 2, 3)]
    [TestCase(-1, -2, -3)]
    [TestCase(0, 0, 0)]
    public void Add_MultipleInputs_ReturnsExpectedResults(int a, int b, int expected)
    {
        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected), $"The add method failed for inputs {a} and {b}.");
    }



}
