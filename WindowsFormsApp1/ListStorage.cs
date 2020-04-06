using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Drawing;

namespace WinFormsApp1
{
    public class ListStorage<K, V> : Storage<K, V> where V : IKeyedElement<K>
    {
        private Position<V>[] array;

        public ListStorage(): base(10)
        {
            array = new Position<V>[10];
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (var v in array)
            {
                if (v != null)
                {
                    size += v.Size();
                }
            }
            return size;
        }

        public override void Add(int index, V element)
        {
            if (array[index] == null)
            {
                array[index] = new Position<V>(element);
            }
            else
            {
                array[index].Add(element);
            }
        }

        public override bool Remove(int index, V element)
        {
            if (array[index] == null)
            {
                return false;
            }
            if (array[index].Next == null)
            {
                if (array[index].Element.Compare(element) == 0)
                {
                    array[index] = null;
                    return true;
                }
                return false;
            }
            return array[index].Remove(element);
        }

        public override V[] ToArray()
        {
            V[] arr = new V[GetSize()];
            int pos = 0;
            foreach (var v in array)
            {
                if (v != null)
                {
                    pos = v.FillArray(arr, pos);
                }
            }
            return arr;
        }

        private class Position<T> where T : IElement
        {
            private Position<T> _next;
            private T _element;

            public T Element => _element;

            public Position<T> Next => _next;

            public Position(T element)
            {
                _element = element;
            }

            public int Size()
            {
                if (_next == null)
                {
                    return 1;
                }
                return _next.Size() + 1;
            }

            public void Add(T element)
            {
                if (_next != null)
                {
                    _next.Add(element);
                }
                else
                {
                    _next = new Position<T>(element);
                }
            }

            public bool Remove(T element)
            {
                if (_next == null)
                {
                    return false;
                }
                if (_next.Element.Compare(element) == 0)
                {
                    if (_next.Next != null)
                    {
                        _next = _next.Next;
                    }
                    return true;
                }

                return _next.Remove(element);
            }

            public int FillArray(T[] array, int pos)
            {
                array[pos] = _element;
                if (_next != null)
                {
                    return _next.FillArray(array, pos + 1);
                }
                return pos = 1;
            }
        }
    }
}
