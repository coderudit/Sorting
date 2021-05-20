namespace Sorting
{
    public class SelectionSort : Sorting
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
                int i = pass;
                for (int index = pass + 1; index <= arr.Length - 1; index++)
                {
                    if (arr[i] > arr[index])
                    {
                        i = index;
                    }
                }
                int temp = arr[pass];
                arr[pass] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }


    }
}
