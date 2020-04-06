using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class HashMap<K, V> : ICollection<V> where V : IKeyedElement<K>
    {

        private HashFunction<K> _function;
        private Storage<K, V> _storage;

        public HashMap(HashFunction<K> function, Storage<K, V> storage)
        {
            _function = function;
            _storage = storage;
            _function.SetSize(storage.SizeContainer());
        }

        public V[] ToArray()
        {
            return _storage.ToArray();
        }

        public int Size()
        {
            return _storage.GetSize();
        }

        public void Add(V element)
        {
            int index = _function.Hash(element.GetKey());
            _storage.Add(index, element);
        }

        public bool Remove(V element)
        {
            int index = _function.Hash(element.GetKey());
            return _storage.Remove(index, element);
        }

        public string Find(V element)
        {
            int index = _function.Hash(element.GetKey());
            return _storage.Find(index, element);
        }
    }
}
