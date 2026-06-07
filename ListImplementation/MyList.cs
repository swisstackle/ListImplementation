using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation
{
    public class MyList<T> : IList<T>, ICollection<T>, IEnumerable<T>
    {
        private T[] _items;
        private int _size;
        private int _version;
        private static readonly T[] s_emptyArray = new T[0];

        public MyList()
        {
            _items = s_emptyArray;
            _size = 0;
        }

        private void Grow()
        {
            if (_size >= _items.Length)
            {
                var newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;
                Array.Resize(ref _items, newCapacity);
            }
        }
    }
}
