using WinFormsApp1;

namespace WindowsFormsApp1
{
    public interface ISorter<T> where T: IElement
    { 
        void Sort(T[] array);
    }
}