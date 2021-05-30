using System;
using System.Collections.Generic;
using System.Text;
using CommonModel;

namespace ServerData
{
    public interface IVinylDatabase
    {
        IEnumerable<IVinyl> Get();
        IVinyl Get(int id);
        bool AddNew(IVinyl item);
        bool AddStock(int id, int count);
        bool Remove(int id);
        bool RemoveStock(int id, int count);
        //bool Update(int id, IVinyl item);
    }
}
