using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Search
{
    public class BinarySearch
    {
        public static long Search(List<int> list, int target)
        {
            long low = 0;
            long high = list.Count - 1;
            while (low <= high)
            {
                int mid = (int)(low + high) / 2;
                if (list[mid] == target)
                {
                    return mid;
                }
                else if (list[mid] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
