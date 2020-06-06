using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    /// <summary>
    /// Хэш-функция, предоставляющая индекс, соответствующий поступившему на вход данному.
    /// </summary>
    /// <typeparam name="T"> Тип данных для хэширования. </typeparam>
    [Serializable]
    public abstract class HashFunction<T>
    {
        /// <summary>
        /// Структура для хранения количества элементов внутреннего хранилища
        /// и динамического обращения к нему объектов, не имеющих доступ к самому хранилищу.
        /// </summary>
        private SizeContainer _size;

        /// <summary>
        /// Публичный сеттер, позволяющий заменить размер хранилища на новый.
        /// </summary>
        /// <param name="size"> Новый контейнер, содержащий размер. </param>
        public void SetSize(SizeContainer size)
        {
            _size = size;
        }

        /// <summary>
        /// Возвразает числовое представление размера.
        /// </summary>
        /// <returns> Числовое представление размера. </returns>
        internal int GetStorageSize()
        {
            return _size.Size;
        }
        
        /// <summary>
        /// Преобразует хэшируемое данное в индекс. 
        /// </summary>
        /// <param name="key"> Данное для хэширования. </param>
        /// <returns> Индекс, полученные хэшированием данных. </returns>
        public abstract int Hash(T key);
    }
}
