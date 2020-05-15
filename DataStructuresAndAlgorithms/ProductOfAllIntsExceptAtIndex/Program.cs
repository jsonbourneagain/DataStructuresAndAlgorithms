using System;

namespace ProductOfAllIntsExceptAtIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var expected = new int[] { 6, 3, 2 };

            var actual = GetProductsOfAllIntsExceptAtIndex(new int[] { 1, 2, 3 });

            Console.WriteLine("Hello World!");
        }

        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] intArray)
        {
            // Make an array with the products

            if (intArray.Length < 2)
            {
                throw new ArgumentException($"There must at least be 2 items in {intArray}", nameof(intArray));
            }
            int productSoFar = 1;
            int[] products = new int[intArray.Length];
            products[0] = 1;

            for (int i = 1; i < intArray.Length; i++)
            {
                productSoFar *= intArray[i - 1];
                products[i] = productSoFar;
            }

            productSoFar = 1;

            for (int i = intArray.Length - 2; i >= 0; i--)
            {
                productSoFar *= intArray[i + 1];
                products[i] *= productSoFar;
            }

            return products;
        }
    }
}
