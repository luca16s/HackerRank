namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_01_SimpleArraySum_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int count = 6;
            int[] array = new int[] { 1, 2, 3, 4, 10, 11, };

            int expected = 31;

            // Test
            int result = HR_01_SimpleArraySum.SimpleArraySum(count, array);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}