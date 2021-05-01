using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IItemCollection<T>
    {
        void Add(T item);
        bool Remove(T item);
        T[] GetAll();
        T GetItemByID(int id);
    }
}
