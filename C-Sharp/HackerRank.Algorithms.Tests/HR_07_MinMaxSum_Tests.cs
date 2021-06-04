namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_07_MinMaxSum_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            string[] input = new string[]
            {
                "7", "69", "2", "221", "8974",
            };

            IEnumerable<string> expected = new string[]
            {
                "299", "9271",
            };

            // Test
            IEnumerable<string> result = HR_07_MinMaxSum.MinMaxSum(input);

            // Assert
            _ = result.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            string[] input = new string[]
            {
                "1", "2", "3", "4", "5",
            };

            IEnumerable<string> expected = new string[]
            {
                "10", "14",
            };

            // Test
            IEnumerable<string> result = HR_07_MinMaxSum.MinMaxSum(input);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}