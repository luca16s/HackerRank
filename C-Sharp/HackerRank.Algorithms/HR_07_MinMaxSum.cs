namespace HackerRank.Algorithms
{
    using System;
    using System.Collections.Generic;

    public class HR_07_MinMaxSum
    {
        public static IEnumerable<string> MinMaxSum(string[] arrTemp)
        {
            int[] arr = Array.ConvertAll(arrTemp, int.Parse);

            int firstSum = arr[1] + arr[2] + arr[3] + arr[4];
            int secondSum = arr[0] + arr[2] + arr[3] + arr[4];
            int thirdSum = arr[0] + arr[1] + arr[3] + arr[4];
            int fourthSum = arr[0] + arr[1] + arr[2] + arr[4];
            int fifthSum = arr[0] + arr[1] + arr[2] + arr[3];

            if (firstSum < secondSum
                && firstSum < thirdSum
                && firstSum < fourthSum
                && firstSum < fifthSum)
                yield return $"{firstSum}";
            else if (secondSum < firstSum
                && secondSum < thirdSum
                && secondSum < fourthSum
                && secondSum < fifthSum)
                yield return $"{secondSum}";
            else if (thirdSum < firstSum
                && thirdSum < secondSum
                && thirdSum < fourthSum
                && thirdSum < fifthSum)
                yield return $"{secondSum}";
            else if (fourthSum < firstSum
                && fourthSum < secondSum
                && fourthSum < thirdSum
                && fourthSum < fifthSum)
                yield return $"{fourthSum}";
            else if (fifthSum < firstSum
                && fifthSum < secondSum
                && fifthSum < thirdSum
                && fifthSum < fourthSum)
                yield return $"{fifthSum}";

            if (firstSum > secondSum
                && firstSum > thirdSum
                && firstSum > fourthSum
                && firstSum > fifthSum)
                yield return $"{firstSum}";
            else if (secondSum > firstSum
                && secondSum > thirdSum
                && secondSum > fourthSum
                && secondSum > fifthSum)
                yield return $"{secondSum}";
            else if (thirdSum > firstSum
                && thirdSum > secondSum
                && thirdSum > fourthSum
                && thirdSum > fifthSum)
                yield return $"{thirdSum}";
            else if (fourthSum > firstSum
                && fourthSum > secondSum
                && fourthSum > thirdSum
                && fourthSum > fifthSum)
                yield return $"{fourthSum}";
            else if (fifthSum > firstSum
                && fifthSum > secondSum
                && fifthSum > thirdSum
                && fifthSum > fourthSum)
                yield return $"{fifthSum}";
        }
    }
}