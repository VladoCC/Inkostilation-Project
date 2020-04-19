using WinFormsApp1;

namespace WindowsFormsApp1
{
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