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
                List<int> auxList = numbers.GetRange(1, numbers.Count - 1);
                auxList.Add(auxiliarMain);
                numbers = auxList;
            }

            return numbers;
        }
    }
}