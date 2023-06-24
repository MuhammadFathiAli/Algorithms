using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Merge_Sort
{
    public static class MergeSort
    {
        //mergeSort
        //input (array, left, right)
        //exit if left >= right
        //calculate midpoint
        //mergsort (left, midpoint)
        //mergsort (midpoint+1, right)
        //merge(array, left, midpoint, right)
        //merge 
        //input (array, left, midpoint, right)
        //create two arrays
        //move remain items

        public static void Sort(List<int> list)
        {
            mergeSort(list, 0, list.Count - 1);
        }

        private static void mergeSort(List<int> arr, int left, int right)
        {
            if (left >= right)
                return ;
            int mid = (left + right) / 2;
            mergeSort(arr, left, mid);
            mergeSort(arr, mid + 1, right);
            merge(arr, left, right);
        }

        private static void merge(List<int> arr, int left, int right)
        {
            int mid = ((left + right) / 2) + 1;
            int i = left;
            int j = mid;
            int k = left;
            int[] temp = new int[arr.Count];
            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }
            while (i <= mid - 1)
            {
                temp[k++] = arr[i++];
            }
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }
            for (int x = left; x <= right; x++)
            {
                arr[x] = temp[x];
            }
        }
    }
}

