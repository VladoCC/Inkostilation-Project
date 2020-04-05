using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class ModFunction: IHashFunction<int>
    {
        private int _size;

        public ModFunction(int size)
        {
            _size = size;
        }

        public int Hash(int key)
        {
            return key % _size;
        }
    }
}