using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonModel.Interfaces;
using CommonModel;
using ServerData;

namespace ServerLogic
{
    public class SrvVinyls : IVinylServices
    {
        private IDataBase<IVinyl> vinylDataBase = null;

        public SrvVinyls()
        {
            if (vinylDataBase == null)
            {
                vinylDataBase = new VinylDataBase();
            }
        }

        public async Task<bool> AddVinyl(VinylDTO vinyl)
        {
            return await Task.FromResult(vinylDataBase.Add(DTOMapper.Map(vinyl)));
        }

        public async Task<IEnumerable<VinylDTO>> GetAllVinyls()
        {
            var vinyls = vinylDataBase.GetAll();

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

        public async Task<bool> RemoveVinyl(int id)
        {
            return await Task.FromResult(vinylDataBase.Remove(id));
        }

        public async Task<bool> UpdateVinyl(VinylDTO vinyl, int id)
        {
            return await Task.FromResult(vinylDataBase.Update(DTOMapper.Map(vinyl), id));
        }
    }
}
