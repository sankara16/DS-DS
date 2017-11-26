
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
        }

        /// <summary>
        /// Add a node at the begining of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void AddFirst(T data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add the node at the end of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public override void AddLast(T data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Insert the node after a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public override void InsertAfter(T after, T data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Insert the node before a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public override void InsertBefore(T before, T data)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
