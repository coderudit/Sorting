using System;

namespace Sorting
{
    class MergeSort : Sorting
    {
        public override int[] Sort(int[] arr)
        {
            int pass, low, mid, high = 0;
            for (pass = 2; pass <= arr.Length; pass *= 2)
            {
                for (int index = 0; index + pass - 1 < arr.Length; index += pass)
                {
                    low = index;
                    high = index + pass - 1;
                    mid = Convert.ToInt32(Math.Floor((double)(low + high) / 2));
                    Merge(ref arr, low, mid, high);
                }
            }
            if (pass / 2 < arr.Length)
                Merge(ref arr, 0, pass / 2, arr.Length - 1);
            return arr;
        }

        private void Merge(ref int[] arr, int low, int mid, int high)
        {
            int index = low;
            int i = low;
            int j = mid + 1;
            int[] newArr = new int[arr.Length];
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                    newArr[index++] = arr[i++];
                else
                    newArr[index++] = arr[j++];
            }
            while (i <= mid)
                newArr[index++] = arr[i++];
            while (j <= high)
                newArr[index++] = arr[j++];

            for (int start = low; start <= high; start++)
                arr[start] = newArr[start];
        }

        public void RecursiveMergeSort(ref int[] arr, int low, int high)
        {
            int mid = 0;
            if (low < high)
            {
                mid = (low + high) / 2;
                RecursiveMergeSort(ref arr, low, mid);
                RecursiveMergeSort(ref arr, mid + 1, high);
                Merge(ref arr, low, mid, high);
            }
        }
    }
}
