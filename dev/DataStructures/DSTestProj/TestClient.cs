using System;
using DSLibrary.LinkedLists;
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
    }
}
