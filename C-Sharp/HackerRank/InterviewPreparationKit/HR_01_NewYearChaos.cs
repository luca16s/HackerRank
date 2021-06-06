namespace HackerRank.InterviewPreparationKit
{
    using System.Collections.Generic;
    using System.Linq;

    public class HR_01_NewYearChaos
    {
        public static string MinimumBribes(List<int> numbers)
        {
            bool tooChaotic = false;
            int listCount = numbers.Count;
            int totalOfBribedsPositions = 0;
            var orderedList = Enumerable.Range(1, listCount).ToList();

            for (int i = 0; i < listCount; i++)
            {
                int actualNumber = numbers[i];
                int index = orderedList.BinarySearch(actualNumber);

                if (index > 2)
                {
                    tooChaotic = true;
                    break;
                }
                else
                {
                    orderedList.RemoveAt(index);
                    totalOfBribedsPositions += index;
                }
            }

            return tooChaotic
                ? "Too chaotic"
                : $"{totalOfBribedsPositions}";
        }
    }
}