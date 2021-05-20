namespace Sorting
{
    public class BubbleSort : Sorting
    {
        /// <summary>
        /// Min: O(n) When no swap at start i.e. when list is already sorted.
        /// Max: O(n pow 2) When list is decreasing.
        /// We made it adaptive and stable.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            for (int pass = 0; pass < arr.Length - 1; pass++)
            {
                int flag = 0;
                //Reduce comparison with every pass.
                for (int index = 0; index < arr.Length - 1 - pass; index++) 
                {
                    if (arr[index] > arr[index + 1])
                    {
                        Swap(ref arr[index], ref arr[index + 1]);
                        flag = 1;
                    }
                }
                //At any pass if sorting is not done, then the list is already sorted.
                if (flag == 0)
                    break;
            }
            return arr;
        }


    }
}
