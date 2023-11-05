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
        private static T[] s_emptyArray = new T[0];
        public int Count { get =>_size; }
        private int Capacity 
        { 
            get => _array.Length;

            set 
            {
                if (value < _size)
                    ExceptionHelper.ThrowCustomIndexOutOfBoundsException();
                if (value != _array.Length)
                {
                    if(value > 0)
                    {
                        Array.Resize<T>(ref _array, value);
                        return;
                    }
                    _array = CustomList<T>.s_emptyArray;
                }
            }
        }


        public CustomList() { }

        public CustomList(int capacity) 
        {
            if(capacity < 0)
                ExceptionHelper.ThrowCustomIndexOutOfBoundsException();
            if(capacity == 0)
            {
                _array = CustomList<T>.s_emptyArray;
                return;
            }
            _array = new T[capacity];
        }


        public void Add(T item)
        {
            var arrayLength = _array.Length;

            if(_size < arrayLength)
            {
                _array[_size] = item;
                _size += 1;
                return;
            }
            AddAndResize(item);
        }

        private void AddAndResize(T item)
        {
            Grow();
            Add(item);
        }

        private void Grow()
        {
            int capacity = _array.Length == 0 ? 4 : _array.Length * 2;

            if (capacity > Array.MaxLength)
                capacity = Array.MaxLength;

            if(capacity < _size)
                capacity = _size;

            Capacity = capacity;
        }

        public void Clear() 
        {
            if(typeof(T).IsValueType)
            {
                _size = 0;
            }
            else
            {
                if(_size>0)
                {
                    Array.Clear(_array, 0, _size);
                }
                _size = 0;
            }
        }

        public bool Exists(T item) 
        {
            return IndexOf(item) != -1;
        }

        public bool Remove(T itemToRemove)
        {
            if (_size == 0)
                return false;
            
            int indx = IndexOf(itemToRemove);

            if(indx >= 0)
            {
                return RemoveAt(indx);
            }
            return false;
        }

        public bool RemoveAt(int indx)
        {
            if (indx >= _size)
                ExceptionHelper.ThrowCustomIndexOutOfBoundsException();
            if (indx == -1)
                return false;

            ShiftBack(indx, _size - 1);

            if (!typeof(T).IsValueType)
                _array[_size - 1] = default(T);

            _size--;

            return true;
        }

        private void ShiftBack(int startIdx, int endIdx)
        {
            for (int i = startIdx; i < endIdx; i++)
            {
                _array[i] = _array[i+1];
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

        public T Get(int indx)
        {
            if (indx < 0 || indx >= _size)
                ExceptionHelper.ThrowCustomIndexOutOfBoundsException();
            return _array[indx];
        }

        public void Set(int indx, T value)
        {
            if (indx < 0 || indx >= _size)
                ExceptionHelper.ThrowCustomIndexOutOfBoundsException();
            _array[indx] = value;
        }

        public T this[int indx]
        {
            get => Get(indx);
            set => Set(indx, value);
        }

        public override string ToString()
        {
            if (_size == 0)
                return "<- array is empty ->";

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
