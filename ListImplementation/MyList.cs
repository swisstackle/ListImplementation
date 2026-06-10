using System;
using System.Collections;
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

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index]
        {

            get
            {
                if ((uint)index >= (uint)_size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return _items[index];
            }

            set
            {
                if ((uint)index >= (uint)_size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                _items[index] = value;
                _version++;
            }
        }

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

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            if ((uint)index >= (uint)_size) throw new ArgumentOutOfRangeException();
            _size--;
            if (index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }
            _items[_size] = default!;
            _version++;
        }

        public void Add(T item)
        {
            Grow();
            _items[_size] = item;
            _size++;
            _version++;
        }

        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_items, 0, _size);
                _size = 0;
            }
            _version++;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public Enumerator GetEnumerator() => new Enumerator(this);

        // Explicit implementation for the generic interface
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();

        // Explicit implementation for the legacy interface
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
