using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace ServerData
{
    public class VinylDataBase : IDataBase<IVinyl>
    {
        private readonly DataContext dataContext;
        private readonly object itemLock = new object();

        public VinylDataBase()
        {
            this.dataContext = DataContext.Instance;
        }

        public void Add(IVinyl item)
        {
            dataContext?.Vinyls?.Add(item);
        }

        public IEnumerable<IVinyl> GetAll()
        {
            return dataContext?.Vinyls;
        }

        public IVinyl GetClient(int id)
        {
            return dataContext.Vinyls.Find(vinyl => vinyl.ID == id);
        }

        public bool Remove(IVinyl item)
        {
            return dataContext.Vinyls.Remove(item);
        }

        public bool Update(IVinyl item, int id)
        {
            IVinyl targetVinyl = dataContext.Vinyls.Find(vinyl => vinyl.ID == id);

            if (targetVinyl == null)
                return false;
            else
            {
                lock (itemLock)
                {
                    targetVinyl.band = item.band;
                    targetVinyl.price = item.price;
                    targetVinyl.title = item.title;
                }

                return true;
            }
        }

        bool IDataBase<IVinyl>.Add(IVinyl item)
        {
            throw new NotImplementedException();
        }

        IVinyl IDataBase<IVinyl>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IVinyl> IDataBase<IVinyl>.GetAll()
        {
            throw new NotImplementedException();
        }

        bool IDataBase<IVinyl>.Remove(int id)
        {
            throw new NotImplementedException();
        }

        bool IDataBase<IVinyl>.Update(IVinyl item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
