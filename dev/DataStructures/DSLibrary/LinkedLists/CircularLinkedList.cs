﻿
namespace DSLibrary.LinkedLists
{
    using DSLibrary.Abstracts;
    using DSLibrary.Models;
    using System;
     
    /// <summary>
    /// Circular linked list class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T> : AbstractLinkedList<T>
    {
        /// <summary>
        /// Gets or sets the circular linked list node head node
        /// </summary>
        public SingleLinkedNode<T> Head { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CircularLinkedList{T}"/> class.
        /// </summary>
        public CircularLinkedList()
        {
            this.Head = new SingleLinkedNode<T>();
            this.Head.Next = this.Head;
        }

        /// <summary>
        /// Add a node at the begining of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void AddFirst(T data)
        {
            // Create a node with the data
            SingleLinkedNode<T> newNode = new SingleLinkedNode<T>(data);

            newNode.Next = this.Head.Next;
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
            while (current.Next != Head)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Next = Head;
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
            while (current.Next != this.Head)
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

            while (current != Head)
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
            while (current != Head)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }
            }

            return null;
        }

        /// <summary>
        /// Delete the node from the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void Delete(T data)
        {
            SingleLinkedNode<T> current = this.Head;

            bool itemFound = false;
            while (current.Next != Head)
            {
                if (current.Next.Data.Equals(data))
                {
                    itemFound = true;
                    current.Next = current.Next.Next;
                    break;
                }

                current = current.Next;
            }

            if (!itemFound)
            {
                throw new Exception("Node not found");
            }
        }
    }
}
