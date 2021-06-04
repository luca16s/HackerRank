namespace HackerRank._30DaysOfCode
{
    public class HR_09_Recursion
    {
        public static int Recursion(int count)
        {
            return Factorial(count);
        }

        private static int Factorial(int n)
        {
            int counter = n - 1;
            int result = n;

            if (n != 1)
                result = Factorial(counter) * result;
            return result;
        }
    }
}