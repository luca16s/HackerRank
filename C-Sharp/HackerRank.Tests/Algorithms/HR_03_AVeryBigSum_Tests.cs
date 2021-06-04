namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_03_AVeryBigSum_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int input = 5;
            long[] data = new long[]
            {
                1000000001, 1000000002, 1000000003, 1000000004, 1000000005,
            };
            long expected = 5000000015L;

            // Test
            long result = HR_03_AVeryBigSum.VeryBigSum(input, data);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}