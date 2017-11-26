
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

            SingleLinkedList.AddLast(10);
            SingleLinkedList.AddFirst(5);
            SingleLinkedList.InsertAfter(5, 8);
            SingleLinkedList.InsertBefore(8, 6);

            SingleLinkedList.Display();
            Console.Read();
        }
    }
}
