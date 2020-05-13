using System;

namespace HighestProductOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var actual = HighestProductOf3(new int[] { -10, -10, 1, 3, 4 });
            var actual = HighestProductOf3(new int[] { -5, -1, -3, -2 });

            Console.WriteLine("Hello World!");
        }

        public static int HighestProductOf3(int[] arrayOfInts)
        {
            // Calculate the highest product of three numbers
            if (arrayOfInts.Length < 3)
            {
                throw new ArgumentException("We need minimum 3 elements in ", nameof(arrayOfInts));
            }

            int highestProductOf3 = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];
            int highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            int lowestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            int highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            int lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);

            for (int i = 2; i < arrayOfInts.Length; i++)
            {
                var current = arrayOfInts[i];

                highestProductOf3 = Math.Max(highestProductOf3, Math.Max(current * lowestProductOf2, current * highestProductOf2));

                highestProductOf2 = Math.Max(highestProductOf2, Math.Max(highest * current, lowest * current));

                lowestProductOf2 = Math.Min(lowestProductOf2, Math.Min(lowest * current, highest * current));


                highest = Math.Max(highest, current);
                lowest = Math.Min(lowest, current);
            }

            return highestProductOf3;
        }
    }
}
