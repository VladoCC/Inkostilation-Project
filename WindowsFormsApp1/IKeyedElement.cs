using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Интерфейс, описывающий элемент, обладающий ключом, используемым для генерации хэш-функции.
    /// </summary>
    /// <typeparam name="K">Тип ключа.</typeparam>
    public interface IKeyedElement<K> : IElement
    {
        /// <summary>
        /// Метод, возвращающий ключ данного элемента.
        /// </summary>
        /// <returns> Ключ типа К. </returns>
        K GetKey();
    }
}
