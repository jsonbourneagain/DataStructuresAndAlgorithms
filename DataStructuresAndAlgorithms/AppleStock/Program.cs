using System;

namespace AppleStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var actual = GetMaxProfit(new int[] { 1, 5, 3, 2 });
            var expected = 4;
            Console.WriteLine("Hello World!");
        }

        public static int GetMaxProfit(int[] stockPrices)
        {
            // Calculate the max profit
            if (stockPrices.Length < 2)
            {
                throw new ArgumentException("stockPrices array must have 2 or more elements.");
            }

            int runningMaxProfit = 0;
            int runningMinPrice = stockPrices[0];

            foreach (var price in stockPrices)
            {
                runningMaxProfit = Math.Max(runningMaxProfit, price - runningMinPrice);
                runningMinPrice = Math.Min(runningMinPrice, price);
            }

            return runningMaxProfit;
        }
    }
}
