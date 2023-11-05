using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week5_GenericsTask_Due5Nov
{
    internal class CustomList<T> 
    {
        private T[] _array = new T[0];
        private int _size = 0;
        private int Capacity { get => _array.Length;}

        //public int Count { ; }

        public CustomList()
        {
            
        }

        public void Add(T item)
        {
            var arrayLength = _array.Length;
            var size = _size;

            if(size < arrayLength)
            {
                _array[_size] = item;
                return;
            }
            AddAndResize(item);
        }

        private void AddAndResize(T item)
        {
            Grow();
            _array[_size++] = item;
        }

        private void Grow()
        {
            int capacity = _array.Length == 0 ? 4 : _array.Length * 2;

            if (capacity > Array.MaxLength)
                capacity = Array.MaxLength;

            if(capacity > Capacity)
                Array.Resize<T>(ref _array,capacity);
        }

        public void Clear() 
        {
            if(typeof(T).IsValueType)
            {
                _size = 0;
            }
            else
            {
                Array.Clear(_array, 0, _size);
            }
        }

        public bool Exists(T item) 
        {
            return IndexOf(item) != -1;
        }

        public bool Remove(T itemToRemove)
        {
            if (_array.Length == 0)
                return false;

            for (int i = 0; i < _size; i++)
            {
                if (_array[i] != null && _array[i].Equals(itemToRemove))
                {
                    ShiftBack(1,i,_size-1);
                    
                    if (!typeof(T).IsValueType)
                        _array[_size - 1] = default;

                    _size--;
                    
                    return true;
                }
            }
            return false;
        }

        private void ShiftBack(int stepToShift,int startIdx, int endIdx)
        {
            for (int i = endIdx; i > startIdx; i--)
            {
                _array[i-1] = _array[i];
            }
        }

        public void Reverse()
        {
            T temp;
            for(int i = 0; i< _size/2; i++)
            {
                temp = _array[i];
                _array[i] = _array[_size - i - 1];
                _array[_size - i - 1] = temp;
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (item == null && _array[i] == null)
                    return i;
                if (_array[i] != null && _array[i].Equals(item))
                    return i;
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = _size-1; i != -1; i--)
            {
                if (item == null && _array[i] == null)
                    return i;
                if (_array[i] != null && _array[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public override string ToString()
        {
            if (_size == 0)
                return "<array is empty>";

            StringBuilder stringBuilder = new StringBuilder();
            for(int i =0;i < _size; i++)
            {
                stringBuilder.Append(_array[i]);
                stringBuilder.Append(", ");
            }
            return stringBuilder.ToString();
        }
    }
}
