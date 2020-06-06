using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Отчет о данных, соответствующих запросу.
    /// Ищет все данные, соответсвующие запросу и сортирует их используя ISorter.
    /// </summary>
    /// <typeparam name="K"> Тип данного запроса. </typeparam>
    /// <typeparam name="V"> Тип данных для поиска. </typeparam>
    public class Report<K, V> where K: IElement where V: IElement
    {
        /// <summary>
        /// Данное, предоставленное в качестве запроса.
        /// </summary>
        private K _key;
        /// <summary>
        /// Первый элемент списка результирующих данных.
        /// </summary>
        private Container<V> _root;
        /// <summary>
        /// Объект-сортировщик, применяемый над данными.
        /// </summary>
        private ISorter<V> _sorter;

        /// <summary>
        /// Конструктор, позволяющий инициализировать запрос на создание отчета.
        /// </summary>
        /// <param name="key"> Данное-запрос, в соответствии с которым создается отчет. </param>
        /// <param name="sorter"> Сортировщик результирующих данных. </param>
        public Report(K key, ISorter<V> sorter)
        {
            _key = key;
            _sorter = sorter;
        }

        /// <summary>
        /// Публичный геттер для предоставленного в запросе данного.
        /// </summary>
        public K Key => _key;

        /// <summary>
        /// Добавляет элемент в отчет.
        /// </summary>
        /// <param name="element"> Добавляемый элемент. </param>
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

        /// <summary>
        /// Предоставляет данные, хранящиеся в отчете в виде массива.
        /// </summary>
        /// <returns> Массив данных, хранящихся в отчете. </returns>
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

        /// <summary>
        /// Возвращает количество элементов в отчете.
        /// </summary>
        /// <returns> Количество элементов в отчете. </returns>
        public int DataSize()
        {
            if (_root == null)
            {
                return 0;
            }

            return _root.Size();
        }
        
        /// <summary>
        /// Котейнер, являющийся первым элементом списка и предоставляющий методы работы со списком.
        /// </summary>
        /// <typeparam name="T"> Тип данных, хранящихся в списке. </typeparam>
        class Container<T> where T: IElement
        {
            /// <summary>
            /// Данное, хранящееся в контейнере.
            /// </summary>
            private T _element;
            /// <summary>
            /// Следующий элемент списка.
            /// </summary>
            private Container<T> _next;
            
            /// <summary>
            /// Конструктор для контейнера, хранящего определенный элемент.
            /// </summary>
            /// <param name="element"> Элемент, хранящийся в контейнере. </param>
            public Container(T element)
            {
                _element = element;
            }

            /// <summary>
            /// Добавляет контейнер в конец списка.
            /// </summary>
            /// <param name="container"> Добавляемый контейнер. </param>
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

            /// <summary>
            /// Возвращает количество элементов в списке.
            /// </summary>
            /// <returns> Количество элементов в списке. </returns>
            public int Size()
            {
                if (_next == null)
                {
                    return 1;
                }

                return _next.Size() + 1;
            }

            /// <summary>
            /// Заполняет массив, начиная с указанной позиции, элементами данного списка.
            /// </summary>
            /// <param name="arr"> Массив для заполнения. </param>
            /// <param name="pos"> Позиция для начала заполнения. </param>
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