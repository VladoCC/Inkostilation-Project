using WinFormsApp1;

namespace WindowsFormsApp1
{
    public class OddFunction: IHashFunction<int>
    {
        private int _size;

        public OddFunction(int size)
        {
            _size = size;
        }

        public int Hash(int key)
        {
            return key % (_size - 1) / 2 * 2 + 1;
        }
    }
}