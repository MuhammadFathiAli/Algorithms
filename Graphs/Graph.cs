using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graphs
{
    public class Graph
    {
        private int LastIndex = 0;
        private Vertex[] Vertices;

        public Graph(string[] names)
        {
            Vertices = new Vertex[names.Length];
            foreach (string name in names)
            {
                Vertices[LastIndex] = new Vertex();
                Vertices[LastIndex].Name = name;
                LastIndex++;
            }
        }
        public void AddEdges(int vertexIndex, int[] targetsIndex)
        {
            Vertices[vertexIndex].VertexLinks = new Edge[targetsIndex.Length];
            for (int i = 0; i < targetsIndex.Length; i++)
            {
                Vertices[vertexIndex].VertexLinks[i] =
                        new Edge(Vertices[vertexIndex], Vertices[targetsIndex[i]]);
            }
        }
        public void BFS()
        {
            Console.WriteLine("BFS From Graph Class;");
            int verticesLength = Vertices.Length;
            Queue<Vertex> queue = new Queue<Vertex>(verticesLength);
            queue.Enqueue(Vertices[0]);
            Vertices[0].Visited = true;
            Vertex currentVertex;
            while (queue.Count > 0)
            {
                currentVertex = queue.Dequeue();
                for (int i = 0; i < currentVertex.VertexLinks.Length; i++)
                {
                    if (!currentVertex.VertexLinks[i].Target.Visited)
                    {
                        queue.Enqueue(currentVertex.VertexLinks[i].Target);
                        currentVertex.VertexLinks[i].Target.Visited = true;
                        Console.WriteLine(currentVertex.Name + " - " +
                            currentVertex.VertexLinks[i].Target.Name);
                    }
                }
            }
            RestoreVertices();
        }
        public void DFS()
        {
            DFSRecursion(Vertices[0]);
            RestoreVertices();
        }
        private void DFSRecursion(Vertex currentVertex)
        {
            Edge[] links = currentVertex.VertexLinks;
            currentVertex.Visited = true;
            for (int i = 0; i < links.Length; i++)
            {
                if (!links[i].Target.Visited)
                {

                    Console.WriteLine(currentVertex.Name + " - " +
                            currentVertex.VertexLinks[i].Target.Name);
                    DFSRecursion(links[i].Target);
                }
            }
        }

        private void RestoreVertices()
        {
            foreach (Vertex v in this.Vertices)
            {
                v.Visited = false;
            }
        }

        private class Vertex
        {
            public string Name;
            public bool Visited;
            public Edge[] VertexLinks;
        }
        private class Edge
        {
            public Vertex Source;
            public Vertex Target;
            public double Weight;

            public Edge(Vertex source, Vertex target, double weight = 0)
            {
                Source = source;
                Target = target;
                Weight = weight;
            }
        }
    }
}
