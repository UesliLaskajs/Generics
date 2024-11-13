using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public interface IProducts
    {
        int id { get; }
    }

    internal class Products<T> where T : IProducts
    {
        List<T> products =new List<T>();

        public void addItems(T items)
        {
            products.Add(items);
        }
    }
}
