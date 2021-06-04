namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;
    using System.Linq;

    using Xunit;

    public class HR_00_HelloWorld_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            string input = "Welcome to 30 Days of Code!";
            string[] expected = new string[2]
            {
                "Hello, World.",
                "Welcome to 30 Days of Code!"
            };

            // Test
            IEnumerable<string> result = HR_00_HelloWorld.HelloWorld(input);

            // Assert
            _ = result.ToArray().Should().StartWith(expected);
        }
    }
}