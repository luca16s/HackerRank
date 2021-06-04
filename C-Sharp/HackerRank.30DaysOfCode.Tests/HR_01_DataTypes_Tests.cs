namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;
    using System.Linq;

    using Xunit;

    public class HR_01_DataTypes_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int first = 12;
            double second = 4.0d;
            string third = "is the best place to learn and practice coding!";
            string[] expected = new string[3]
            {
                "16",
                "8,0",
                "HackerRank is the best place to learn and practice coding!"
            };

            // Test
            IEnumerable<string> result = HR_01_DataTypes.DataTypes(first, second, third);

            // Assert
            _ = result.ToArray().Should().StartWith(expected);
        }
    }
}