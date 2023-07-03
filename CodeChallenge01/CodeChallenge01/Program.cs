using System;

namespace CodeChallenge01
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int[] array = {  };
            int[] reversedArray = ReverseArray(array);
            Console.WriteLine("Reversed Array: "+ reversedArray);
        }

       public static int[] ReverseArray(int[] array)
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
