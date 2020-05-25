using System;

namespace InPlaceShuffle
{
    class Program
    {
        static Random _rand = new Random();

        static void Main(string[] args)
        {
            var initial = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var shuffled = (int[])initial.Clone();
            Shuffle(shuffled);
            Console.WriteLine($"Initial array: [{string.Join(", ", initial)}]");
            Console.WriteLine($"Shuffled array: [{string.Join(", ", shuffled)}]");

            Console.WriteLine("Hello World!");
        }

        static int GetRandom(int floor, int ceiling)
        {
            return _rand.Next(floor, ceiling + 1);
        }

        public static void Shuffle(int[] array)
        {
            var maxIndex = array.Length - 1;
            // Shuffle the input in place
            for (int i = 0; i < array.Length; i++)
            {
                var random = GetRandom(i, maxIndex);
                if (i != random)
                    Swap(ref array, i, random);
            }

            void Swap(ref int[] array, int a, int b)
            {
                array[a] = array[a] + array[b];
                array[b] = array[a] - array[b];
                array[a] = array[a] - array[b];
            }
        }
    }
}
