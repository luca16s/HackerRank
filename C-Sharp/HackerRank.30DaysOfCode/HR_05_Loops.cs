namespace HackerRank._30DaysOfCode
{
    using static System.Console;
    using static System.Convert;

    public class HR_05_Loops
    {
        public static void Loops()
        {
            int n = ToInt32(ReadLine());
            for (int i = 1; i < 11; i++)
            {
                int result = n * i;
                WriteLine($"{n} x {i} = {result}");
            }
        }
    }
}