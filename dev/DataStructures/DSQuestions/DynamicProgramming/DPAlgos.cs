using DSLibrary.Graph;
using DSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSQuestions.DynamicProgramming
{
    public static class DPAlgos<T>
    {
        public static int KnapSack(KnapsackItem[] items, int capacity, int itemCount)
        {
            int[,] matrix = new int[itemCount + 1, capacity + 1];
            for (int itemIndex = 0; itemIndex <= itemCount; itemIndex++)
            {
                // This adjusts the itemIndex to be 1 based instead of 0 based
                // and in this case 0 is the initial state before an item is
                // considered for the knapsack.
                var currentItem = itemIndex == 0 ? null : items[itemIndex - 1];
                for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                {
                    // Set the first row and column of the matrix to all zeros
                    // This is the state before any items are added and when the
                    // potential capacity is zero the value would also be zero.
                    if (currentItem == null || currentCapacity == 0)
                    {
                        matrix[itemIndex, currentCapacity] = 0;
                    }
                    // If the current items weight is less than the current capacity
                    // then we should see if adding this item to the knapsack 
                    // results in a greater value than what was determined for
                    // the previous item at this potential capacity.
                    else if (currentItem.Weight <= currentCapacity)
                    {
                        matrix[itemIndex, currentCapacity] = Math.Max(
                            currentItem.Value
                                + matrix[itemIndex - 1, currentCapacity - currentItem.Weight],
                            matrix[itemIndex - 1, currentCapacity]);
                    }
                    // current item will not fit so just set the value to the 
                    // what it was after handling the previous item.
                    else
                    {
                        matrix[itemIndex, currentCapacity] =
                            matrix[itemIndex - 1, currentCapacity];
                    }
                }
            }

            // The solution should be the value determined after considering all
            // items at all the intermediate potential capacities.
            return matrix[itemCount, capacity];
        }

        /// <summary>
        /// About Algo: An  an algorithm that computes shortest paths from 
        /// a single source vertex to all of the other vertices in a weighted digraph
        /// </summary>
        /// <param name="graph">given graph</param>
        /// <param name="source">source vertex</param>
        /// <returns>List of vertices</returns>
        public static IList<Vertex<T>> BellmanFordAlgorithm(Graph<T> graph, Vertex<T> source)
        {
            int verticesCount = graph.VerticesCount;
            int edgesCount = graph.EdgeCount;
            //int[] distance = new int[verticesCount];
            //Vertex<T>[] vertices = new Vertex<T>[verticesCount];
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            // assign all veritices to max weight except souce which is zero. 
            for (int i = 0; i < edgesCount; i++)
            {
                Vertex<T> start = graph.Edges[i].Source;
                Vertex<T> end = graph.Edges[i].Destination;

                if (start == source)
                {
                    start.Distance = 0;
                }
                else
                {
                    start.Distance = int.MaxValue;
                }
                if (end == source)
                {
                    start.Distance = 0;
                }
                else
                {
                    end.Distance = int.MaxValue;
                }
            }

            for (int i = 1; i < verticesCount; i++)
            {
                for (int j = 0; j < edgesCount; j++)
                {
                    int start = graph.Edges[j].Source.Distance;
                    int end = graph.Edges[j].Destination.Distance;
                    int weight = graph.Edges[j].Weight;

                    if (start != int.MaxValue && end > start + weight)
                    {
                        graph.Edges[j].Destination.Distance = start + weight;
                    }
                }
            }

            for (int i = 0; i < edgesCount; i++)
            {
                int start = graph.Edges[i].Source.Distance;
                int end = graph.Edges[i].Destination.Distance;
                int weight = graph.Edges[i].Weight;

                if (start != int.MaxValue && end > start + weight)
                {
                    throw new Exception("Graph has negative weight cycle.");
                }
            }


            for (int i = 0; i < edgesCount; i++)
            {
                Vertex<T> start = graph.Edges[i].Source;
                Vertex<T> end = graph.Edges[i].Destination;

                if (!vertices.Contains(start))
                {
                    vertices.Add(start);
                }

                if (!vertices.Contains(end))
                {
                    vertices.Add(end);
                }
            }

            return vertices;
        }

        /// <summary>
        /// Floyd–Warshall algorithm (also known as Floyd's algorithm, the Roy–Warshall algorithm,
        /// the Roy–Floyd algorithm, or the WFI algorithm) is an algorithm 
        /// for finding shortest paths in a weighted graph with positive or negative edge 
        /// weights (but with no negative cycles)
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IList<Vertex<T>> FloyedWarshellAlgorithm(Graph<T> graph, Vertex<T> source)
        {
            throw new NotImplementedException();
        }
    }
}
