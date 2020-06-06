using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    /// <summary>
    /// Внутренняя структура хэш-таблицы. хранящая все данные и реализующая стратегии разрешения коллизий.
    /// </summary>
    /// <typeparam name="K"> Тип ключая хранилища. </typeparam>
    /// <typeparam name="V"> Тип данного (значения) хранилища. </typeparam>
    [Serializable]
    public abstract class Storage<K, V> where V : IKeyedElement<K>
    {
        /// <summary>
        /// Структура для хранения количества элементов внутреннего хранилища
        /// и динамического обращения к нему объектов, не имеющих доступ к самому хранилищу.
        /// </summary>
        private SizeContainer _size;

        /// <summary>
        /// Основной конструктор, инициализирующий обязательные элементы хранилища.
        /// </summary>
        /// <param name="size"> Изначальный размер внутренней структуры. </param>
        public Storage(int size)
        {
            _size = new SizeContainer(size);
        }

        /// <summary>
        /// Публичный геттер для контейнера, содержащего размер хранилища.
        /// </summary>
        /// <returns></returns>
        public SizeContainer SizeContainer()
        {
            return _size;
        }
        
        /// <summary>
        /// Геттер, возвращающий размер хранилища в числовом представлении.
        /// </summary>
        /// <returns> Числовое представление размера хранилища. </returns>
        public abstract int GetSize();

        /// <summary>
        /// Добавляет элемент в хранилище.
        /// </summary>
        /// <param name="index"> Индекс в хранилище, опеделенный хэш функцией таблицы. </param>
        /// <param name="element"> Добавляемый элемент. </param>
        public abstract void Add(int index, V element);

        /// <summary>
        /// Удаляет элемент из хранилища.
        /// </summary>
        /// <param name="index"> Индекс в хранилище, опеделенный хэш функцией таблицы. </param>
        /// <param name="element"> Удаляемый элемент. </param>
        /// <returns> Возвращает true если элемент успешно удален и false в остальных случаях. </returns>
        public abstract bool Remove(int index, V element);

        /// <summary>
        /// Возвращает элементы хранилища в виде массива.
        /// </summary>
        /// <returns> Массив, состоящий из элементов хранилища. </returns>
        public abstract V[] ToArray();

        /// <summary>
        /// Поиск указанного в запросе элемента, по указанному индексу хранилища,
        /// учитывая стратегии разрешения коллизий. 
        /// </summary>
        /// <param name="index"> Индекс, по которому в хранилище должен располагаться данный объект,
        /// если он в нем присутствует. Определяется хэш-функцией. </param>
        /// <param name="keyedQuery"> Поисковый запрос, содержащий искомый объект. </param>
        public abstract void Find(int index, KeyedSearchQuery<K, V> keyedQuery);
    }
}