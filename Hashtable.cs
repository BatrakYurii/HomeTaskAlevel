using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master
{
    public class HashTable<K, T> where K : IComparable<K> where T : IComparable<T>
    {
        private const int DefaultSize = 200;
        private HashNode<K, T>[] _buckets;
        private int _count;
        public int Count => _count;
        public HashTable(int size)
        {
            if (size < 0)
                throw new ArgumentException("Размер не может равнятся 0");

            if (size == 0)
                size = 1;

            _buckets = new HashNode<K, T>[size];
        }
        public HashTable() : this(DefaultSize)
        {

        }

        public bool ContainsKey(K key)
        {
            var index = Hash(key);
            var item = _buckets[index];

            while (item != null)
            {
                if (item.Key.CompareTo(key) == 0)
                    return true;
                item = item.Next;
            }
            throw new NotImplementedException();
        }

        public bool ContainsValue(T value)
        {
            foreach (var el in _buckets)
            {
                var item = el;
                while (item != null)
                {
                    if (item.Value.CompareTo(value) == 0)
                    {
                        return true;
                    }
                    item = item.Next;
                }
            }
            return false;
        }

        public T Find(K key)
        {
            foreach (var el in _buckets)
            {
                var item = el;
                while (item != null)
                {
                    if (item.Key.CompareTo(key) == 0)
                    {
                        return item.Value;
                    }
                    item = item.Next;
                }
            }
            return default;
        }

        public void Add(K key, T value)
        {
            var index = Hash(key);
            var item = _buckets[index];
            while (item != null)
            {
                if (key.CompareTo(item.Key) == 0)
                {
                    item.Value = value;
                    return;
                }
                item = item.Next;
            }

            var newitem = new HashNode<K, T>(key, value)
            {
                Next = _buckets[index]
            };
            _buckets[index] = newitem;
            _count++;
        }

        public void Remove(K key)
        {
            var index = Hash(key);
            var item = _buckets[index];
            while (item != null)
            {
                if (item.Key.CompareTo(key) == 0)
                {
                    _buckets[index] = item.Next;
                    break;
                }
            }
            item = item.Next;
        }

        private int Hash(K key)
        {
            return key == null ? 0 : Math.Abs(key.GetHashCode() % _buckets.Length);
        }
    }
}
