using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Реализация сортировки для элементов типа Т. Использует алгоритм сортировки пузырьком.
    /// Наследуется от ISorter.
    /// </summary>
    /// <typeparam name="T"> Тип сортируемых данных, наследуемый от IElement. </typeparam>
    public class BubbleSorter<T>: ISorter<T> where T: IElement
    {
        public void Sort(T[] array)
        {
            int size, k; 
            size = array.Length;
            while (size > 1)
            {
                k = 0; 
                for (int i = 1; i < size; i++) 
                {
                    if (array[i].Compare(array[i - 1]) < 0)
                    {
                        T temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                    k = i; 
                }
                size = k; 
            }
        }
    }
}