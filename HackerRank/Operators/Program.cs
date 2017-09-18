using System;

namespace Operators
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            double mealCost, tip, tax, totalCost, tipPercent, taxPercent;
            Console.WriteLine("Insert meal cost: ");
            mealCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert tip percent: ");
            tipPercent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Tax Percent: ");
            taxPercent = Convert.ToInt32(Console.ReadLine());

            tip = mealCost * (tipPercent / 100);
            tax = mealCost * (taxPercent / 100);

            totalCost = Math.Round(mealCost + tip + tax);
            Console.WriteLine($"The total meal cost is {totalCost} dollars.");
            Console.ReadLine();
        }
    }
}
