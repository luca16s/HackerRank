namespace HackerRank.Tests.InterviewPreparationKit
{
    using FluentAssertions;

    using HackerRank.InterviewPreparationKit;

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Xunit;

    public class HR_01_NewYearChaos_Tests
    {
        [Fact]
        public void SampleTestCaseNine()
        {
            // Arrange
            int count = 5;
            string[] inputSource = File
                .ReadAllText(".\\Resources\\input_sample_nine_NewYearChaos.txt")
                .Split("-");

            var listOfItems = new List<int>();

            IEnumerable<string> expected = new List<string>
            {
                "119847",
                "Too chaotic",
                "Too chaotic",
                "Too chaotic",
                "119971",
            };

            // Test
            var result = new List<string>();

            foreach (string listaItens in inputSource)
            {
                result
                    .Add(HR_01_NewYearChaos
                    .MinimumBribes(Array.ConvertAll(listaItens.Split(" "), int.Parse).ToList()));
            }

            // Assert
            _ = result.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseOne()
        {
            // Arrange
            var caseList = new List<List<int>>
            {
                new List<int>{ 5, 1, 2, 3, 7, 8, 6, 4, },
                new List<int>{ 1, 2, 5, 3, 7, 8, 6, 4, },
            };

            //12345678|
            //12354678|1
            //12534678|2
            //12534768|3
            //12537468|4
            //12537486|5
            //12537846|6
            //12537864|7

            IEnumerable<string> expected = new List<string>
            {
                "Too chaotic",
                "7",
            };

            // Test
            var result = new List<string>();
            foreach (List<int> caso in caseList)
            {
                result.Add(HR_01_NewYearChaos.MinimumBribes(caso));
            }

            // Assert
            _ = result.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseTwo()
        {
            // Arrange
            var caseList = new List<List<int>>
            {
                new List<int>{ 1, 2, 5, 3, 4, 7, 8, 6, },
            };

            //12345678|
            //12354678|1
            //12534678|2
            //12534768|3
            //12534786|4

            IEnumerable<string> expected = new List<string>
            {
                "4",
            };

            // Test
            var result = new List<string>();
            foreach (List<int> caso in caseList)
            {
                result.Add(HR_01_NewYearChaos.MinimumBribes(caso));
            }

            // Assert
            _ = result.Should().StartWith(expected);
        }

        [Fact]
        public void SampleTestCaseZero()
        {
            // Arrange
            var caseList = new List<List<int>>
            {
                new List<int>{ 2, 1, 5, 3, 4, },
                new List<int>{ 2, 5, 1, 3, 4, },
            };

            //12345|
            //21345|1
            //21354|2
            //21534|3

            IEnumerable<string> expected = new List<string>
            {
                "3",
                "Too chaotic",
            };

            // Test
            var result = new List<string>();
            foreach (List<int> caso in caseList)
            {
                result.Add(HR_01_NewYearChaos.MinimumBribes(caso));
            }

            // Assert
            _ = result.Should().StartWith(expected);
        }
    }
}