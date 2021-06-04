namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_05_PlusMinus_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            int input = 8;
            string[] data = new string[]
            {
                "1", "2", "3", "-1", "-2", "-3", "0", "0",
            };
            string[] expected = new string[]
            {
                "0,375000",
                "0,375000",
                "0,250000",
            };

            // Test
            IEnumerable<string> result = HR_05_PlusMinus.PlusMinus(input, data);

            // Assert
            _ = result.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 6;
            string[] data = new string[]
            {
                "-4", "3", "-9", "0", "4", "1",
            };
            string[] expected = new string[]
            {
                "0,500000",
                "0,333333",
                "0,166667",
            };

            // Test
            IEnumerable<string> result = HR_05_PlusMinus.PlusMinus(input, data);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}