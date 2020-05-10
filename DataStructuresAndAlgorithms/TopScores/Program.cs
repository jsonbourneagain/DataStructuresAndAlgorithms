using System;

namespace TopScores
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scores = new int[] { 37, 89, 41, 65, 91, 53 };
            //var expected = new int[] { 91, 89, 65, 53, 41, 37 };
            var scores = new int[] { 20, 10, 30, 30, 10, 20 };
            var expected = new int[] { 30, 30, 20, 20, 10, 10 };

            var actual = SortScores(scores, 100);
        }

        public static int[] SortScores(int[] unorderedScores, int highestPossibleScore)
        {
            // Sort the scores in O(n) time
            if (unorderedScores.Length == 0)
            {
                return unorderedScores;
            }

            int[] intermediateSortedArr = new int[highestPossibleScore + 1];

            //int[] orderedScores = new int[unorderedScores.Length];

            Array.Fill(intermediateSortedArr, 0);
            //for (int i = 0; i < highestPossibleScore; i++)
            //{
            //    intermediateSortedArr[i] = 0;
            //}

            foreach (int i in unorderedScores)
            {
                intermediateSortedArr[i]++;
            }

            int j = 0;
            for (int i = highestPossibleScore - 1; i >= 0; i--)
            {
                var n = intermediateSortedArr[i];

                if (n > 0)
                {
                    FillNewArrayNTimesWithGivenElementAtIndexJ(ref unorderedScores, i, n, ref j);
                }

            }

            return unorderedScores;
        }

        private static void FillNewArrayNTimesWithGivenElementAtIndexJ(ref int[] orderedScores, int i, int n, ref int j)
        {
            int k = 0;

            while (k < n)
            {
                orderedScores[j] = i;
                j++;
                k++;
            }
        }
    }
}
