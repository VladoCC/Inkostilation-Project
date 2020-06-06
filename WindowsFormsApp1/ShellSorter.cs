using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Реализация сортировки для элементов типа Т. Использует алгоритм сортировки Шелла с расстоянием Шелла.
    /// Наследуется от ISorter.
    /// </summary>
    /// <typeparam name="T"> Тип сортируемых данных, наследуемый от IElement. </typeparam>
    public class ShellSorter<T>: ISorter<T> where T: IElement
    {
        public void Sort(T[] array)
        {
            int step, i, j, size;
            size = array.Length;
            T tmp;
            for (step = size / 2; step > 0; step /= 2) {
                for (i = step; i < size; i++) {
                    for (j = i - step; j >= 0; j -= step) {
                        if (array[j].Compare(array[j + step]) < 0) {
                            break;
                        }
                        tmp = array[j];
                        array[j] = array[j + step];
                        array[j + step] = tmp;
                    }
                }
            }
        }
    }
}