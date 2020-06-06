using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    /// <summary>
    /// Коллекция вида бинарное дерево.
    /// </summary>
    /// <typeparam name="T"> Тип данных, хранимых в бинарном дереве. </typeparam>
    [Serializable]
    public class Tree<T> : ICollection<T> where T : IElement
    {
        /// <summary>
        /// Корень дерева.
        /// </summary>
        private Position<T> _root;
        /// <summary>
        /// Размер дерева.
        /// </summary>
        private int _size = 0;

        public T[] ToArray()
        {
            if (Size() > 0)
            {
                T[] arr = new T[_size];
                FillArray(arr, 0, _root);
                return arr;
            }

            return null;
        }

        private int FillArray(T[] arr, int index, Position<T> pos)
        {
            arr[index] = pos.Element;
            if (pos.LeftChild != null)
            {
                index = FillArray(arr, index + 1, pos.LeftChild);
            }
            if (pos.CenterChild != null)
            {
                index = FillArray(arr, index + 1, pos.CenterChild);
            }
            if (pos.RightChild != null)
            {
                index = FillArray(arr, index + 1, pos.RightChild);
            }
            return index;
        }

        public int Size()
        {
            return _size;
        }

        public void Add(T element)
        {
            if (_root == null)
            {
                _root = new Position<T>(element);
            }
            else
            {
                Add(_root, element);
            }

            _size++;
        }

        /// <summary>
        /// Внутренний рекурсивный метод, для добавления элемента.
        /// </summary>
        /// <param name="parent"> Родительская ячейка. </param>
        /// <param name="element"> Добавляемый элемент. </param>
        private void Add(Position<T> parent, T element)
        {
            int cmp = parent.Element.Compare(element);
            if (cmp > 0)
            {
                if (parent.LeftChild != null)
                {
                    Add(parent.LeftChild, element);
                }
                else
                {
                    Position<T> child = new Position<T>(element);
                    parent.LeftChild = child;
                    child.Parent = parent;
                }
            }
            else if (cmp < 0)
            {
                if (parent.RightChild != null)
                {
                    Add(parent.RightChild, element);
                }
                else
                {
                    Position<T> child = new Position<T>(element);
                    parent.RightChild = child;
                    child.Parent = parent;
                }
            }
            else
            {
                if (parent.CenterChild != null)
                {
                    Add(parent.CenterChild, element);
                }
                else
                {
                    Position<T> child = new Position<T>(element);
                    parent.CenterChild = child;
                    child.Parent = parent;
                }
            }
        }

        public bool Remove(T element)
        {
            if (_root == null)
            {
                return false;
            }
            else
            {
                bool result = Remove(_root, element);
                if (result)
                {
                    _size--;
                }
                return result;
            }
        }

        /// <summary>
        /// Внутренний рекурсивный метод, для удаления элемента.
        /// </summary>
        /// <param name="position"> Ячейка для проверки. </param>
        /// <param name="element"> Удаляемый элемент. </param>
        /// <returns></returns>
        private bool Remove(Position<T> position, T element)
        {
            int cmp = position.Element.Compare(element);
            if (cmp > 0)
            {
                if (position.LeftChild == null)
                {
                    return false;
                }
                return Remove(position.LeftChild, element);
            }
            else if (cmp < 0)
            {
                if (position.RightChild == null)
                {
                    return false;
                }
                return Remove(position.RightChild, element);
            }
            else
            {
                if (position.CenterChild == null)
                {
                    if (position.LeftChild != null)
                    {
                        Position<T> max = Max(position.LeftChild);
                        position.Element = max.Element;
                        if (max.Parent.RightChild == max)
                        {
                            max.Parent.RightChild = max.LeftChild;
                        }
                        else if (max.Parent.CenterChild == max)
                        { 
                            max.Parent.CenterChild = max.LeftChild;
                        }
                        else
                        {
                            max.Parent.LeftChild = max.LeftChild;
                        }
                        if (max.LeftChild != null)
                        {
                            max.LeftChild.Parent = max.Parent;
                        }
                    }
                    else if (position.RightChild != null)
                    {
                        if (position.Parent != null)
                        {
                            if (position.Parent.LeftChild == position)
                            {
                                position.Parent.LeftChild = position.RightChild;
                            }
                            else if (position.Parent.RightChild == position)
                            {
                                position.Parent.RightChild = position.RightChild;
                            }
                            else
                            {
                                position.Parent.CenterChild = position.RightChild;
                            }
                            position.RightChild.Parent = position.Parent;
                        }
                        else if (position == _root)
                        {
                            _root = position.RightChild;
                            position.RightChild.Parent = null;
                        }
                    }
                    else 
                    {
                        if (position == _root)
                        {
                            _root = null;
                        }
                        else
                        {
                            if (position.Parent.LeftChild == position)
                            {
                                position.Parent.LeftChild = null;
                            } 
                            else if (position.Parent.CenterChild == position)
                            {
                                position.Parent.CenterChild = null;
                            }
                            else
                            {
                                position.Parent.RightChild = null;
                            }
                        }
                    }
                    return true;
                }
                return Remove(position.CenterChild, element);
            }
        }

        /// <summary>
        /// Ищет максимальный элемент дерева, начинающегося с указанной позиции.
        /// </summary>
        /// <param name="parent"> Корневой элемент дерева. в котором ведется поиск. </param>
        /// <returns> Максимальный элемент в дереве. </returns>
        private Position<T> Max(Position<T> parent)
        {
            if (parent.RightChild != null)
            {
                return Max(parent.RightChild);
            }
            else if (parent.CenterChild != null)
            {
                return Max(parent.CenterChild);
            }
            else
            {
                return parent;
            }
        }
        
        public void Find(SearchQuery<T> query)
        {
            Find(_root, query);
        }

        /// <summary>
        /// Внутренний рекурсивный метод, для поиска элемента.
        /// </summary>
        /// <param name="position"> Ячейка для проверки. </param>
        /// <param name="query"> Поисковый запрос. </param>
        private void Find(Position<T> position, SearchQuery<T> query)
        {
            if (position == null)
            {
                query.Count();
                return;
            }

            int cmp = query.Check(position.Element);
            if (cmp == 0)
            {
                return;
            }
            if (cmp > 0)
            {
                Find(position.LeftChild, query);
            }
            if (cmp < 0)
            {
                Find(position.RightChild, query);
            }

            Find(position.CenterChild, query);
        }

        /// <summary>
        /// Вершина дерева, реализующий методы работы с поддервом.
        /// </summary>
        /// <typeparam name="T"> Тип данных, хранимых в дереве. </typeparam>
        [Serializable]
        class Position<T> where T : IElement
        {
            /// <summary>
            /// Конструктор, создающий вершину дерева.
            /// </summary>
            /// <param name="element"> Элемент, хранимый в вершине дерева. </param>
            public Position(T element)
            {
                Element = element;
            }

            /// <summary>
            /// Публичный геттер и сеттер для элемента, хранимого в вершине.
            /// </summary>
            public T Element { get; set; }

            /// <summary>
            /// Публичный геттер и сеттер для левой ветви поддерева.
            /// </summary>
            public Position<T> LeftChild { get; set; }

            /// <summary>
            /// Публичный геттер и сеттер для правой ветви поддерева.
            /// </summary>
            public Position<T> RightChild { get; set; }

            /// <summary>
            /// Публичный геттер и сеттер для центральной ветви поддерева.
            /// </summary>
            public Position<T> CenterChild { get; set; }

            /// <summary>
            /// Публичный геттер и сеттер для родителя этой вершины.
            /// </summary>
            public Position<T> Parent { get; set; }
        }
    }
}