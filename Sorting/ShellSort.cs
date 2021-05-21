namespace Sorting
{
    public class ShellSort : Sorting
    {
        /// <summary>
        /// Comparison based sort and it's inplace sort
        /// O(n log n) or O(n pow 3/2 or 5/3)[When division is by other number than 2]
        /// It is by adaptive, same as insertion sort.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            for (int gap = arr.Length / 2; gap >= 1; gap /= 2)
            {
                for (int index = gap; index < arr.Length; index++)
                {
                    int temp = arr[index];
                    int j = index - gap;
                    while (j >= 0 && arr[j] > temp)
                    {
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }
                    arr[j + gap] = temp;
                }
            }
            return arr;
        }


    }
}
