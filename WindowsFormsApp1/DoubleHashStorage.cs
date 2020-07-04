using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    [Serializable]
    public class DoubleHashStorage<K, V> : Storage<K, V> where V : IKeyedElement<K>
    {
        /// <summary>
        /// Основная хэш-функция данного хранилища.
        /// </summary>
        private HashFunction<K> _mainFunction;
        /// <summary>
        /// Внешняя функция, предоставленная хэш-таблицей.
        /// </summary>
        private HashFunction<K> _outsideFunction;
        /// <summary>
        /// Массив элементов, содержащихся в этом хранилище.
        /// </summary>
        private V[] _array = new V[16];
        /// <summary>
        /// Массив указателей на то, был ли удален элемент из данной ячейки. 
        /// </summary>
        private bool[] _deleted = new bool[16];
        /// <summary>
        /// Количество элементов, содержащихся в хранилище.
        /// </summary>
        private int _size = 0;

        /// <summary>
        /// Конструктор, получающий на вход хуш-функции, предоставляющий им информацию о размере,
        /// а также заполняет массив _deleted.
        /// </summary>
        /// <param name="mainFunction"> Основная хэш-функция. </param>
        /// <param name="outsideFunction"> Внешняя функция, предоставленная хэш-таблицей. </param>
        public DoubleHashStorage(HashFunction<K> mainFunction, HashFunction<K> outsideFunction): base(16)
        {
            _mainFunction = mainFunction;
            _mainFunction.SetSize(base.SizeContainer());
            _outsideFunction = outsideFunction;
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
                int realIndex = (index + i * _mainFunction.Hash(element.GetKey())) % _array.Length;
                if (_array[realIndex] == null || _deleted[realIndex])
                {
                    _array[realIndex] = element;
                    _deleted[realIndex] = false;
                    found = true;
                    break;
                }
            }

            _size++;
            
            if (_size > _array.Length / 4 * 3)
            {
                Inflate();
            }
        }

        /// <summary>
        /// Функция, позволяющая увеличить размер хранилища в два раза.
        /// Также обновляет положение всех элементов, в соответствии с новыми значениями хэш-функций.
        /// </summary>
        private void Inflate()
        {
            V[] newArray = new V[_array.Length * 2];
            bool[] newDeleted = new bool[_deleted.Length * 2];
            V[] arr = ToArray();
            for (int i = 0; i < newDeleted.Length; i++)
            {
                newDeleted[i] = false;
            }
            _array = newArray;
            _deleted = newDeleted;
            base.SizeContainer().Size = newArray.Length;
            _size = 0;
            if (arr.Length > 0)
            {
                foreach (V element in arr)
                {
                    Add(_outsideFunction.Hash(element.GetKey()), element);
                }   
            }
        }
     
        public override bool Remove(int index, V element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int realIndex = (index + i * _mainFunction.Hash(element.GetKey())) % _array.Length;
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

        public override void Find(int index, KeyedSearchQuery<K, V> keyedQuery)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int realIndex = (index + i * _mainFunction.Hash(keyedQuery.SearchKey())) % _array.Length;
                if (_array[realIndex] == null)
                {
                    keyedQuery.Count();
                    return;
                }
                if (keyedQuery.Check(_array[realIndex]) == 0 && !_deleted[realIndex])
                {
                    return;
                }
            }
        }
    }
}
