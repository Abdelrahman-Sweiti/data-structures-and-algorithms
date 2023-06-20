using System;

namespace CodeChallenge01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int[] reversedArray = ReverseArray(array);
            Console.WriteLine("Reversed Array: " + string.Join(", ", reversedArray));
        }

        static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int index = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[index] = array[i];
                index++;
            }

            return reversedArray;
        }
    }
}
