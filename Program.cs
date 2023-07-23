using Algorithms.Binary_Search;
using Algorithms.Insertion_Sort;
using Algorithms.Merge_Sort;
using Algorithms.Graphs;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Insertion Sort
            //List<int> list = new List<int>() { 9, 5, 1, 4, 3 };
            //Console.WriteLine("Before Insertion Sort");
            //Console.WriteLine(String.Join(" ", list));
            //InsertionSort.Sort(list);
            //Console.WriteLine("After Insertion Sort");
            //Console.WriteLine(String.Join(" ", list));
            #endregion
            //Console.WriteLine("--------------------------------------------------");
            #region Merge Sort
            //List<int> mergelist = new List<int>() { 9, 5, 1, 4, 3 };
            //Console.WriteLine("Before Merge Sort");
            //Console.WriteLine(String.Join(" ", mergelist));
            //MergeSort.Sort(mergelist);
            //Console.WriteLine("After Merge Sort");
            //Console.WriteLine(String.Join(" ", mergelist));
            #endregion
            //Console.WriteLine("--------------------------------------------------");
            #region Binary Search
            //List<int> searchlist = new List<int>() { 1,3,4,5,9,12,17 };
            //Console.WriteLine(BinarySearch.Search(searchlist, 4));
            //Console.WriteLine(BinarySearch.Search(searchlist, 1));
            //Console.WriteLine(BinarySearch.Search(searchlist, 17));
            //Console.WriteLine(BinarySearch.Search(searchlist, 30));
            #endregion
            //Console.WriteLine("--------------------------------------------------");
            #region Segeragation between Positive nd negative numbers 
            //List<int> segList = new List<int>() { 6, -5, 12, 10, -9, -1 };
            //Console.WriteLine(String.Join(" ", segList));
            //MergeExtensions.segeregatePosNegNumbers(segList);
            //Console.WriteLine(String.Join(" ", segList));
            #endregion
            //Console.WriteLine("--------------------------------------------------");
            #region Graph
            #region prim's
            //char[] labels = new char[] { '1', '2', '3', '4', '5', '6' };
            //double[,] graph = new double[,]
            //{   
            //    { 0, 6.7, 5.2, 2.8, 5.6, 3.6 },
            //    { 6.7, 0, 5.7, 7.3, 5.1, 3.2 },
            //    { 5.2, 5.7, 0, 3.4, 8.5, 4.0 },
            //    { 2.8, 7.3, 3.4, 0, 8, 4.4 },
            //    { 5.6, 5.1, 8.5, 8, 0, 4.6 },
            //    { 3.6, 3.2, 4, 4.4, 4.6, 0 }
            //};
            //StaticGraph.Prim_MST(graph,labels);
            #endregion
            #region BFS 
            Graph g = new Graph(new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I" });
            g.AddEdges(0, new int[] { 1, 2 });
            g.AddEdges(1, new int[] { 0, 3, 4 });
            g.AddEdges(2, new int[] { 0, 3, 5 });
            g.AddEdges(3, new int[] { 1, 2, 4 });
            g.AddEdges(4, new int[] { 1, 5 });
            g.AddEdges(5, new int[] { 2, 3, 4, 7 });
            g.AddEdges(6, new int[] { 7, 8 });
            g.AddEdges(7, new int[] { 5, 6, 8 });
            g.AddEdges(8, new int[] { 6, 7 });
            g.BFS();
            Console.WriteLine("------------------------");
            g.DFS();
            #endregion

            #endregion
        }
    }
}
