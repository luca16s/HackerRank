namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_05_Loops_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 2;
            IEnumerable<string> expected = new string[]
            {
                "2 x 1 = 2",
                "2 x 2 = 4",
                "2 x 3 = 6",
                "2 x 4 = 8",
                "2 x 5 = 10",
                "2 x 6 = 12",
                "2 x 7 = 14",
                "2 x 8 = 16",
                "2 x 9 = 18",
                "2 x 10 = 20",
            };

            // Test
            IEnumerable<string> result = HR_05_Loops.Loops(input);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}