using System;
using System.Collections;

namespace Module_3_Task_1_Vasylchenko
{
    public class List<T>
    {
        private T[] _array = new T[5];
        private int _counter = 0;

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < _counter; i++)
            {
                yield return _array[i];
            }
        }

        public void Add(T value)
        {
            if (_counter + 1 <= _array.Length)
            {
                _array[_counter] = value;
                _counter++;
            }
            else
            {
                Array.Resize(ref _array, _array.Length * 2);
                _array[_counter] = value;
                _counter++;
            }
        }

        public void AddRange(T[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public void RemoveAt(int number)
        {
            for (var j = number; j < _counter - 1; j++)
            {
                _array[j] = _array[j + 1];
            }

            _array[_counter - 1] = default(T);
            _counter--;
        }

        public bool Remove(T value)
        {
            for (var i = 0; i < _counter; i++)
            {
                if (_array[i].Equals(value))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public void Sort()
        {
            Array.Sort(_array, 0, _counter);
        }
    }
}
