namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_06_LetsReview_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int times = 2;
            string[] name = new string[] {
            "Hacker",
            "Rank"
            };

            IEnumerable<string> expected = new string[]
            {
                "Hce akr",
                "Rn ak",
            };

            // Test
            IEnumerable<string> result = HR_06_LetsReview.LetsReview(times, name);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}