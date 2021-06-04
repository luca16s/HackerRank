namespace HackerRank._30DaysOfCode
{
    using static System.Console;
    using static System.Convert;
    using static System.Math;

    public class HR_02_Operators
    {
        public static string Operators(double mealCost,
            double tipPercent,
            double taxPercent)
        {
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);

            double totalCost = Round(mealCost + tip + tax);

            return $"The total meal cost is {totalCost} dollars.";
        }
    }
}