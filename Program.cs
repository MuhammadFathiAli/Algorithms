using Algorithms.Insertion_Sort;
using Algorithms.Merge_Sort;
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
            Console.WriteLine("Before Insertion Sort");
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();
            InsertionSort.Sort(list);
            Console.WriteLine("After Insertion Sort");
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Merge Sort
            List<int> mergelist = new List<int>() { 9, 5, 1, 4, 3 };
            Console.WriteLine("Before Merge Sort");
            foreach (var item in mergelist)
                Console.Write(item + " ");
            Console.WriteLine();
            MergeSort.Sort(mergelist);
            Console.WriteLine("After Merge Sort");
            foreach (var item in mergelist)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion

        }
    }
}
