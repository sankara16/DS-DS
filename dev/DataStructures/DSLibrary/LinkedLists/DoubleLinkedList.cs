

namespace DSLibrary.LinkedLists
{
    using DSLibrary.Abstracts;
    using DSLibrary.Models;
    using System;

    /// <summary>
    /// Class for double linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoubleLinkedList<T> : AbstractLinkedList<T>
    {
        /// <summary>
        /// Gets or sets the header node of double linked list
        /// </summary>
        public DoubleLinkedNode<T> Head { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLinkedList{T}"/> class.
        /// </summary>
        public DoubleLinkedList()
        {
            this.Head = new DoubleLinkedNode<T>();
        }

        /// <summary>
        /// Add a node at the begining of the list
        /// </summary>
        /// <param name="data"></param>
        public override void AddFirst(T data)
        {
            DoubleLinkedNode<T> newNode = new DoubleLinkedNode<T>(data);

            if (this.Head.Next != null)
            {
                newNode.Next = this.Head.Next;
            }

            this.Head.Next = newNode;
        }

        /// <summary>
        /// Add the node at the end of the list
        /// </summary>
        /// <param name="data"></param>
        public override void AddLast(T data)
        {
            // Create a node with the data
            DoubleLinkedNode<T> newNode = new DoubleLinkedNode<T>(data);

            // Traverse till the end
            DoubleLinkedNode<T> current = this.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Previous = current;
        }

        /// <summary>
        ///  Insert the node after a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting after</param>
        /// <param name="data">value of the node</param>
        public override void InsertAfter(T after, T data)
        {
            DoubleLinkedNode<T> newNode = new DoubleLinkedNode<T>(data);

            DoubleLinkedNode<T> nodeAfter = this.FindNode(after);
            newNode.Next = nodeAfter.Next;
            newNode.Previous = nodeAfter;
            nodeAfter.Next.Previous = newNode;
            nodeAfter.Next = newNode;
        }

        /// <summary>
        ///  Insert the node before a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public override void InsertBefore(T before, T data)
        {
            DoubleLinkedNode<T> newNode = new DoubleLinkedNode<T>(data);

            DoubleLinkedNode<T> nodeBefore = this.FindNode(before);
            newNode.Next = nodeBefore;
            newNode.Previous = nodeBefore.Previous;
            nodeBefore.Previous.Next = newNode;
            nodeBefore.Previous = newNode;            
        }

        /// <summary>
        ///  Display all the nodes
        /// </summary>
        public override void Display()
        {
            DoubleLinkedNode<T> current = this.Head.Next;

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
        private DoubleLinkedNode<T> FindNode(T data)
        {
            DoubleLinkedNode<T> current = this.Head.Next;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        /// <summary>
        /// Delete the node from the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void Delete(T data)
        {
            DoubleLinkedNode<T> itemToBeDeleted = this.FindNode(data);

            if (itemToBeDeleted == null)
            {
                throw new ArgumentNullException("Item not found");
            }

            itemToBeDeleted.Previous.Next = itemToBeDeleted.Previous.Next.Next;
            itemToBeDeleted.Next.Previous = itemToBeDeleted.Next.Previous.Previous;
        }
    }
}
