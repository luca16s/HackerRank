namespace HackerRank._30DaysOfCode
{
    using System.Collections.Generic;

    public class HR_00_HelloWorld
    {
        public static IEnumerable<string> HelloWorld(string inputString)
        {
            yield return "Hello, World.";
            yield return inputString;
        }
    }
}