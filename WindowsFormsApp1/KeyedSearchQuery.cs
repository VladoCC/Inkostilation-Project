using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// запрос поиска для элемента, обладающего ключом.
    /// </summary>
    /// <typeparam name="K"> Тип ключа данного. </typeparam>
    /// <typeparam name="V"> Тип искомого данного. </typeparam>
    public class KeyedSearchQuery<K, V>: SearchQuery<V> where V: IKeyedElement<K>
    {
        /// <summary>
        /// Конструктор, позволяющий создать запрос с ключом.
        /// </summary>
        /// <param name="request"> Искомый элемент. </param>
        public KeyedSearchQuery(V request) : base(request)
        {
        }

        /// <summary>
        /// Возвращает ключ искомого элемента.
        /// </summary>
        /// <returns> Ключ искомого элемента. </returns>
        public K SearchKey()
        {
            return _request.GetKey();
        }
    }
}