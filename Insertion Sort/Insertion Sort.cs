using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Insertion_Sort
{
    public static class InsertionSort
    {
        public static void Sort(List<int> list)            // complexity analysis  O(n^2)
        {
            for (int i = 1; i < list.Count; i++)                //n
            {
                int key = list[i];                              //n 
                int j = i - 1;                                  //n
                while (j >= 0 && list[j] > key)                //n * n
                {
                    list[j + 1] = list[j];                    //n * n
                    j--;                                      //n * n 
                }
                list[j + 1] = key;                           //n  
            }                                   //1 
        }
    }
}
