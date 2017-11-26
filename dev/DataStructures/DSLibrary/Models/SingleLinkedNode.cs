
namespace DSLibrary.Models
{
    /// <summary>
    /// Model for single linked node
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public class SingleLinkedNode<T>
    {
        /// <summary>
        /// Node value
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Single linked list next pointer
        /// </summary>
        public SingleLinkedNode<T> Next { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkedNode{T}"/> class.
        /// </summary>
        public SingleLinkedNode()
        {
            this.Data = default(T);
            this.Next = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLinkedNode{T}"/> class.
        /// </summary>
        /// <param name="value">node value</param>
        public SingleLinkedNode(T value)
        {
            this.Data = value;
            this.Next = null;
        }
    }
}
