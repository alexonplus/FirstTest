using Xunit;
using TestTestTest;

public class CalculatorTests
{
    // create an instance of the Calculator class to use in tests
    private readonly Calculator _calc = new Calculator();

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(0, 5, -5)]
    [InlineData(-5, -5, 0)]
    public void Subtract_Tests(int a, int b, int expected)
    {
        var result = _calc.Subtract(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        // check that dividing by zero throws a DivideByZeroException
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
    }
}