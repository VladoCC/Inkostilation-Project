using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    [Serializable]
    public class HashMap<K, V> : ICollection<V> where V : IKeyedElement<K>
    {
        /// <summary>
        /// Хэш-функция, используемая в данной таблице.
        /// </summary>
        private HashFunction<K> _function;
        /// <summary>
        /// Хранилище, используемое в данной таблице для хранения данных.
        /// </summary>
        private Storage<K, V> _storage;

        /// <summary>
        /// Конструктор, инициализирующий пустую хэш-таблицу.
        /// </summary>
        /// <param name="function"> Используемая хэш-функция. </param>
        /// <param name="storage"> Внутренее хранилище. </param>
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

        public void Find(SearchQuery<V> query)
        {
            KeyedSearchQuery<K, V> keyedQuery = (KeyedSearchQuery<K, V>) query;
            int index = _function.Hash(keyedQuery.SearchKey()); 
            _storage.Find(index, keyedQuery);
        }

        /// <summary>
        /// Публичный геттер для хэш-функии.
        /// </summary>
        public HashFunction<K> Function => _function;
    }
}
