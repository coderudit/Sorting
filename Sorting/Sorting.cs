using System;

namespace Sorting
{
    public abstract class Sorting
    {
        public abstract int[] Sort(int[] arr);

        public void Swap(ref int element1, ref int element2)
        {
            int temp = element1;
            element1 = element2;
            element2 = temp;
        }

        public void Print(int[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write($"{arr[index]} ");
            }
        }
    }
}
