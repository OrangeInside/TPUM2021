using System.Collections.Generic;
using CommonModel;

namespace ClientData
{
    public interface IDataBase<T> where T : IData
    {
        bool Add(T item);
        bool Remove(int id);
        T Get(int id);
        bool Update(T item, int id);
        IEnumerable<T> GetAll();
    }
}
