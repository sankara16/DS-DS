using DSLibrary.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Stack
{
    public class Stack<T> : AbstractStack<T>
    {
        private ArrayList stack;

        public int p_index;

        public Stack()
        {
            stack = new ArrayList();
            p_index = -1;
        }

        /// <summary>
        /// Gets the count of elements in stack.
        /// </summary>
        public override int Count {
            get {
                return stack.Count;
            }
        }

        /// <summary>
        /// Method to get the top or peek of the stack.
        /// </summary>
        /// <returns></returns>
        public override T Peek()
        {
            return (T)stack[p_index];
        }

        /// <summary>
        /// Method to push element to the top of the stack. 
        /// </summary>
        /// <param name="data">new element</param>
        public override T Pop()
        {
           T data = (T)stack[p_index];
            stack.RemoveAt(p_index);
            p_index--;

            return data;
        }

        /// <summary>
        /// Method to remove the element from top of the stack. 
        /// </summary>
        /// <returns>Top/peek element.</returns>
        public override void Push(T data)
        {
            stack.Add(data);
            p_index++;
        }

        /// <summary>
        /// Clear the stack.
        /// </summary>
        public override void Clear()
        {
            stack.Clear();
        }
    }
}
