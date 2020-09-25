using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayListAndGenerics
{
    class MyArrayList<T>
    {
        private T[] _data;
        public int Length { get; set; }

        public MyArrayList()
        {
            _data = new T[2];
            Length = 0;
        }

        public void Add(T value)
        {
            if (Length >= _data.Length)
            {
                var newCapacity = _data.Length * 2;
                Console.WriteLine($"Øker kapasitet til {newCapacity}");
                var newData = new T[newCapacity];
                Array.ConstrainedCopy(
                    _data, 
                    0, 
                    newData, 
                    0, 
                    _data.Length
                    );
                _data = newData;
            }

            var index = Length;
            _data[index] = value;
            Length++;
        }

        public T GetValue(int index)
        {
            return _data[index];
        }
    }
}
