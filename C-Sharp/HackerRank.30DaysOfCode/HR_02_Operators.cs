namespace HackerRank._30DaysOfCode
{
    using static System.Math;

    public class HR_02_Operators
    {
        public static double Operators(double mealCost,
            double tipPercent,
            double taxPercent)
        {
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);

            return Round(mealCost + tip + tax);
        }
    }
}