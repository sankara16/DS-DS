using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DSLibrary.Graph;
using DSLibrary.LinkedLists;
using DSLibrary.Models;
using DSLibrary.Queue;
using DSLibrary.Stack;
using DSLibrary.Tree;
using DSQuestions.DynamicProgramming;
using DSQuestions.Greedy;
using DSQuestions.Hashing;
using DSQuestions.Randomized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSTestProj
{
    [TestClass]
    public class TestClient
    {
        [TestMethod]
        [TestCategory("DSCore")]
        public void TestSingleLinkedList()
        {
            SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();

            singleLinkedList.AddLast(10);
            singleLinkedList.AddFirst(5);
            singleLinkedList.InsertAfter(5, 8);
            singleLinkedList.InsertBefore(8, 6);
            // SingleLinkedList.Display();

            Assert.IsTrue(singleLinkedList.Head.Next.Data == 5);
        }

        [TestMethod]
        [TestCategory("DSCore")]
        public void TestDoubleLinkedList()
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

            doubleLinkedList.AddLast(10);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.InsertAfter(5, 8);
            doubleLinkedList.InsertBefore(8, 6);
            //doubleLinkedList.Display();

            Assert.IsTrue(doubleLinkedList.Head.Next.Data == 5);
        }

        [TestMethod]
        [TestCategory("DSCore")]
        public void TestCircularLinkedList()
        {
            CircularLinkedList<int> circularLinkedlist = new CircularLinkedList<int>();

            circularLinkedlist.AddLast(10);
            circularLinkedlist.AddFirst(5);
            circularLinkedlist.InsertAfter(5, 8);
            circularLinkedlist.InsertBefore(8, 6);
            circularLinkedlist.Delete(6);
            //circularLinkedlist.Display();

            Assert.IsTrue(circularLinkedlist.Head.Next.Data == 5);
        }

        [TestMethod]
        [TestCategory("DSCore")]
        public void TestStack()
        {
            DSLibrary.Stack.Stack<int> stack = new DSLibrary.Stack.Stack<int>();

            stack.Push(20);
            stack.Push(10);
            stack.Push(8);

            int res = stack.Pop();

            Assert.IsTrue(res == 8);
        }

        [TestMethod]
        [TestCategory("DSCore")]
        public void TestQueue()
        {
            DSLibrary.Queue.Queue<int> queue = new DSLibrary.Queue.Queue<int>();

            queue.Enqueue(20);
            queue.Enqueue(10);
            queue.Enqueue(8);
            queue.DeQueue();
            queue.DeQueue();

            Assert.IsTrue(queue.Peek() == 8);
        }

        [TestMethod]
        [TestCategory("DSCore")]
        public void TestGraph()
        {
            int verticesCount = 5;
            int edgesCount = 8;
            Graph<char> graph = new Graph<char>(verticesCount, edgesCount);
            Vertex<char> vertex1 = new Vertex<char>('A');
            Vertex<char> vertex2 = new Vertex<char>('B');
            Vertex<char> vertex3 = new Vertex<char>('C');
            Vertex<char> vertex4 = new Vertex<char>('D');
            Vertex<char> vertex5 = new Vertex<char>('E');

            graph.Edges[0] = new Edge<char>();
            graph.Edges[0].Source = vertex1;
            graph.Edges[0].Destination = vertex2;
            graph.Edges[0].Weight = -1;

            // Edge 0-2
            graph.Edges[1] = new Edge<char>();
            graph.Edges[1].Source = vertex1;
            graph.Edges[1].Destination = vertex3;
            graph.Edges[1].Weight = 4;

            // Edge 1-2
            graph.Edges[2] = new Edge<char>();
            graph.Edges[2].Source = vertex2;
            graph.Edges[2].Destination = vertex3;
            graph.Edges[2].Weight = 3;

            // Edge 1-3
            graph.Edges[3] = new Edge<char>();
            graph.Edges[3].Source = vertex2;
            graph.Edges[3].Destination = vertex4;
            graph.Edges[3].Weight = 2;

            // Edge 1-4
            graph.Edges[4] = new Edge<char>();
            graph.Edges[4].Source = vertex2;
            graph.Edges[4].Destination = vertex5;
            graph.Edges[4].Weight = 2;

            // Edge 3-2
            graph.Edges[5] = new Edge<char>();
            graph.Edges[5].Source = vertex4;
            graph.Edges[5].Destination = vertex3;
            graph.Edges[5].Weight = 5;

            // Edge 3-1
            graph.Edges[6] = new Edge<char>();
            graph.Edges[6].Source = vertex4;
            graph.Edges[6].Destination = vertex2;
            graph.Edges[6].Weight = 1;

            // Edge 4-3
            graph.Edges[7] = new Edge<char>();
            graph.Edges[7].Source = vertex5;
            graph.Edges[7].Destination = vertex4;
            graph.Edges[7].Weight = -3;

            IList<Vertex<char>> vertices = DPAlgos<char>.BellmanFordAlgorithm(graph, vertex1);

            Assert.IsTrue(vertices.Count > 0);
        }

        [TestMethod]
        [TestCategory("Test")]
        public void TestStringCompare()
        {
            string str1 = "Sankara";
            string str2 = "Sankarae";
            string str3 = "Sankara";

            bool val1 = string.Compare(str1, str2) < 0;
            bool val2 = string.Compare(str2, str1) > 0;
            bool val3 = string.Compare(str1, str3) == 0;

            Assert.IsTrue(val3);
        }

        [TestMethod]
        [TestCategory("DSQuestions-Greedy")]
        public void ActivitySelectionProblem()
        {
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            list.Add(new KeyValuePair<int, int>(1, 4));
            list.Add(new KeyValuePair<int, int>(3, 5));
            list.Add(new KeyValuePair<int, int>(0, 6));
            list.Add(new KeyValuePair<int, int>(5, 7));
            list.Add(new KeyValuePair<int, int>(3, 8));
            list.Add(new KeyValuePair<int, int>(5, 9));
            list.Add(new KeyValuePair<int, int>(6, 10));
            list.Add(new KeyValuePair<int, int>(8, 11));
            list.Add(new KeyValuePair<int, int>(8, 12));
            list.Add(new KeyValuePair<int, int>(2, 13));
            list.Add(new KeyValuePair<int, int>(12, 14));

            var result = GreedyAlgos.ActivitySelectionProblem(list);

            Assert.IsTrue(result.Count == 4);
        }

        [TestMethod]
        [TestCategory("Algorithms")]
        public void TestHuffmanCodingProblem()
        {
            HuffmanTree hfmTree = new HuffmanTree();
            string input = "sankara loves devi";

            hfmTree.Build(input);

            BitArray encoded = hfmTree.Encode(input);

            string decoded = hfmTree.Decode(encoded);

            Assert.IsTrue(input == decoded);
        }

        [TestMethod]
        [TestCategory("Algorithms")]
        public void TestKnapsackProblem()
        {
            //int[] value = { 10, 50, 70};
            //int[] weight = { 10, 20, 30};
            //int capacity = 40;
            //int itemCount = 3;

            var items = new[]
            {
                new KnapsackItem {Value = 10, Weight = 10},
                new KnapsackItem {Value = 50, Weight = 20},
                new KnapsackItem {Value = 70, Weight = 30},
            };

            int result = DPAlgos<int>.KnapSack(items, 40, 3);
            //int result = DPAlgos.KnapsackProblem(capacity, weight, value, itemCount);

            Assert.IsTrue(result == 80);
        }

        [TestMethod]
        [TestCategory("DSQuestions-Array")]
        public void TestFindPairWithGivenSumInAnArray()
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };

            var result = HashAlgos.FindPairWithGivenSumInAnArray(arr, 10);

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        [TestCategory("DSQuestions-Array")]
        public void TestFindSubArrayWithGivenSum()
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int sum = 23;

            var result = RandomAlgos.FindSubArrayWithGivenSum(arr, sum);

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        [TestCategory("DSQuestions-Array")]
        public void TestSortBinaryArrayInLinearTime()
        {
            int[] array = { 1, 0, 1, 0, 1, 0, 0, 1};
            int[] output = { 0, 0, 0, 0, 1, 1, 1, 1 };

            var result = RandomAlgos.SortBinaryArrayInLinearTime(array);

            Assert.IsTrue(result.SequenceEqual(output));
        }

        [TestMethod]
        [TestCategory("DSQuestions-Array")]
        public void TestFindDuplicateElementInLimitedRangeArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 3};

            int result = RandomAlgos.FindDuplicateElementInimitedRangeArray(array);

            Assert.IsTrue(result == 3);
        }
    }
}
