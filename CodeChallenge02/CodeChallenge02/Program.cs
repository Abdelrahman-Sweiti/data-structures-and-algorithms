using System;

namespace CodeChallenge02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 4, 6, -8 };
            int value = 5;

            int[] resultArray = InsertShiftArray(inputArray, value);

          
        }

        public static int[] InsertShiftArray(int[] arr, int value)
        {
            int middleIndex = arr.Length / 2;
            int[] newArr = new int[arr.Length + 1];

            int j = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i == middleIndex)
                {
                    newArr[i] = value;
                }
                else
                {
                    newArr[i] = arr[j];
                    j++;
                }
            }

            return newArr;
        }
    }
}
