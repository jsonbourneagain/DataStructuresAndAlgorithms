using System;

namespace AppleStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var actual = GetMaxProfit(new int[] { 9, 7, 4, 1 });
            var expected = -2;
            Console.WriteLine("Hello World!");
        }

        public static int GetMaxProfit(int[] stockPrices)
        {
            // Calculate the max profit
            if (stockPrices.Length < 2)
            {
                throw new ArgumentException("Getting a profit requires at least 2 prices.", nameof(stockPrices));
            }

            int runningMaxProfit = stockPrices[1] - stockPrices[0];
            int runningMinPrice = stockPrices[0];

            for (int i = 1; i < stockPrices.Length; i++)
            {
                int price = stockPrices[i];

                runningMaxProfit = Math.Max(runningMaxProfit, price - runningMinPrice);
                runningMinPrice = Math.Min(runningMinPrice, price);

            }
            return runningMaxProfit;
        }
    }
}
