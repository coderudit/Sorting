using System;
using System.Collections.Generic;

namespace Sorting
{
    public class RadixSort : Sorting
    {
        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public override int[] Sort(int[] arr)
        {
            LinkedList<int>[] arr2 = new LinkedList<int>[10]; //As we are using decimal number system.

            int max = int.MinValue;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] > max)
                    max = arr[index];
            }

            int digitCount = 0;
            while (max > 0)
            {
                max = max / 10;
                digitCount++;
            }

            int pass = 1;
            while (pass <= digitCount)
            {
                arr2 = new LinkedList<int>[10];
                int divisor = Convert.ToInt32(Math.Pow(10, pass - 1));
                for (int index = 0; index < arr.Length; index++)
                {
                    int num = (arr[index] / divisor) % 10;
                    if (arr2[num] == null)
                        arr2[num] = new LinkedList<int>();
                    arr2[num].AddLast(arr[index]);
                }
                int currentIndex = 0;
                for (int index = 0; index < arr2.Length; index++)
                {
                    var list = arr2[index]?.First;
                    while (list != null)
                    {
                        arr[currentIndex++] = list.Value;
                        list = list.Next;
                    }
                }
                pass++;
            }

            return arr;
        }
    }
}
