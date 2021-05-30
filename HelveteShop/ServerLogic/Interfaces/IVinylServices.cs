using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic
{
    public interface IVinylServices
    {
        Task<VinylDTO> GetVinyl(int id);
        Task<IEnumerable<VinylDTO>> GetAllVinyls();
        Task<bool> AddVinyl(int id, int count);
        Task<bool> AddNewVinyl(VinylDTO vinyl);
        Task<bool> RemoveVinyl(int id);
        Task<bool> RemoveStockVinyl(int id, int count);
    }
}
