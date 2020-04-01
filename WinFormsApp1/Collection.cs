namespace WinFormsApp1
{
    public interface Collection<T> where T: Element
    {
        T[] ToArray();

        int Size();
    }
}