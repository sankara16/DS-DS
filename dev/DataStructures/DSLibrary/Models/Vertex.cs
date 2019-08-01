using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Models
{
    public class Vertex<T>
    {
        public T Data { get; set; }

        public int Distance { get; set; }

        public Vertex(T data)
        {
            this.Data = data;
            this.Distance = 0;
        }
    }
}
