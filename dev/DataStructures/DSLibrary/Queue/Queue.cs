using DSLibrary.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Queue
{
    public class Queue<T> : AbstractQueue<T>
    {
        private ArrayList queue;

        public Queue()
        {
            queue = new ArrayList();
        }

        /// <summary>
        /// Method to get the top or peek of the queue.
        /// </summary>
        /// <returns></returns>
        public override T Peek()
        {
            return (T)queue[0];
        }

        /// <summary>
        /// Method to push element to the top of the queue. 
        /// </summary>
        /// <param name="data">new element</param>
        public override void Enqueue(T data)
        {
            queue.Add(data);    
        }

        /// <summary>
        /// Method to remove the element from top of the queue. 
        /// </summary>
        public override void DeQueue()
        {
            queue.RemoveAt(0);
        }

        /// <summary>
        /// Clear the queue.
        /// </summary>
        public override void Clear()
        {
            queue.Clear();
        }
    }
}
