using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Abstracts
{
    public abstract class AbstractStack<T>
    {
        /// <summary>
        /// Gets the count of elements in stack.
        /// </summary>
        public abstract int Count { get; }

        /// <summary>
        /// Method to get the top or peek of the stack.
        /// </summary>
        /// <returns></returns>
        public abstract T Peek();

        /// <summary>
        /// Method to push element to the top of the stack. 
        /// </summary>
        /// <param name="data">new element</param>
        public abstract void Push(T data);

        /// <summary>
        /// Method to remove the element from top of the stack. 
        /// </summary>
        /// <returns>Top/peek element.</returns>
        public abstract T Pop();

        /// <summary>
        /// Clear the stack.
        /// </summary>
        public abstract void Clear();
    }
}
