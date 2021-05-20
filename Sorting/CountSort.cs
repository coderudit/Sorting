namespace Sorting
{
    public class CountSort : Sorting
    {
        /// <summary>
        /// Max: O(n).
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            int max = int.MinValue;
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] > max)
                    max = arr[index];
            }

            int[] arr2 = new int[max + 1];
            for (int index = 0; index < arr.Length; index++)
            {
                arr2[arr[index]] += 1;
            }

            int currentIndex = 0;
            for (int index = 0; index < arr2.Length; index++)
            {
                while (arr2[index] > 0)
                {
                    arr[currentIndex++] = index;
                    arr2[index]--;
                }
            }
            return arr;
        }
    }
}
