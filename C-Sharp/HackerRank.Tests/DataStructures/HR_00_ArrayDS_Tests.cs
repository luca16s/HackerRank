namespace HackerRank.DataStructures.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_00_ArrayDS_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            var listToBerReversed = new List<int>
            {
                1, 4, 3, 2
            };

            var reversedList = new List<int>()
            {
                2, 3, 4, 1
            };

            // Test
            List<int> reverseList = HR_00_ArrayDS.ReverseArray(listToBerReversed);

            // Assert
            _ = reverseList.Should().BeEquivalentTo(reversedList);
        }
    }
}