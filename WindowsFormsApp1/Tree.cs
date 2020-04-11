using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable]
    public class Tree<T> : ICollection<T> where T : IElement
    {
        private Position<T> _root;
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
                        if (max.LeftChild != null)
                        {
                            if (max.Parent.RightChild == max)
                            {
                                max.Parent.RightChild = max.LeftChild;
                            }
                            else
                            {
                                max.Parent.CenterChild = max.LeftChild;
                            }
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
                        }
                    }
                    else if (position == _root)
                    {
                        _root = null;
                    }
                    return true;
                }
                return Remove(position.CenterChild, element);
            }
        }

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

        public string Find(T element)
        {
            return Find(_root, element, 0);
        }

        private string Find(Position<T> position, T element, int counter)
        {
            if (position == null)
            {
                return "Not found";
            }
            counter++;
            int cmp = position.Element.Compare(element);
            if (cmp == 0)
            {
                return "Checks: " + counter + "\n" + position.Element.ToString();
            }
            if (cmp > 0)
            {
                return Find(position.LeftChild, element, counter);
            }
            if (cmp < 0)
            {
                return Find(position.RightChild, element, counter);
            }

            return Find(position.CenterChild, element, counter);
        }

        [Serializable]
        class Position<T> where T : IElement
        {
            public Position(T element)
            {
                Element = element;
            }

            public T Element { get; set; }

            public Position<T> LeftChild { get; set; }

            public Position<T> RightChild { get; set; }

            public Position<T> CenterChild { get; set; }

            public Position<T> Parent { get; set; }
        }
    }
}