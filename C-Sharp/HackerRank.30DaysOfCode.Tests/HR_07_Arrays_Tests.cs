namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_07_Arrays_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int times = 4;
            string numbers = "1 4 3 2";

            string expected = "2 3 4 1";

            // Test
            string result = HR_07_Arrays.ArraysMethod(times, numbers);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}