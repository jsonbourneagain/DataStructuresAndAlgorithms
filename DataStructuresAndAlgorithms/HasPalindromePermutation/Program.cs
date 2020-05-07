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

            var unpairedChar = new HashSet<char>();

            foreach (var c in theString)
            {
                if (unpairedChar.Contains(c))
                {
                    unpairedChar.Remove(c);
                }
                else
                {
                    unpairedChar.Add(c);
                }
            }

            return unpairedChar.Count <= 1;
        }
    }
}
