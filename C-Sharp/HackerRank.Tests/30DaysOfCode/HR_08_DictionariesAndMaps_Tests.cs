namespace HackerRank._30DaysOfCode.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_08_DictionariesAndMaps_Tests
    {
        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int count = 3;
            string[] contacts = new string[]
            {
                "sam 99912222",
                "tom 11122222",
                "harry 12299933",
            };

            string[] choices = new string[]
            {
                "sam",
                "edward",
                "harry",
            };

            string[] expected = new string[]
            {
                "sam=99912222",
                "Not found",
                "harry=12299933"
            };

            // Test
            IEnumerable<string> result = HR_08_DictionariesAndMaps
                .DictionariesAndMaps(count,
                contacts,
                choices);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}