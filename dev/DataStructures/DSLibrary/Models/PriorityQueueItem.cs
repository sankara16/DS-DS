using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Models
{
    public struct PriorityQueueItem<T>
    {
        public int Priority;

        public T value;
    }
}
