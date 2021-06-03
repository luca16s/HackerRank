namespace HackerRank._30DaysOfCode
{
    using static System.Console;
    using static System.Convert;

    public class HR_03_IntroToConditionalStatements
    {
        public static void ConditionalStatements()
        {
            int n = ToInt32(ReadLine());

            if (n % 2 != 0)
            {
                WriteLine("Weird");
            }
            else
            {
                if (n is >= 2 and <= 5)
                {
                    WriteLine("Not Weird");
                }
                else
                {
                    if (n is >= 6 and <= 20)
                    {
                        WriteLine("Weird");
                    }
                    else
                    {
                        if (n >= 20)
                            WriteLine("Not Weird");
                    }
                }
            }
        }
    }
}