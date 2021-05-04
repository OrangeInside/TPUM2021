using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    using Data;

    public class VinylsManager : IVinylsManager
    {
        public event Action OnRefreshVinyls;

        private IDataBase dataBase = null;

        public VinylsManager()
        {
            dataBase = Data.GetDataBase();
        }

        public List<VinylDTO> GetAllVinylsAsDTO()
        {
            List<VinylDTO> listToReturn = new List<VinylDTO>();

            foreach (Vinyl vinyl in dataBase.GetAllVinyls())
            {
                listToReturn.Add(DTOMapper.Map(vinyl));
            }

            return listToReturn;
        }

        public bool AddVinyl(VinylDTO vinylToAdd)
        {
            if (vinylToAdd.Title != "" && vinylToAdd.Band != "")
            {
                List<VinylDTO> vinyls = GetAllVinylsAsDTO();

                int idForVinyl = 0;

                foreach (VinylDTO vinyl in vinyls)
                {
                    if (idForVinyl == vinyl.ID)
                        idForVinyl++;
                    else
                        break;
                }

                Vinyl newVinylData = new Vinyl(idForVinyl, vinylToAdd.Title, vinylToAdd.Band, vinylToAdd.Price);

                dataBase.AddVinyl(newVinylData);

                OnRefreshVinyls?.Invoke();

                return true;
            }
            return false;
        }
    }
}

