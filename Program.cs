using System;

namespace Partee_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 30, 900, 55, 54, 56, 71, -43, 0, 4529, 555, 639, 101, 102, 100, 5, 82, 50, -77, 14, 99, 104, 1 };

            MergeSort.Sort(array, 0, array.Length - 1);
            PrintArray(array);
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
