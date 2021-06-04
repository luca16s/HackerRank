namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HR_11_2DArrays_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int[][] listOfLists = new int[][]
            {
                new int[] {1, 1, 1, 0, 0, 0,},
                new int[] {0, 1, 0, 0, 0, 0,},
                new int[] {1, 1, 1, 0, 0, 0,},
                new int[] {0, 0, 2, 4, 4, 0,},
                new int[] {0, 0, 0, 2, 0, 0,},
                new int[] {0, 0, 1, 2, 4, 0,},
            };
            int expected = 19;

            // Test
            int result = HR_11_2DArrays.TwoDArrays(listOfLists);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}