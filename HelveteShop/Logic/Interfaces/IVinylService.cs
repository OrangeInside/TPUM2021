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
        Task RemoveVinyl(int id, int count);
        VinylDTO GetVinyl(int id);
        IEnumerable<VinylDTO> GetVinyls();

        Task Subscribe(VinylDTO vinyl);
        Task Unsubscribe(VinylDTO vinyl);

    }
}
