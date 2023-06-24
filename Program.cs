using Algorithms.Binary_Search;
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
            Console.WriteLine(String.Join(" ", list));
            InsertionSort.Sort(list);
            Console.WriteLine("After Insertion Sort");
            Console.WriteLine(String.Join(" ", list));
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Merge Sort
            List<int> mergelist = new List<int>() { 9, 5, 1, 4, 3 };
            Console.WriteLine("Before Merge Sort");
            Console.WriteLine(String.Join(" ", mergelist));
            MergeSort.Sort(mergelist);
            Console.WriteLine("After Merge Sort");
            Console.WriteLine(String.Join(" ", mergelist));
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Binary Search
            List<int> searchlist = new List<int>() { 1,3,4,5,9,12,17 };
            Console.WriteLine(BinarySearch.Search(searchlist, 4));
            Console.WriteLine(BinarySearch.Search(searchlist, 1));
            Console.WriteLine(BinarySearch.Search(searchlist, 17));
            Console.WriteLine(BinarySearch.Search(searchlist, 30));
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Segeragation between Positive nd negative numbers 
            List<int> segList = new List<int>() { 6, -5, 12, 10, -9, -1 };
            Console.WriteLine(String.Join(" ", segList));
            MergeExtensions.segeregatePosNegNumbers(segList);
            Console.WriteLine(String.Join(" ", segList));
            #endregion
        }
    }
}
