namespace CodeChallenge03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 4, 8, 15, 16, 23, 42 };
            int searchKey = 15;

            int index = BinarySearch(sortedArray, searchKey);

            Console.WriteLine("Input Array: [{0}]", string.Join(", ", sortedArray));
            Console.WriteLine("Search Key: {0}", searchKey);
        }

        public static int BinarySearch(int[] arr, int searchKey)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == searchKey)
                {
                    return mid;
                }
                else if (arr[mid] > searchKey)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }


    } 
}