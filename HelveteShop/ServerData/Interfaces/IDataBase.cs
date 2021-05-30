using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonModel;

namespace ServerData
{
    public interface IDataBase<T> where T : IData
    {
        Task<bool> Add(T item);
        bool Remove(int id);
        T Get(int id);
        bool Update(T item, int id);
        IEnumerable<T> GetAll();

        Task Refresh();
        event Action DataChanged;
    }
}
