using System.Collections.Generic;

namespace Sorting
{
    public class BinSort : Sorting
    {
        /// <summary>
        /// O(n)
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

            var newarr = new LinkedList<int>[max + 1];
            for (int index = 0; index < arr.Length; index++)
            {
                if (newarr[arr[index]] == null)
                {
                    newarr[arr[index]] = new LinkedList<int>();
                }
                newarr[arr[index]].AddLast(arr[index]);
            }

            int currentIndex = 0;
            for (int index = 0; index < newarr.Length; index++)
            {
                var list = newarr[index]?.First;
                while (list != null)
                {
                    arr[currentIndex++] = list.Value;
                    list = list.Next;
                }
            }
            return arr;
        }


    }
}
