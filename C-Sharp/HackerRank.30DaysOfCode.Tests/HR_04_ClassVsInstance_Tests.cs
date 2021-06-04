namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_04_ClassVsInstance_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int inputTimes = 4;
            int[] ages = new int[4]
            {
                -1, 10, 16, 18
            };

            IEnumerable<string> expected = new string[12]
            {
                "Age is not valid, setting age to 0.",
                "You are young.",
                "You are young.",
                "",
                "You are young.",
                "You are a teenager.",
                "",
                "You are a teenager.",
                "You are old.",
                "",
                "You are old.",
                "You are old.",
            };

            // Test
            IEnumerable<string> result = HR_04_ClassVsInstance.ClassVsInstance(inputTimes, ages);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}