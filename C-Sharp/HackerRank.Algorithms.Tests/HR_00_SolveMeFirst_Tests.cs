namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_00_SolveMeFirst_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            int inputA = 100;
            int inputB = 1000;

            int expected = 1100;

            // Test
            int result = HR_00_SolveMeFirst.SolveMeFirst(inputA, inputB);

            // Assert
            _ = result.Should().Be(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int inputA = 2;
            int inputB = 3;

            int expected = 5;

            // Test
            int result = HR_00_SolveMeFirst.SolveMeFirst(inputA, inputB);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}