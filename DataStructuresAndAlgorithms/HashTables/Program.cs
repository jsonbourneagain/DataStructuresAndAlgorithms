using System;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool CanTwoMoviesFillFlight(int[] movieLengths, int flightLength)
        {
            // Determine if two movies add up to the flight length
            var seenMoviesLengths = new HashSet<int>();

            foreach (var firstMovieLength in movieLengths)
            {
                var matchingSecondMovieLength = flightLength - firstMovieLength;

                if (seenMoviesLengths.Contains(matchingSecondMovieLength))
                {
                    return true;
                }

                seenMoviesLengths.Add(firstMovieLength);
            }

            return false;
        }

    }

}
