
namespace DSLibrary.Models
{
    /// <summary>
    /// Model for double linked node
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public class DoubleLinkedNode<T>
    {
        /// <summary>
        /// Node value
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Double linked list next pointer
        /// </summary>
        public DoubleLinkedNode<T> Next { get; set; }

        /// <summary>
        /// Double linked list previous pointer
        /// </summary>
        public DoubleLinkedNode<T> Previous { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLinkedNode{T}"/> class.
        /// </summary>
        public DoubleLinkedNode()
        {
            this.Data = default(T);
            this.Next = null;
            this.Previous = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLinkedNode{T}"/> class.
        /// </summary>
        /// <param name="value">node value</param>
        public DoubleLinkedNode(T value)
        {
            this.Data = value;
            this.Next = null;
            this.Previous = null;
        }
    }
}
