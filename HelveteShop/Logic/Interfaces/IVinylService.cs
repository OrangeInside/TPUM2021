using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientLogic
{
    public interface IVinylService
    {
        event Action OnRefreshVinyls;

        Task RefreshVinyls();
        bool AddVinyl(VinylDTO newVinyl);
        bool RemoveVinyl(VinylDTO vinylToRemove);
        VinylDTO GetVinyl(int id);
        IEnumerable<VinylDTO> GetVinyls();

    }
}
