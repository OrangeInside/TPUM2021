using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IItemCollection<T>
    {
        public void Add(T item);
        public bool Remove(T item);
        public T[] GetAll();
        public T GetItemByID(int id);
    }
}
