using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientData
{
    public class VinylDataBase : IDataBase<IVinyl>
    {
        private readonly DataContext dataContext;

        public event Action DataChanged;

        private static VinylDataBase instance;
        public static VinylDataBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new VinylDataBase();

                return instance;
            }

            private set => instance = value;
        }

        public VinylDataBase()
        {
            this.dataContext = DataContext.Instance;
            dataContext.VinylsChanged += DataChangedInvoke;
        }

        private void DataChangedInvoke()
        {
            DataChanged?.Invoke();
        }

        public async Task<bool> Add(IVinyl item)
        {
            string addVinylRequest = "AddVinyl";
            addVinylRequest += JsonSerializer.Serialize((Vinyl)item);

            await dataContext.RequestWithConfirmation(addVinylRequest);
            await dataContext.RequestDataUpdate();

            return await Task.FromResult(true);
        }

        public IVinyl Get(int id)
        {
            return dataContext.Vinyls.Find(vinyl => vinyl.ID == id);
        }

        public IEnumerable<IVinyl> GetAll()
        {
            return dataContext?.Vinyls;
        }

        public bool Remove(int id)
        {
            return dataContext.Vinyls.RemoveAll(vinyl => vinyl.ID == id) > 0;
        }

        bool IDataBase<IVinyl>.Update(IVinyl item, int id)
        {
            IVinyl found = dataContext.Vinyls.Find(vinyl => vinyl.ID == id);
            if (found != null)
            {
                found.Title = item.Title;
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task Refresh()
        {
            await dataContext.RequestDataUpdate();
        }

        public async Task<bool> Remove(int id, int count)
        {
            for (int i = 0; i < count; i++)
                await dataContext.RequestWithConfirmation(MessageParser.Create("RemoveVinyl", id, id.GetType().Name));

            await dataContext.RequestDataUpdate();
            return await Task.FromResult(true);
        }

        public async Task Subscribe(IVinyl vinyl)
        {
            await dataContext.RequestWithConfirmation(MessageParser.Create("Subscribe", vinyl, vinyl.GetType().Name));
        }

        public async Task Unsubscribe(IVinyl vinyl)
        {
            await dataContext.RequestWithConfirmation(MessageParser.Create("Unsubscribe", vinyl, vinyl.GetType().Name));
        }
    }
}
