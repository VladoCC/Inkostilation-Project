namespace WinFormsApp1
{
    public interface IStorage<K, V> where V: IKeyedElement<K>
    {
        int Size();
            
        void Add(int index, V element);

        bool Remove(int index, V element);

        V[] ToArray();
    }
}