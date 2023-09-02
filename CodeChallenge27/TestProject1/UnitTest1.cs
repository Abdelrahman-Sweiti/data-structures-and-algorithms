using CodeChallenge27;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMergeSort()
        {
            int[] inputArray = { 12, 11, 13, 5, 6, 7 };
            int[] expectedArray = { 5, 6, 7, 11, 12, 13 };

            Program.Sort(inputArray);

            Assert.Equal(expectedArray, inputArray);
        }

        [Fact]
        public void TestEmptyArray()
        {
            int[] inputArray = { };
            int[] expectedArray = { };

            Program.Sort(inputArray);

            Assert.Equal(expectedArray, inputArray);
        }

        [Fact]
        public void TestAlreadySortedArray()
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            int[] expectedArray = { 1, 2, 3, 4, 5 };

            Program.Sort(inputArray);

            Assert.Equal(expectedArray, inputArray);
        }

        [Fact]
        public void TestSingleElementArray()
        {
            int[] inputArray = { 42 };
            int[] expectedArray = { 42 };

            Program.Sort(inputArray);

            Assert.Equal(expectedArray, inputArray);
        }
    }
}