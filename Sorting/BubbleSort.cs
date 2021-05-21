namespace Sorting
{
    public class BubbleSort : Sorting
    {
        /// <summary>
        /// Comparison based sort
        /// Min: O(n) When list is already sorted no swaps are required.
        /// Max: O(n pow 2) When list is decreasing.
        /// We made it adaptive and it is stable.
        /// K passes are beneficial as after K passes you will get K max elements at last.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            for (int pass = 0; pass < arr.Length - 1; pass++)
            {
                int flag = 0;
                //Reduces comparison and swaps with every pass.
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
