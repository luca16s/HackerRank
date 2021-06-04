namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_09_Recursion_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int number = 3;
            int expected = 6;

            // Test
            int result = HR_09_Recursion.Recursion(number);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}