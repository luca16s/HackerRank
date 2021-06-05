namespace HackerRank.Tests.InterviewPreparationKit
{
    using FluentAssertions;

    using HackerRank.InterviewPreparationKit;

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Xunit;

    public class HR_00_ArraysLeftRotation_Tests
    {
        [Fact]
        public void SampleTestCaseNine()
        {
            // Arrange
            int numberOfRotations = 25231;
            string[] inputSource = File
                .ReadAllText(".\\Resources\\input_sample_nine_ArraysLeftRotation.txt")
                .Split(" ");
            string[] expectedSource = File
                .ReadAllText(".\\Resources\\expected_sample_nine_ArraysLeftRotation.txt")
                .Split(" ");

            var listOfItems = Array.ConvertAll(inputSource, int.Parse).ToList();
            var expected = Array.ConvertAll(expectedSource, int.Parse).ToList();

            // Test
            List<int> reverseList = HR_00_ArraysLeftRotation.RotateLeft(listOfItems, numberOfRotations);

            // Assert
            _ = reverseList.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            int numberOfRotations = 10;
            var listOfItems = new List<int>
            { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, };
            int[] expected = new int[]
            { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, };

            // Test
            List<int> reverseList = HR_00_ArraysLeftRotation.RotateLeft(listOfItems, numberOfRotations);

            // Assert
            _ = reverseList.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseTwo()
        {
            // Arrange
            int numberOfRotations = 13;
            var listOfItems = new List<int> { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97, };
            int[] expected = new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, };

            // Test
            List<int> reverseList = HR_00_ArraysLeftRotation.RotateLeft(listOfItems, numberOfRotations);

            // Assert
            _ = reverseList.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int numberOfRotations = 4;
            var listOfItems = new List<int>
            { 1, 2, 3, 4, 5 };
            int[] expected = new int[]
            { 5, 1, 2, 3, 4, };

            // Test
            List<int> reverseList = HR_00_ArraysLeftRotation.RotateLeft(listOfItems, numberOfRotations);

            // Assert
            _ = reverseList.Should().StartWith(expected);
        }
    }
}