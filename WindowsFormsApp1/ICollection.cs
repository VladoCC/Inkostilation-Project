using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public interface ICollection<T> where T : IElement
    {
        T[] ToArray();

        int Size();

        void Add(T element);

        bool Remove(T element);

        void Find(SearchQuery<T> query);
    }
}
