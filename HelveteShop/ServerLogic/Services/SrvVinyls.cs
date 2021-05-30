using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonModel;
using ServerData;

namespace ServerLogic
{
    public class SrvVinyls : IVinylServices
    {
        private IVinylDatabase vinylDataBase = null;

        //class for tests
        public SrvVinyls(IVinylDatabase vinylDB)
        {
            vinylDataBase = vinylDB;
        }

        public SrvVinyls()
        {
            if (vinylDataBase == null)
            {
                vinylDataBase = new VinylDataBase();
                vinylDataBase.AddNew(new Vinyl(0, "With Hearts Toward None", "Mgla", 15.99m, 1));
                vinylDataBase.AddNew(new Vinyl(1, "With Hearts Toward Everything", "Night", 16.12m, 5));
                vinylDataBase.AddNew(new Vinyl(2, "With Legs Toward None", "Day", 16.99m, 2));
            }
        }

        public async Task<bool> AddNewVinyl(VinylDTO vinyl)
        {
            return await Task.FromResult(vinylDataBase.AddNew(DTOMapper.Map(vinyl)));
        }

        public async Task<bool> AddVinyl(VinylDTO vinyl)
        {
            IVinyl vinylObj = DTOMapper.Map(vinyl);

            return await Task.FromResult(vinylDataBase.AddStock(vinylObj.ID, vinylObj.InStock));
        }

        public async Task<bool> AddVinyl(int id, int count)
        {
            //return await Task.FromResult(vinylDataBase.Get(id) != null);
            return await Task.FromResult(vinylDataBase.AddStock(id, count));
        }

        public async Task<IEnumerable<VinylDTO>> GetAllVinyls()
        {
            var vinyls = vinylDataBase.Get();

            List<VinylDTO> vinylsList = new List<VinylDTO>();

            foreach (IVinyl v in vinyls)
            {
                vinylsList.Add(DTOMapper.Map(v));
            }

            return await Task.FromResult(vinylsList);
        }

        public async Task<VinylDTO> GetVinyl(int id)
        {
            return await Task.FromResult(DTOMapper.Map(vinylDataBase.Get(id)));
        }

        public async Task<bool> RemoveStockVinyl(int id, int count)
        {
            return await Task.FromResult(vinylDataBase.RemoveStock(id, count));
        }

        public async Task<bool> RemoveVinyl(int id)
        {
            return await Task.FromResult(vinylDataBase.Remove(id));
        }

        public async Task<bool> UpdateStock()
        {
            var vinyls = vinylDataBase.Get();

            foreach (IVinyl vinyl in vinyls)
            {
                await this.AddVinyl(vinyl.ID, 1);
            }

            return true;
        }

        /*public async Task<bool> UpdateVinyl(VinylDTO vinyl, int id)
        {
            return await Task.FromResult(vinylDataBase.Update(DTOMapper.Map(vinyl), id));
        }*/
    }
}
