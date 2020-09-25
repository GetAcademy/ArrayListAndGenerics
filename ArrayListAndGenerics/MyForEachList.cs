using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayListAndGenerics
{
    class MyForEachList : IEnumerable, IEnumerator
    {
        private int _currentNumber = 0;
        public object Current => _currentNumber;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            _currentNumber++;
            return _currentNumber < 10;
        }

        public void Reset()
        {
            _currentNumber = 0;
        }


    }
}
