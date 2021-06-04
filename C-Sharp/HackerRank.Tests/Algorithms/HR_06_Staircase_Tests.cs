namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_06_Staircase_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 6;

            IEnumerable<string> expected = new string[]
            {
                "     #",
                "    ##",
                "   ###",
                "  ####",
                " #####",
                "######",
            };

            // Test
            IEnumerable<string> result = HR_06_Staircase.Staircase(input);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}