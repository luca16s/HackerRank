namespace HackerRank.InterviewPreparationKit
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class HR_01_NewYearChaos
    {
        public static string MinimumBribes(List<int> numbers)
        {
            bool tooChaotic = false;
            int totalOfBribedsPositions = 0;
            int listCount = numbers.Count;

            for (int i = 0; i < listCount; i++)
            {
                int left = numbers[i];
                int leftActualIndex = numbers.IndexOf(left);
                int leftMustBeIndex = left - 1;

                if (leftMustBeIndex - leftActualIndex > 2)
                {
                    tooChaotic = true;
                    break;
                }

                for (int j = Math.Max(0, numbers[i] - 2); j < i; j++)
                {
                    if (numbers[j] > numbers[i])
                        totalOfBribedsPositions++;
                }
            }

            return tooChaotic
                ? "Too chaotic"
                : $"{totalOfBribedsPositions}";
        }
    }
}