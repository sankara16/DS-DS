

namespace DSLibrary.Abstracts
{
    /// <summary>
    /// Linked list abstract linked list
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public abstract class AbstractLinkedList<T>
    {
        /// <summary>
        /// Add a node at the begining of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public abstract void AddFirst(T data);

        /// <summary>
        /// Add a node at the end of the list
        /// </summary>
        /// <param name="data">value of the node</param>
        public abstract void AddLast(T data);

        /// <summary>
        ///  Insert the node before a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public abstract void InsertBefore(T before, T data);

        /// <summary>
        ///  Insert the node after a spacific node
        /// </summary>
        /// <param name="after">Value of the node which we are inserting before</param>
        /// <param name="data">value of the node</param>
        public abstract void InsertAfter(T after, T data);

        /// <summary>
        /// Display all the nodes
        /// </summary>
        public abstract void Display();
    }
}
