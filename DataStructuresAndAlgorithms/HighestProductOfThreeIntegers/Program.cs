using System;

namespace HighestProductOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var actual = HighestProductOf3(new int[] { 1, 2, 3, 4 });

            Console.WriteLine("Hello World!");
        }

        public static int HighestProductOf3(int[] arrayOfInts)
        {
            // Calculate the highest product of three numbers
            if (arrayOfInts.Length < 3)
            {
                throw new ArgumentException("We need minimum 3 elements in ", nameof(arrayOfInts));
            }

            var max3Integers = new int[] { arrayOfInts[0], arrayOfInts[1], arrayOfInts[2] };
            Array.Sort(max3Integers); // Sorted in ascending order.

            for (int i = 3; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] > max3Integers[0]) // we know that we can get maxProductOf3 using this ith number.
                {
                    max3Integers[0] = arrayOfInts[i];
                    Array.Sort(max3Integers);
                }
            }

            int maxProduct = 1;

            foreach (var item in max3Integers)
            {
                maxProduct *= item;
            }

            return maxProduct;
        }
    }
}
