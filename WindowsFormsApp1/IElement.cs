using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Интерфейс, описывающий данное, хранящееся в базе.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Метод, производящий сравнение двух элементов, наследуемых от IElement.
        /// </summary>
        /// <param name="elem"> Элемент, с которым производится сравнение. </param>
        /// <returns> Отрицательное число, если этот элемент меньше, чем поступающий на вход.
        /// Ноль, если элементы равны. Положительное число, если этот элемент больше,
        /// чем поступающий на вход. </returns>
        int Compare(IElement elem);
    }
}
