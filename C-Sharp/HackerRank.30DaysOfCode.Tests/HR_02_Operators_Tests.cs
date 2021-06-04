namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_02_Operators_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            double first = 15.50d;
            double second = 15d;
            double third = 10d;
            double expected = 19d;

            // Test
            double result = HR_02_Operators.Operators(first, second, third);

            // Assert
            _ = result.Should().Be(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            double first = 12.00d;
            double second = 20d;
            double third = 8d;
            double expected = 15d;

            // Test
            double result = HR_02_Operators.Operators(first, second, third);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}