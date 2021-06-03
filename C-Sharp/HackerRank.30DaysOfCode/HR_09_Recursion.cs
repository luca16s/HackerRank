namespace HackerRank._30DaysOfCode
{
    using static System.Console;
    using static System.Convert;

    public class HR_09_Recursion
    {
        public static void Recursion()
        {
            int n = ToInt32(ReadLine());
            int result = Factorial(n);
            WriteLine(result);
            _ = ReadLine();
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