namespace HackerRank.InterviewPreparationKit
{
    using System.Collections.Generic;

    public class HR_00_ArraysLeftRotation
    {
        public static List<int> RotateLeft(List<int> numbers, int rotations)
        {
            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int auxiliarMain = numbers[0];
                for (int indexList = 0; indexList < numbers.Count; indexList++)
                {
                    if (indexList + 1 == numbers.Count)
                        continue;

                    numbers[indexList] = numbers[indexList + 1];
                }
                numbers[^1] = auxiliarMain;
            }

            return numbers;
        }
    }
}