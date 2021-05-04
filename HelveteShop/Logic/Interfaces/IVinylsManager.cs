using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IVinylsManager
    {
        event Action OnRefreshVinyls;
        List<VinylDTO> GetAllVinylsAsDTO();
        bool AddVinyl(VinylDTO vinylToAdd);
    }
}
