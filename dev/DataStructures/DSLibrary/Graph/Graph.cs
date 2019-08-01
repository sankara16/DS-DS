using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSLibrary.Models;

namespace DSLibrary.Graph
{
    public class Graph<T>
    {
        public int VerticesCount { get; set; }

        public int EdgeCount { get; set; }

        public Edge<T>[] Edges { get; set; }

        public Graph(int verticesCount, int edgesCount)
        {
            this.VerticesCount = verticesCount;
            this.EdgeCount = edgesCount;
            this.Edges = new Edge<T>[edgesCount];
        }

        public void Display()
        {
            for (int i = 0; i < Edges.Length; i++)
            {
                Console.WriteLine("[{0}, {1}]", Edges[i].Source.Data, Edges[i].Destination.Data);
            }
        }
    }
}
