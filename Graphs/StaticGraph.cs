using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graphs
{
    public static class StaticGraph
    {
        public static void Prim_MST(double[,] graph, char[] labels)
        {
            int vertices = labels.Length;
            int selected_edges_count = 0;
            bool[] selected = new bool[vertices];
            selected[0] = true;
            while (selected_edges_count < vertices - 1)
            {
                double min = double.MaxValue;
                int temp_from = -1;
                int temp_to = -1;
                for (int i = 0; i < vertices; i++)
                {
                    if (selected[i] == true)
                    for (int j = 0; j < vertices; j++)
                    {
                            if (selected[j] == false && graph[i, j] > 0 && graph[i, j] < min)
                            {
                                min = graph[i, j];
                                temp_from = i;
                                temp_to = j;
                            }
                    }
                }
                selected[temp_to] = true;
                selected_edges_count++;
                Console.Write(labels[temp_from] + " - ");
                Console.Write(labels[temp_to] + " : ");
                Console.WriteLine(graph[temp_from, temp_to]);
            }

        }
    }
}
