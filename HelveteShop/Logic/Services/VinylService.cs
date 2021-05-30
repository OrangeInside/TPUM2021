using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonModel;
using ClientData;

namespace ClientLogic
{
    public class VinylService : IVinylService
    {
        public event Action OnRefreshVinyls;

        private readonly IDataBase<IVinyl> vinylsDataBase;

        public VinylService(IDataBase<IVinyl> vinylsDataBase)
        {
            this.vinylsDataBase = vinylsDataBase;
            vinylsDataBase.DataChanged += VinylsChangedInvoke;
        }

        public void VinylsChangedInvoke()
        {
            OnRefreshVinyls?.Invoke();
        }

        public async Task RefreshVinyls()
        {
            await vinylsDataBase.Refresh();
        }

        public VinylDTO GetVinyl(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException();

            return DTOMapper.Map(vinylsDataBase.Get(id));
        }

        public IEnumerable<VinylDTO> GetVinyls()
        {
            IEnumerable<IVinyl> vinyls = vinylsDataBase.GetAll();

            List<VinylDTO> vinylsDTOs = new List<VinylDTO>();

            foreach (var vinyl in vinyls)
            {
                vinylsDTOs.Add(DTOMapper.Map(vinyl));
            }

            return vinylsDTOs;
        }

        public bool AddVinyl(VinylDTO newVinyl)
        {

            vinylsDataBase.Add(DTOMapper.Map(newVinyl));
            OnRefreshVinyls?.Invoke();
            return true;
        }

        public bool RemoveVinyl(VinylDTO vinylToRemove)
        {
            bool retVal = false;
            try
            {
                retVal = vinylsDataBase.Remove(vinylToRemove.ID);
            }
            catch
            {
                return false;
            }

            OnRefreshVinyls?.Invoke();
            return retVal;
        }

        public List<VinylDTO> GetAllVinylsAsDTO()
        {
            throw new NotImplementedException();
        }

    }
}

