using Algorithms.Insertion_Sort;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Insertion Sort
            List<int> list = new List<int>() { 9, 5, 1, 4, 3 };
            list = InsertionSort.sort(list);
            foreach (var item in list)
                Console.Write(item + " ");
            #endregion

        }
    }
}
