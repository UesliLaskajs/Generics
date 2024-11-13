using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Constraints<T> where T :class
    {
        public void PrintVal(T item)
        { 
            Console.WriteLine(item.ToString());
        }
    }
}
