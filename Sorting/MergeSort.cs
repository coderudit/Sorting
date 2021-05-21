namespace Sorting
{
    class MergeSort : Sorting
    {
        /// <summary>
        /// Comparison based sort and uses extra space
        /// Uses m way merging
        /// O(n log n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            int pass, low, mid, high = 0;
            for (pass = 2; pass <= arr.Length; pass *= 2)
            {
                for (int index = 0; index + pass - 1 < arr.Length; index += pass)
                {
                    low = index;
                    high = index + pass - 1;
                    mid = (low + high) / 2;
                    Merge(ref arr, low, mid, high);
                }
            }
            if (pass / 2 < arr.Length)
                Merge(ref arr, 0, pass / 2, arr.Length - 1);
            return arr;
        }

        private static void Merge(ref int[] arr, int low, int mid, int high)
        {
            int index = low;
            int i = low;
            int j = mid + 1;
            int[] arr2 = new int[arr.Length];

            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                    arr2[index++] = arr[i++];
                else
                    arr2[index++] = arr[j++];
            }

            while (i <= mid)
                arr2[index++] = arr[i++];
            while (j <= high)
                arr2[index++] = arr[j++];

            for (int start = low; start <= high; start++)
                arr[start] = arr2[start];
        }

        /// <summary>
        /// O(n log n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public void RecursiveMergeSort(ref int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                RecursiveMergeSort(ref arr, low, mid);
                RecursiveMergeSort(ref arr, mid + 1, high);
                Merge(ref arr, low, mid, high);
            }
        }
    }
}
