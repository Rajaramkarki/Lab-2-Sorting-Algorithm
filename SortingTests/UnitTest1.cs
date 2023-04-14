using SortingAlgorithms;

namespace SortingTests
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void test_Insertion_Sort()
        {
            int[] array1 = { 10, 3, 5, 4, 7, 9 };
            int[] expected1 = {3, 4, 5, 7, 9, 10};
            int[] actual1 = SortingAlgorithm.InsertionSort(array1);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] expected2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual2 = SortingAlgorithm.InsertionSort(array2);

            int[] array3 = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected3 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual3 = SortingAlgorithm.InsertionSort(array3);

            CollectionAssert.AreEqual(expected1, actual1);
            CollectionAssert.AreEqual(expected2, actual2);
            CollectionAssert.AreEqual(expected3, actual3);

        }

        [TestMethod]
        public void test_Merge_Sort()
        {
            int[] array1 = { 10, 3, 5, 4, 7, 9 };
            int[] expected1 = { 3, 4, 5, 7, 9, 10 };
            int[] actual1 = SortingAlgorithm.MergeSort(array1, 0, 5);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] expected2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual2 = SortingAlgorithm.MergeSort(array2, 0, 7);

            int[] array3 = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected3 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual3 = SortingAlgorithm.MergeSort(array3, 0, 7);

            CollectionAssert.AreEqual(expected1, actual1);
            CollectionAssert.AreEqual(expected2, actual2);
            CollectionAssert.AreEqual(expected3, actual3);
        }
    }
}