using System;
using System.Collections.Generic;
/// <summary>
/// MyClassStack.
/// </summary>

namespace HomeTask
{
    /// <summary>
    /// ArrayStack.
    /// </summary>
    /// <typeparam name="T">My.</typeparam>
    public class Stack<T>
    {
        private readonly int _size = 10;
        private T[] _items;
        private int _current = -1;
        public int Count => _items.Length;

#pragma warning disable SA1201 // Elements should appear in the correct order
        public Stack(int size = 10)
#pragma warning restore SA1201 // Elements should appear in the correct order
        {
            _items = new T[size];
            _size = size;
        }

        public Stack(T data, int size = 10)
            : this(size)
        {
            _items[_current] = data;
            _current = 1;
        }

        public void Push(T data)
        {
            if (_current < _size - 1)
            {
                _current++;
                _items[_current] = data;
            }
            else
            {
                throw new StackOverflowException("Стек переполнен!");
            }
        }

        public T Pop()
        {
            if (_current >= 0)
            {
                var item = _items[_current];
                _items[_current] = default(T);
                _current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст!");
            }
        }

        public T Peek()
        {
            if (_current >= 0)
            {
                return _items[_current];
            }
            else
            {
                throw new NullReferenceException("Стек пуст!");
            }
        }
    }
}
