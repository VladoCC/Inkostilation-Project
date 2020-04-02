namespace WinFormsApp1
{
    public interface IKeyedElement<K>: IElement
    {
        K GetKey();
    }
}