namespace HackerRank.Algorithms.Tests
{
    using FluentAssertions;

    using System.Collections.Generic;

    using Xunit;

    public class HR_02_CompareTheTriplets_Tests
    {
        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            int inputA = 17;
            int inputB = 28;
            int inputC = 30;
            int inputE = 99;
            int inputF = 16;
            int inputG = 8;

            int[] expected = new int[] { 2, 1 };

            // Test
            IEnumerable<int> result = HR_02_CompareTheTriplets.CompareTheTriplets(inputA,
                inputB,
                inputC,
                inputE,
                inputF,
                inputG);

            // Assert
            _ = result.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            int inputA = 5;
            int inputB = 6;
            int inputC = 7;
            int inputE = 3;
            int inputF = 6;
            int inputG = 10;

            int[] expected = new int[] { 1, 1 };

            // Test
            IEnumerable<int> result = HR_02_CompareTheTriplets.CompareTheTriplets(inputA,
                inputB,
                inputC,
                inputE,
                inputF,
                inputG);

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}