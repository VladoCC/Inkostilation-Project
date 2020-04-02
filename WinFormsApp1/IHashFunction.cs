namespace WinFormsApp1
{
    public interface IHashFunction<T>
    {
        int Hash(T key);

        int Size();
    }
}