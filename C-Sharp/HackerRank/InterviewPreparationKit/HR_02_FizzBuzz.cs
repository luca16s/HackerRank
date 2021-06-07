namespace HackerRank.InterviewPreparationKit
{
    using System.Collections.Generic;

    public static class HR_02_FizzBuzz
    {
        public static IEnumerable<string> FizzBuzz(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                yield return i % 3 == 0
                    && i % 5 == 0
                    ? "FizzBuzz"
                    : i % 3 == 0
                    ? "Fizz"
                    : i % 5 == 0
                    ? "Buzz"
                    : $"{i}";
            }
        }
    }
}