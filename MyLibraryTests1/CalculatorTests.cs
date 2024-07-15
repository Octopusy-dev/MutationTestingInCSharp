using FluentAssertions;

using Xunit;

namespace MyLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 0, 1)]
        public void Sum(int number1, int number2, int expected)
        {
            Calculator.Sum(number1, number2).Should().Be(expected);
        }
    }
}