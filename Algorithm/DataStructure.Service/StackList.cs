using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Service
{
    public class StackList<T>
    {
        public StackList(int length = 100)
        {
            _arry = new T[length];
            _length = length;
        }

        private T[] _arry = null;

        private int _length = 0;

        private int _count = 0;

        public void Push(T item)
        {
            if (_count == _length)
            {
                _length = _length * 2;
                var tempArry = new T[_length];
                _arry.CopyTo(tempArry, 0);
                _arry = tempArry;
            }
            _arry[_count++] = item;
        }

        public bool Pop(ref T item)
        {
            if (_count == 0)
            {
                return false;
            }
            else
            {
                item = _arry[--_count];
                _arry[_count] = default(T);
                return true;
            }
        }
    }
}
