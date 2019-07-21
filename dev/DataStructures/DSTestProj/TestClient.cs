using System;
using DSLibrary.LinkedLists;
using DSLibrary.Queue;
using DSLibrary.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSTestProj
{
    [TestClass]
    public class TestClient
    {
        [TestMethod]
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
        public void TestStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(20);
            stack.Push(10);
            stack.Push(8);

            int res = stack.Pop();

            Assert.IsTrue(res == 8);
        }
        
        [TestMethod]
        public void TestQueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(20);
            queue.Enqueue(10);
            queue.Enqueue(8);
            queue.DeQueue();
            queue.DeQueue();

            Assert.IsTrue(queue.Peek() == 8);
        }
    }
}
