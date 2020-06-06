using System.Collections;
using System.Collections.Generic;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Реализация сортировки для элементов типа Т. Использует алгоритм быстрой сортировки.
    /// Основан на стековой реализации алгоритма.
    /// Наследуется от ISorter.
    /// </summary>
    /// <typeparam name="T"> Тип сортируемых данных, наследуемый от IElement. </typeparam>
    public class QuickStackSorter<T>: ISorter<T> where T: IElement
    {
        public void Sort(T[] array)
        {
            int size = array.Length;
            Stack<int> s = new Stack<int>();
            s.Push(0);
            s.Push(size - 1);
            int l, r;
            while (true) {
                
                if (s.Count == 0) {
                    break;
                }
                r = s.Pop();
                l = s.Pop();
                if (r <= l) {
                    continue;
                }
                int i = Partition(array, l, r);
                s.Push(i + 1);
                s.Push(r);
                s.Push(l);
                s.Push(i);
            }
        }
        
        /// <summary>
        /// Функция, определяющая индекс элемента, разделяющего массив на две части.
        /// Меняет местами два элемента, таким образом, что они казываются в порядке возрастания.
        /// </summary>
        /// <param name="a"> Сортируемый массив. </param>
        /// <param name="l"> Левая граница разделяемой части. </param>
        /// <param name="r"> Правая граница разделяемой части.  </param>
        /// <returns> Индекс элемента, который делит массив  на два подмассива для следующего шага сортировки. </returns>
        private int Partition(T[] a, int l, int r) {
            int pos = (l + r) / 2;
            T v = a[pos];
            int i = l;
            int j = r;
            while (i <= j) {
                while (a[i].Compare(v) < 0) {
                    i++;
                }
                while (a[j].Compare(v) > 0) {
                    j--;
                }
                if (i >= j) {
                    break;
                }
                T tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
                i++;
                j--;
            }
            return j;
        }
    }
}