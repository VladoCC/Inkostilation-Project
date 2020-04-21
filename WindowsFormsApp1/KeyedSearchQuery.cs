using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class KeyedSearchQuery<K, V>: SearchQuery<V> where V: IKeyedElement<K>
    {
        public KeyedSearchQuery(V request) : base(request)
        {
        }

        public K SearchKey()
        {
            return _request.GetKey();
        }
    }
}