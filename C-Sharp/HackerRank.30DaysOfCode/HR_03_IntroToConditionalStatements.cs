namespace HackerRank._30DaysOfCode
{
    public class HR_03_IntroToConditionalStatements
    {
        public static string ConditionalStatements(int n)
        {
            if (n % 2 != 0)
            {
                return "Weird";
            }
            else
            {
                if (n is >= 2 and <= 5)
                {
                    return "Not Weird";
                }
                else
                {
                    if (n is >= 6 and <= 20)
                    {
                        return "Weird";
                    }
                    else
                    {
                        if (n >= 20)
                            return "Not Weird";
                    }
                }
            }

            return string.Empty;
        }
    }
}