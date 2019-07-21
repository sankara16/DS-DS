using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Abstracts
{
    public abstract class AbstractQueue<T>
    {
        /// <summary>
        /// Method to get the top or peek of the queue.
        /// </summary>
        /// <returns></returns>
        public abstract T Peek();

        /// <summary>
        /// Method to push element to the top of the queue. 
        /// </summary>
        /// <param name="data">new element</param>
        public abstract void Enqueue(T data);

        /// <summary>
        /// Method to remove the element from top of the queue. 
        /// </summary>
        public abstract void DeQueue();

        /// <summary>
        /// Clear the queue.
        /// </summary>
        public abstract void Clear();
    }
}
