using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public abstract class Storage<K, V> where V : IKeyedElement<K>
    {
        private SizeContainer _size;

        public Storage(int size)
        {
            _size = new SizeContainer(size);
        }

        public SizeContainer SizeContainer()
        {
            return _size;
        }

        public abstract int GetSize();

        public abstract void Add(int index, V element);

        public abstract bool Remove(int index, V element);

        public abstract V[] ToArray();

        public abstract string Find(int index, V element);
    }
}