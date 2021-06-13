using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientData
{
    public interface IDataBase<T> where T : IData
    {
        Task<bool> Add(T item);
        bool Remove(int id);
        Task<bool> Remove(int id, int count);
        T Get(int id);
        bool Update(T item, int id);
        IEnumerable<T> GetAll();

        Task Refresh();
        event Action DataChanged;
    }
}
