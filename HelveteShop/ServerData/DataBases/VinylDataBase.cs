using System;
using System.Collections.Generic;
using System.Text;

namespace ServerData
{
    public class VinylDataBase : IVinylDatabase
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

        public bool AddNew(IVinyl item)
        {
            dataContext?.Vinyls?.Add(item);
            return true;
        }

        public bool AddStock(int id, int count)
        {
            IVinyl vinyl = Get(id);

            if (vinyl != null)
            {
                vinyl.InStock += count;
                return true;
            }
            else
                return false;
        }

        public IEnumerable<IVinyl> Get()
        {
            return dataContext?.Vinyls;
        }

        public IVinyl Get(int id)
        {
            return dataContext.Vinyls.Find(vinyl => vinyl.ID == id);
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

        public bool Remove(int id)
        {
            return dataContext.Vinyls.Remove(dataContext.Vinyls.Find(vinyl => vinyl.ID == id));
        }

        public bool RemoveStock(int id, int count)
        {
            IVinyl vinyl = Get(id);

            if (vinyl != null)
            {
                vinyl.InStock -= count;

                if (vinyl.InStock < 0)
                    vinyl.InStock = 0;

                return true;
            }
            else
                return false;
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
                    targetVinyl.Band = item.Band;
                    targetVinyl.Price = item.Price;
                    targetVinyl.Title = item.Title;
                }

                return true;
            }
        }

    }
}
