using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Drawing;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    [Serializable]
    public class ListStorage<K, V> : Storage<K, V> where V : IKeyedElement<K>
    {
        /// <summary>
        /// Массив списков, представляющий структуру хранения данных.
        /// </summary>
        private Position<V>[] array;

        /// <summary>
        /// Инициализирует массив объектов Position размером в 10 элементов.
        /// Также вызывает конструктор базового класса Storage с тем же размером.
        /// </summary>
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
            if (array[index].Element.Compare(element) == 0)
            {
                array[index] = array[index].Next;
                return true;
            }
            
            return array[index].Remove(element);
        }

        public override V[] ToArray()
        {
            if (GetSize() > 0)
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

            return null;
        }
        
        public override void Find(int index, KeyedSearchQuery<K, V> keyedQuery)
        {
            Position<V> position = array[index];
            Find(position, keyedQuery);
        }

        /// <summary>
        /// Внутренний рекурсивный метод поиска. Проходит по списку Position, находящихся после этой.
        /// Останавливается при обнаружении нужного элемента или по окончании списка.
        /// </summary>
        /// <param name="position"> Позиция, в которой ведется поиск. </param>
        /// <param name="keyedQuery"> Поисковый запрос, содержащий искомый объект. </param>
        private void Find(Position<V> position, KeyedSearchQuery<K, V> keyedQuery)
        {
            if (position == null)
            {
                keyedQuery.Count();
                return;
            }
            
            if (keyedQuery.Check(position.Element) == 0)
            {
                return;
            }

            Find(position.Next, keyedQuery);
        }

        
        /// <summary>
        /// Структура, представляющая собой элемент односвязного списка,
        /// используемая для разрешения коллизий в ListStorage.
        /// </summary>
        /// <typeparam name="T"> Тип данных, хранимых в списке. </typeparam>
        [Serializable]
        private class Position<T> where T : IElement
        {
            /// <summary>
            /// Следующий элемент списка.
            /// </summary>
            private Position<T> _next;
            /// <summary>
            /// Данное, содержащееся в этой позиции.
            /// </summary>
            private T _element;

            /// <summary>
            /// Публичный геттер для элемента, находящегося в позиции.
            /// </summary>
            public T Element => _element;

            /// <summary>
            /// Публичный геттер для следующей позиции.
            /// </summary>
            public Position<T> Next => _next;

            /// <summary>
            /// Публичный конструктор, позволяющий создать новую позицию.
            /// </summary>
            /// <param name="element"> Элемент, содержащийся в этой позиции. </param>
            public Position(T element)
            {
                _element = element;
            }

            /// <summary>
            /// Возвращает длину списка, начинающегося с этой позиции. Работает рекурсивно.
            /// </summary>
            /// <returns> Длина списка, начинающегося с этой позиции. </returns>
            public int Size()
            {
                if (_next == null)
                {
                    return 1;
                }
                return _next.Size() + 1;
            }

            /// <summary>
            /// Добавляет элемент в список.
            /// </summary>
            /// <param name="element"> Добавляемый элемент. </param>
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

            /// <summary>
            /// Удаляет элемент из списка.
            /// </summary>
            /// <param name="element"> Удаляемый элемент. </param>
            /// <returns> Возвращает true, если элемент найден и удален,
            /// иначе false. </returns>
            public bool Remove(T element)
            {
                if (_next == null)
                {
                    return false;
                }
                if (_next.Element.Compare(element) == 0)
                {
                    _next = _next.Next;
                    return true;
                }

                return _next.Remove(element);
            }

            /// <summary>
            /// Заполняет массив, начиная с указанной позиции, элементами данного списка.
            /// </summary>
            /// <param name="array"> Массив для заполнения. </param>
            /// <param name="pos"> Позиция для начала заполнения. </param>
            /// <returns> Позицию, на которой было завершено заполнение. </returns>
            public int FillArray(T[] array, int pos)
            {
                array[pos++] = _element;
                if (_next != null)
                {
                    return _next.FillArray(array, pos);
                }
                return pos;
            }
        }
    }
}
