using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Box<T>
    {
        private  T _value;
        public Box(T initalValue)
        {
            _value = initalValue;
        }

        public void UpdateValue(T value)
        {
            _value=value;
            Console.WriteLine(_value);
        }

        public T GetValue()
        {
            return _value;
        }

    }
}
