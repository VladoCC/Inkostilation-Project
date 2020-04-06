using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public abstract class HashFunction<T>
    {
        private SizeContainer _size;

        public void SetSize(SizeContainer size)
        {
            _size = size;
        }

        internal int GetStorageSize()
        {
            return _size.Size;
        }
        
        public abstract int Hash(T key);
    }
}
