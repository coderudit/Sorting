namespace Sorting
{
    public class InsertionSort : Sorting
    {
        /// <summary>
        /// Comparison based sort
        /// Min: O(n) When list is already sorted no swaps are required.
        /// Max: O(n pow 2).
        /// It is by nature adaptive and it is stable.
        /// Insertion sort is best for linked list as we have to just change the pointers
        /// while inserting. It is not used for arrays generally.
        /// K passes are not beneficial as results will be sorted after all passes.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            for (int pass = 0; pass < arr.Length - 1; pass++)
            {
                for (int index = pass + 1; index > 0; index--)
                {
                    if (arr[index] < arr[index - 1])
                    {
                        Swap(ref arr[index], ref arr[index - 1]);
                    }
                }
            }
            return arr;
        }
    }
}
