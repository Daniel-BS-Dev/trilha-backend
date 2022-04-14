using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndGenerics
{
    class TypeGenerics<T>
    {
        private T[] _items;
        private int _nextPosition;


        public T Length()
        {
            return _items[1];
        }

        public void Add(T index)
        {
           _items[_nextPosition] = index;
        }
    }
}
