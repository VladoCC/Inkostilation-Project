namespace WinFormsApp1
{
    public interface IElement
    {
        int Compare(IElement elem);

        string ToString();
    }
}