using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class Report<K, V> where K: IElement where V: IElement
    {
        private K _key;
        private Container<V> _root;
        private ISorter<V> _sorter;

        public Report(K key, ISorter<V> sorter)
        {
            _key = key;
            _sorter = sorter;
        }

        public K Key => _key;

        public void Add(V element)
        {
            if (_root == null)
            {
                _root = new Container<V>(element);
            }
            else
            {
                _root.Add(new Container<V>(element));
            }
        }

        public V[] Data ()
        {
            if (_root == null)
            {
                return null;
            }
            V[] arr = new V[_root.Size()];
            _root.Fill(arr, 0);
            _sorter.Sort(arr);
            return arr;
        }

        public int DataSize()
        {
            if (_root == null)
            {
                return 0;
            }

            return _root.Size();
        }
        
        class Container<T> where T: IElement
        {
            private T _element;
            private Container<T> _next;
            
            public Container(T element)
            {
                _element = element;
            }

            public void Add(Container<T> container)
            {
                if (_next == null)
                {
                    _next = container;
                }
                else
                {
                    _next.Add(container);
                }
            }

            public int Size()
            {
                if (_next == null)
                {
                    return 1;
                }

                return _next.Size() + 1;
            }

            public void Fill(T[] arr, int pos)
            {
                arr[pos] = _element;
                if (_next != null)
                {
                    _next.Fill(arr, pos + 1);
                }
            }
        }
    }
}