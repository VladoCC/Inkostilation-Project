namespace WinFormsApp1
{
    public class HashMap<K, V>: ICollection<V> where V: IKeyedElement<K>
    {
        
        private IHashFunction<K> _function;
        private IStorage<K, V> _storage;
        
        public HashMap(IHashFunction<K> function, IStorage<K, V> storage)
        {
            _function = function;
            _storage = storage;
        }

        public V[] ToArray()
        {
            return _storage.ToArray();
        }

        public int Size()
        {
            return _storage.Size();
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
    }
}