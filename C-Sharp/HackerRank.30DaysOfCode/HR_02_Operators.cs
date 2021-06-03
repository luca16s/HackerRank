namespace HackerRank._30DaysOfCode
{
    using static System.Console;
    using static System.Convert;
    using static System.Math;

    public class HR_02_Operators
    {
        public static void Operators()
        {
            double mealCost, tip, tax, totalCost, tipPercent, taxPercent;
            WriteLine("Insert meal cost: ");
            mealCost = ToDouble(ReadLine());
            WriteLine("Insert tip percent: ");
            tipPercent = ToInt32(ReadLine());
            WriteLine("Insert Tax Percent: ");
            taxPercent = ToInt32(ReadLine());

            tip = mealCost * (tipPercent / 100);
            tax = mealCost * (taxPercent / 100);

            totalCost = Round(mealCost + tip + tax);
            WriteLine($"The total meal cost is {totalCost} dollars.");
            _ = ReadLine();
        }
    }
}