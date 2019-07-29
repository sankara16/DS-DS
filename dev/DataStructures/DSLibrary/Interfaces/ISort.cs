using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Interfaces
{
    public interface ISort<T>
    {
        void Sort<T>(T[] array);
    }
}
