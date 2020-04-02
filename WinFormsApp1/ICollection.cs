namespace WinFormsApp1
{
    public interface ICollection<T> where T: IElement
    {
        T[] ToArray();

        int Size();

        public void Add(T element);
        
        bool Remove(T element);
    }
}