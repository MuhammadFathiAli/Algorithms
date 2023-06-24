using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Merge_Sort
{
    public static class MergeExtensions
    {
        public static void segeregatePosNegNumbers(List<int> list)
        {
            segeregate(list, 0, list.Count - 1);
        }

        private static void merge(List<int> list, int start, int mid, int end)
        {
            int i, j, k;
            int left_length = mid - start + 1;
            int right_length = end - mid;
            int[] left_array = new int[left_length];
            int[] right_array = new int[right_length];

            for (i = 0; i < left_length; i++)
            {
                left_array[i] = list[start + i];
            }
            for (j = 0; j < right_length; j++)
            {
                right_array[j] = list[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = start;
            while (i < left_length && left_array[i] <= 0)
            {
                list[k++] = left_array[i++];
            }
            while (j < right_length && right_array[j] <= 0)
            {
                list[k++] = right_array[j++];
            }
            while (i < left_length )
            {
                list[k++] = left_array[i++];
            }
            while (j < right_length)
            {
                list[k++] = right_array[j++];
            }
        }

        private static void segeregate(List<int> list, int start, int end)
        {
            if (end <= start)
                return;
            int mid = (start + end) / 2;
            segeregate(list, start, mid);
            segeregate(list, mid + 1, end);
            merge(list, start, mid, end);
        }
    }
}
