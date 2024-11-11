using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MultipleGenerics<T, X>
    {
        public T FirstVal { get; set; }
        public X SecondVal { get; set; }

        public MultipleGenerics(T firstVal,X secondVal )
        {
            FirstVal = firstVal;
            SecondVal = secondVal;
        }

        public T GetVal()
        {
            return FirstVal;
        }

        public X GetSecondVal()
            {
            return SecondVal;
        }

    }
}
