using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partee_MergeSort
{
    class MergeSort
    {
        static void Merge(int[] arr, int left, int middle, int right)
        {
        // Create the single array, preserve length index, copy left index for temp array use
            int totalLength = (right - left + 1);
            int[] tempArray = new int[arr.Length];
            int leftIndex = left;
        // Separate left and right "sub arrays" with a middle index point
            int middleZero = (middle - 1);

            while (left <= middleZero && middle <= right)
            {
            // Compare values
                if (arr[left] >= arr[middle])
                {
                    tempArray[leftIndex++] = arr[left++];
                }
                else
                {
                    tempArray[leftIndex++] = arr[middle++];
                }
            }
            while (left <= middleZero)
            {
                tempArray[leftIndex++] = arr[left++];
            }
            while (middle <= right)
            {
                tempArray[leftIndex++] = arr[middle++];
            }
        // since right is the only preserved index left, I used it to copy the array
            for (int i = 0; i < totalLength; i++)
            {
                arr[right] = tempArray[right];
                right--;
            }
        }
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (right + left) / 2;
            // recursive call to Sort() Method
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);
            // Merge part of the merge sort
                Merge(arr, left, middle + 1, right);
            }
        }
    }
}