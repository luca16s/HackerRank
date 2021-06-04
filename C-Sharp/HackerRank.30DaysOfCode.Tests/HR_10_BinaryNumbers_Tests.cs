namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_10_BinaryNumbers_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 5;
            int expected = 1;

            // Test
            int result = HR_10_BinaryNumbers.BinaryNumbers(input);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}