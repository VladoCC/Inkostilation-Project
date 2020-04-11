using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable]
    public class DoubleHashStorage<K, V> : Storage<K, V> where V : IKeyedElement<K>
    {
        private HashFunction<K> _function;
        private V[] _array = new V[16];
        private bool[] _deleted = new bool[16];
        private int _size = 0;

        public DoubleHashStorage(HashFunction<K> function): base(16)
        {
            _function = function;
            _function.SetSize(base.SizeContainer());
            for (int i = 0; i < 16; i++)
            {
                _deleted[i] = false;
            }
        }

        public override int GetSize()
        {
            return _size;
        }

        public override void Add(int index, V element)
        {
            bool found = false;
            for (int i = 0; i < _array.Length; i++)
            {
                int realIndex = (index + i * _function.Hash(element.GetKey())) % _array.Length;
                if (_array[realIndex] == null || _deleted[realIndex])
                {
                    _array[realIndex] = element;
                    _deleted[realIndex] = false;
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
            bool[] newDeleted = new bool[_deleted.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
                newDeleted[i] = _deleted[i];
            }
            _array = newArray;
            _deleted = newDeleted;
            base.SizeContainer().Size = newArray.Length;
        }

        public override bool Remove(int index, V element)
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

        public override V[] ToArray()
        {
            if (GetSize() > 0)
            {
                V[] arr = new V[GetSize()];
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

            return null;
        }

        public override string Find(int index, V element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int realIndex = (index + i * _function.Hash(element.GetKey())) % _array.Length;
                if (_array[realIndex].Compare(element) == 0 && !_deleted[realIndex])
                {
                    return "Checks: " + (i + 1) + "\n" + _array[realIndex].ToString();
                }
                if (_array[realIndex] == null)
                {
                    return "Not found";
                }
            }
            return "Not found";
        }
    }
}
