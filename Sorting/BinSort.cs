using System.Collections.Generic;

namespace Sorting
{
    public class BinSort : Sorting
    {
        /// <summary>
        /// Index based sort
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

            var arr2 = new LinkedList<int>[max + 1];
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr2[arr[index]] == null)
                {
                    arr2[arr[index]] = new LinkedList<int>();
                }
                arr2[arr[index]].AddLast(arr[index]);
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
            return arr;
        }


    }
}
