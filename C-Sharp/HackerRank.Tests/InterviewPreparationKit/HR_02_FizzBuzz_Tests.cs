namespace HackerRank.Tests.InterviewPreparationKit
{
    using FluentAssertions;

    using HackerRank.InterviewPreparationKit;

    using System.Collections.Generic;

    using Xunit;

    public class HR_02_FizzBuzz_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            int number = 15;
            string[] expected = new string[]
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz",
            };

            // Test
            IEnumerable<string> result = HR_02_FizzBuzz.FizzBuzz(number);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}