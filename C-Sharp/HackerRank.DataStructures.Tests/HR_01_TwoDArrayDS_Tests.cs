namespace HackerRank.DataStructures.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_01_TwoDArrayDS_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int>{1, 1, 1, 0, 0, 0,},
                new List<int>{0, 1, 0, 0, 0, 0,},
                new List<int>{1, 1, 1, 0, 0, 0,},
                new List<int>{0, 0, 2, 4, 4, 0,},
                new List<int>{0, 0, 0, 2, 0, 0,},
                new List<int>{0, 0, 1, 2, 4, 0,},
            };
            int output = 19;

            // Test
            int result = HR_01_TwoDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = output.Should().Be(result);
        }

        [Fact]
        public void SampleTestCaseTwo()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int>{1, 1,  1,  0,  0, 0,},
                new List<int>{0, 1,  0,  0,  0, 0,},
                new List<int>{1, 1,  1,  0,  0, 0,},
                new List<int>{0, 9,  2, -4, -4, 0,},
                new List<int>{0, 0,  0, -2,  0, 0,},
                new List<int>{0, 0, -1, -2, -4, 0,},
            };
            int output = 13;

            // Test
            int result = HR_01_TwoDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = output.Should().Be(result);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int>{-9, -9, -9,  1, 1, 1,},
                new List<int>{ 0, -9,  0,  4, 3, 2,},
                new List<int>{-9, -9, -9,  1, 2, 3,},
                new List<int>{ 0,  0,  8,  6, 6, 0,},
                new List<int>{ 0,  0,  0, -2, 0, 0,},
                new List<int>{ 0,  0,  1,  2, 4, 0,},
            };
            int output = 28;

            // Test
            int result = HR_01_TwoDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = output.Should().Be(result);
        }
    }
}