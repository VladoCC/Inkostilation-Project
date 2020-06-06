using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Интерфейс, описывающий сортировщик элементов типа Т.
    /// </summary>
    /// <typeparam name="T"> Тип сортируемых данных, наследуемая от IElement. </typeparam>
    public interface ISorter<T> where T: IElement
    { 
        /// <summary>
        /// Метод, совершающий сортировку.
        /// </summary>
        /// <param name="array"> Сортируемый массив. </param>
        void Sort(T[] array);
    }
}