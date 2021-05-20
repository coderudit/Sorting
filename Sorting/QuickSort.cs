using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort : Sorting
    {
        public override int[] Sort(int[] arr)
        {
            return arr;
        }

        private int Partition(int[] arr, int low, int high)
        {
            int index = low;
            do
            {
                do { index++; } while (arr[index] <= arr[low]);
                do { high--; } while (arr[high] > arr[low]);
                if (index < high)
                    Swap(ref arr[index], ref arr[high]);
            } while (index < high);
            Swap(ref arr[low], ref arr[high]);
            return high;
        }
    }
}
