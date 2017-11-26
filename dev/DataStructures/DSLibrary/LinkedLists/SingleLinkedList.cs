
namespace DSLibrary.LinkedLists
{
    using DSLibrary.Abstracts;
    using DSLibrary.Models;
    using System;

    /// <summary>
    /// Single linked list class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T> : AbstractLinkedList<T>
    {
        /// <summary>
        /// Gets or sets the header node of single linked list
        /// </summary>
        public SingleLinkedNode<T> Head { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkedList{T}"/> class.
        /// </summary>
        public SingleLinkedList()
        {
            this.Head = new SingleLinkedNode<T>();
        }

        /// <summary>
        /// Add a node at the begining of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void AddFirst(T data)
        {
            // Create a node with the data
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(data);

            if (this.Head.Next != null)
            {
                newNode.Next = this.Head.Next;
            }

            this.Head.Next = newNode;
        }

        /// <summary>
        /// Add the node at the end of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void AddLast(T data)
        {
            // Create a node with the data
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(data);

            // Traverse till the end
            SingleLinkedNode<T> current = this.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        /// <summary>
        ///  Insert the node after a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public override void InsertAfter(T after, T data)
        {
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(data);

            SingleLinkedNode<T> nodeAfter = this.FindNode(after);
            newNode.Next = nodeAfter.Next;
            nodeAfter.Next = newNode;
        }

        /// <summary>
        ///  Insert the node before a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public override void InsertBefore(T before, T data)
        {
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(data);

            SingleLinkedNode<T> current = this.Head;
            bool nodeFound = false;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(before))
                {
                    nodeFound = true;
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }

            if (!nodeFound)
            {
                throw new Exception("Before item not found");
            }
        }

        /// <summary>
        /// Display all the node in list
        /// </summary>
        public override void Display()
        {
            SingleLinkedNode<T> current = this.Head.Next;

            while (current != null)
            {
                Console.Write("{0}\t", current.Data.ToString());
                current = current.Next;
            }
        }

        /// <summary>
        /// Find the element
        /// </summary>
        /// <param name="data">an element to find</param>
        /// <returns>Target node</returns>
        private SingleLinkedNode<T> FindNode(T data)
        {
            SingleLinkedNode<T> current = this.Head.Next;
            while (current != null)
            {
                if (current.Data.Equals(data)) {
                    return current;
                }
            }

            return null;
        }
    }
}
