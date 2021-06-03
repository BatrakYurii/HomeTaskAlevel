using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master
{
    public class HashNode<K, T> where K : IComparable<K> where T : IComparable<T>
    {
        private K _key;
        private T _value;
        private HashNode<K, T> _next;
        private bool _isDeleted;

        public K Key => _key;

        public T Value
        {
            get => _value;
            set => _value = value;
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public HashNode<K, T> Next
        {
            set => _next = value;
            get => _next;
        }

        public HashNode(K key, T value)
        {
            _key = key;
            _value = value;
        }
    }
}
