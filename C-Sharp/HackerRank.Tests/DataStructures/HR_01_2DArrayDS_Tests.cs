namespace HackerRank.DataStructures.Tests
{
    using FluentAssertions;

    using HackerRank._30DaysOfCode;

    using System.Collections.Generic;

    using Xunit;

    public class HR_01_2DArrayDS_Tests
    {
        [Fact]
        public void SampleTestCaseFour()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int>{ -1,  1, -1,  0,  0, 0, },
                new List<int>{  0, -1,  0,  0,  0, 0, },
                new List<int>{ -1, -1, -1,  0,  0, 0, },
                new List<int>{  0, -9,  2, -4, -4, 0, },
                new List<int>{ -7,  0,  0, -2,  0, 0, },
                new List<int>{  0,  0, -1, -2, -4, 0, },
            };
            int expected = 0;

            // Test
            int result = HR_01_2DDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = result.Should().Be(expected);
        }

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
            int expected = 19;

            // Test
            int result = HR_01_2DDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = result.Should().Be(expected);
        }

        [Fact]
        public void SampleTestCaseThree()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int>{ 0, -4, -6,  0, -7, -6,},
                new List<int>{-1, -2, -6, -8, -3, -1,},
                new List<int>{-8, -4, -2, -8, -8, -6,},
                new List<int>{-3, -1, -2, -5, -7, -4,},
                new List<int>{-3, -5, -3, -6, -6, -6,},
                new List<int>{-3, -6,  0, -8, -6, -7,},
            };
            int expected = -19;

            // Test
            int result = HR_01_2DDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = result.Should().Be(expected);
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
            int expected = 13;

            // Test
            int result = HR_01_2DDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = result.Should().Be(expected);
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
            int expected = 28;

            // Test
            int result = HR_01_2DDArrayDS.HourglassSum(listOfLists);

            // Assert
            _ = result.Should().Be(expected);
        }
    }
}