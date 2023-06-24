using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Insertion_Sort
{
    public static class InsertionSort
    {
        public static List<int> sort(List<int> list)   // complexity analysis
        {
            for (int i = 1; i < list.Count; i++)                //n
            {
                int key = list[i];                              //n 
                int j = i - 1;                                  //n
                while (j >= 0 && list[j] > key)                //n
                {
                    list[j + 1] = list[j];                    //n
                    j--;                                      //n
                }
                list[j + 1] = key;                           //n  
            }
            return list;                                     //1 
        }
    }
}
