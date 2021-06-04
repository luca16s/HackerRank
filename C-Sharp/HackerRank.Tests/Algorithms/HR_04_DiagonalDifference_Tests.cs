namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_04_DiagonalDifference_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 3;
            string[][] data = new string[][]
            {
                new string[] {"11", "2", "4" },
                new string[] {"4", "5", "6" },
                new string[] {"10", "8", "-12" },
            };
            int expected = 15;

            // Test
            int result = HR_04_DiagonalDifference.DiagonalDifference(input, data);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}