using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public class SizeContainer
    {
        private int _size;

        public SizeContainer(int size)
        {
            _size = size;
        }

        public int Size
        {
            get => _size;
            set => _size = value;
        }
    }
}