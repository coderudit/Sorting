using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 5, 7, 3, 2 };

            #region Bubble Sort
            //var bubbleSort = new BubbleSort();
            //var sortedArray = bubbleSort.Sort(arr);
            //bubbleSort.Print(sortedArray);
            #endregion

            #region Insertion Sort
            //var insertionSort = new InsertionSort();
            //var sortedArray = insertionSort.Sort(arr);
            //insertionSort.Print(sortedArray);
            #endregion

            #region Selection Sort
            //var selectionSort = new SelectionSort();
            //var sortedArray = selectionSort.Sort(arr);
            //selectionSort.Print(sortedArray);
            #endregion

            #region Quick Sort
            //int[] arr2 = new int[] { 11, 13, 7, 12, 16, 9, 24, 5, 10, 3, int.MaxValue };
            #endregion

            #region Merge Sort
            //int[] arr2 = new int[] { 8, 3, 7, 4, 9, 2, 6, 5 };
            //var mergeSort = new MergeSort();
            //var sortedArray = mergeSort.Sort(arr2);
            //mergeSort.Print(sortedArray);
            #endregion

            #region Count Sort
            //int[] arr2 = new int[] { 6, 3, 9, 10, 15, 6, 8, 12, 3, 6 };
            //var countSort = new CountSort();
            //var sortedArray = countSort.Sort(arr2);
            //countSort.Print(sortedArray);
            #endregion

            #region Bin/Bucket Sort
            //int[] arr2 = new int[] { 6, 3, 9, 10, 15, 6, 8, 12, 3, 6 };
            //var binSort = new BinSort();
            //var sortedArray = binSort.Sort(arr2);
            //binSort.Print(sortedArray);
            #endregion

            #region Bin/Bucket Sort
            int[] arr2 = new int[] { 237, 146, 259, 348, 152, 163, 235, 48, 36, 62 };
            var radixSort = new RadixSort();
            var sortedArray = radixSort.Sort(arr2);
            radixSort.Print(sortedArray);
            #endregion
        }
    }
}
