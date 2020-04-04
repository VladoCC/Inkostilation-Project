using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DoubleHashStorage<K, V> : IStorage<K, V> where V : IKeyedElement<K>
    {
        private IHashFunction<K> _function;
        private V[] _array = new V[16];
        private bool[] _deleted = new bool[16];
        private int _size = 0;

        public DoubleHashStorage(IHashFunction<K> function)
        {
            _function = function;
            for (int i = 0; i < 16; i++)
            {
                _deleted[i] = false;
            }
        }

        public int Size()
        {
            return _size;
        }

        public void Add(int index, V element)
        {
            bool found = false;
            for (int i = 0; i < _array.Length; i++)
            {
                int realIndex = (index + i * _function.Hash(element.GetKey())) % _array.Length;
                if (_array[realIndex] == null || _deleted[realIndex])
                {
                    _array[realIndex] = element;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Inflate();
                Add(index, element);
            }
            else
            {
                _size++;
            }
        }

        private void Inflate()
        {
            V[] newArray = new V[_array.Length * 2];
            bool[] newDeleted = new bool[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
                newDeleted[i] = _deleted[i];
            }
            _array = newArray;
            _deleted = newDeleted;
        }

        public bool Remove(int index, V element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int realIndex = (index + i * _function.Hash(element.GetKey())) % _array.Length;
                if (_array[realIndex].Compare(element) == 0 && !_deleted[realIndex])
                {
                    _deleted[realIndex] = true;
                    _size--;

                    return true;
                }
                if (_array[realIndex] == null)
                {
                    return false;
                }
            }
            return false;
        }

        public V[] ToArray()
        {
            V[] arr = new V[_size];
            int pos = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] != null && !_deleted[i])
                {
                    arr[pos] = _array[i];
                    pos++;
                }
            }
            return arr;
        }
    }
}
