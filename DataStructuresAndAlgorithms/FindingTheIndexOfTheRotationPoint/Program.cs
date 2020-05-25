using System;

namespace FindingTheIndexOfTheRotationPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //var actual = FindRotationPoint(new string[] { "cape", "cake" });
            //var expected = 1;

            //var actual = FindRotationPoint(new string[] { "grape", "orange", "plum", "radish",
            //"apple" });
            //var expected = 4;

            Console.WriteLine("Hello World!");
        }

        public static int FindRotationPoint(String[] words)
        {
            // Find the rotation point in the array
            string firstWord = words[0];

            int floorIndex = 0;
            int ceilingIndex = words.Length - 1;

            while (floorIndex < ceilingIndex)
            {
                var pivotIndex = (floorIndex + ceilingIndex) / 2;

                if (String.Compare(words[pivotIndex], firstWord, StringComparison.Ordinal) >= 0)
                {
                    floorIndex = pivotIndex;
                }
                else
                {
                    ceilingIndex = pivotIndex;
                }
                if (floorIndex + 1 == ceilingIndex)
                {
                    return ceilingIndex;
                }
            }
            return 0;
        }
    }
}
