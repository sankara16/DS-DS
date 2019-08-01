using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Models
{
    public class Edge<T>
    {
        public Vertex<T> Source { get; set; }

        public Vertex<T> Destination { get; set; } 

        public int Weight { get; set; }
    }
}
