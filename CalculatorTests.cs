using FluentAssertions;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 19, 24)]
        public void GivenTwoNumbers_AddThemTogether(int a, int b, int expectedResult)
        {
            Calculator.Add(a, b).Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(7, 6, 42)]
        public void GivenTwoNumbers_MultiplyThemTogether(int a, int b, int expectedResult)
        {
            Calculator.Multiply(a, b).Should().Be(expectedResult);
        }
    }
}
