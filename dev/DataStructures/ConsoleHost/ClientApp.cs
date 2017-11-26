
namespace ConsoleHost
{
    using DSLibrary.LinkedLists;
    using System;
    using System.Threading.Tasks;

    public class ClientApp
    {
        public static void Main(string[] args)
        {
            SingleLinkedList<int> SingleLinkedList = new SingleLinkedList<int>();
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            CircularLinkedList<int> circularLinkedlist = new CircularLinkedList<int>();

            // Single linked list
            //SingleLinkedList.AddLast(10);
            //SingleLinkedList.AddFirst(5);
            //SingleLinkedList.InsertAfter(5, 8);
            //SingleLinkedList.InsertBefore(8, 6);
            //SingleLinkedList.Display();

            // Double linked list
            //doubleLinkedList.AddLast(10);
            //doubleLinkedList.AddFirst(5);
            //doubleLinkedList.InsertAfter(5, 8);
            //doubleLinkedList.InsertBefore(8, 6);
            //doubleLinkedList.Display();

            // Circular linkedlist
            circularLinkedlist.AddLast(10);
            circularLinkedlist.AddFirst(5);
            circularLinkedlist.InsertAfter(5, 8);
            circularLinkedlist.InsertBefore(8, 6);
            circularLinkedlist.Display();

            Console.Read();
        }
    }
}
