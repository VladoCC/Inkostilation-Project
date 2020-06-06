using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Реализация сортировки для элементов типа Т. Использует алгоритм сортировки пузырьком.
    /// Наследуется от ISorter.
    /// </summary>
    /// <typeparam name="T"> Тип сортируемых данных, наследуемый от IElement. </typeparam>
    public class QuickLastSorter<T>: ISorter<T> where T: IElement
    {
        public void Sort(T[] array)
        {
            Inner(array, 0, array.Length - 1);
        }
        
        /// <summary>
        /// Внутренняя рекурсивная функция, меняющая два элемента местам, располагая их в порядке возрастания,
        /// а затем вызывает саму себя, для двух подмассивов.
        /// </summary>
        /// <param name="mas"> Сортируемый массив. </param>
        /// <param name="first"> Левая граница сортируемой части. </param>
        /// <param name="last"> Правая граница сортируемой части. </param>
        private void Inner(T[] mas, int first, int last)
        {
            T mid;
            int l = first, r = last; 
            mid = mas[r]; 
            do
            {
                while (mas[l].Compare(mid) < 0)
                {
                    l++; 
                }
                while (mas[r].Compare(mid) > 0)
                {
                    r--;
                }
                if (l <= r) 
                {
                    T tmp = mas[l];
                    mas[l] = mas[r];
                    mas[r] = tmp;
                    l++;
                    r--;
                }
            } 
            while (l<=r); 
            if (first<r) Inner(mas, first, r);
            if (l<last) Inner(mas, l, last); 
        }
    }
}