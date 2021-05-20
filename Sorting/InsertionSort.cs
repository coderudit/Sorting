namespace Sorting
{
    public class InsertionSort : Sorting
    {
        /// <summary>
        /// Min: O(n) When list is already sorted
        /// Max: O(n pow 2).
        /// It is by nature adaptive and stable.
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
