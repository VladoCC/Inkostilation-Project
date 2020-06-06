using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    /// <summary>
    /// Интерфейс, описывающий методы коллекции данных.
    /// </summary>
    /// <typeparam name="T"> Тип хранимых данных. </typeparam>
    public interface ICollection<T> where T : IElement
    {
        /// <summary>
        /// Преобразует коллекцию в массив элементов.
        /// </summary>
        /// <returns> Массив элементов. </returns>
        T[] ToArray();
        
        /// <summary>
        /// Возвращает размер коллекции.
        /// </summary>
        /// <returns> Размер коллекции. </returns>
        int Size();
        
        /// <summary>
        /// Добавляет элемент в коллекцию.
        /// </summary>
        /// <param name="element"> Добавляемый элемент. </param>
        void Add(T element);

        /// <summary>
        /// Удаляет элемент из коллекии.
        /// </summary>
        /// <param name="element"> Удаляемый элемент. </param>
        /// <returns> Возвращает true, если элемент найден и удален,
        /// иначе false. </returns>
        bool Remove(T element);

        /// <summary>
        /// Поиск указанного в запросе элемента, по указанному индексу хранилища,
        /// учитывая стратегии разрешения коллизий. 
        /// </summary>
        /// <param name="query"> Поисковый запрос, содержащий искомый объект. </param>
        void Find(SearchQuery<T> query);
    }
}
