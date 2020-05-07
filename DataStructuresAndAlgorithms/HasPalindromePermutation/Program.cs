using System;
using System.Collections.Generic;
using System.Linq;

namespace HasPalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = HasPalindromePermutation("aabcbcd");

            Console.WriteLine("Hello World!");
        }

        public static bool HasPalindromePermutation(string theString)
        {
            // Check if any permutation of the input is a palindrome

            var length = theString.Length;

            if (length == 0)
            {
                return true;
            }
            Dictionary<char, Int32> frequency = new Dictionary<char, int>();

            foreach (var item in theString)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency.Add(item, 1);
                }
            }

            if (length % 2 == 0)
            {
                if (frequency.Values.Any(v => v % 2 != 0))
                    return false;
                else
                    return true;
            }
            else
            {
                if (frequency.Values.Count(v => v % 2 != 0) > 1)
                    return false;
                else
                    return true;
            }

        }
    }
}
