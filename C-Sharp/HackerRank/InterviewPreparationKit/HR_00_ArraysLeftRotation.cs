namespace HackerRank.InterviewPreparationKit
{
    using System.Collections.Generic;

    public class HR_00_ArraysLeftRotation
    {
        public static List<int> RotateLeft(List<int> numbers, int rotations)
        {
            var auxList = new List<int>();

            auxList.AddRange(numbers.GetRange(0, rotations));
            auxList.InsertRange(0, numbers.GetRange(rotations, numbers.Count - rotations));
            return auxList;
        }
    }
}