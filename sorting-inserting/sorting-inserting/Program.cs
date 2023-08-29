using System;

namespace sorting_inserting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sortedArray = InsertionSort(x);

            Console.WriteLine(string.Join(", ", sortedArray));
        }

        public static int[] InsertionSort(int[] input)
        {
            int[] sorted = new int[input.Length];
            sorted[0] = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                Insert(sorted, i, input[i]);
            }

            return sorted;
        }
        public static void Insert(int[] sorted, int index, int value)
        {
            int i = index - 1;
            int temp = value;

            while (i >= 0 && sorted[i] > temp)
            {
                sorted[i + 1] = sorted[i];
                i = i - 1;
            }

            sorted[i + 1] = temp;
        }

    }
}
