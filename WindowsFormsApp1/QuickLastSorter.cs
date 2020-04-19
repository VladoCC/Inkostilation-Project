using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class QuickLastSorter<T>: ISorter<T> where T: IElement
    {
        public void Sort(T[] array)
        {
            Inner(array, 0, array.Length - 1);
        }

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