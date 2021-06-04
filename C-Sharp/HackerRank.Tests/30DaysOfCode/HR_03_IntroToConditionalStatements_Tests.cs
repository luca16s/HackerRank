namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_03_IntroToConditionalStatements_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            int input = 3;
            string expected = "Weird";

            // Test
            string result = HR_03_IntroToConditionalStatements.ConditionalStatements(input);

            // Assert
            _ = result.Should().Be(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 24;
            string expected = "Not Weird";

            // Test
            string result = HR_03_IntroToConditionalStatements.ConditionalStatements(input);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}