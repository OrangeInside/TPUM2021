using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

                vinylDataBase.AddNew(new Vinyl(0, "Filosofem", "Burzum", 5.99M, 5));
                vinylDataBase.AddNew(new Vinyl(1, "Transylvanian Hunger", "Darkthrone", 3.99M, 10));
                vinylDataBase.AddNew(new Vinyl(2, "De Mysteriis Dom Sathanas", "Mayhem", 4.99M, 11));
                vinylDataBase.AddNew(new Vinyl(3, "Black Metal", "Venom", 2.99M, 45));
                vinylDataBase.AddNew(new Vinyl(4, "With Hearts Toward None", "Mgla", 1.99M, 9));
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
