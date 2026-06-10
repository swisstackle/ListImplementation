using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation
{
    public struct Enumerator<T> : IEnumerator<T>, IEnumerator
    {

        private readonly MyList<T> _list;
        private int _index;
        private readonly int _version;
        public T? Current;

        object IEnumerator.Current => throw new NotImplementedException();

        T IEnumerator<T>.Current => throw new NotImplementedException();


        internal Enumerator(MyList<T> list)
        {
            _list = list;
            _version = 0;
            _index = 0;
            Current = default;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
