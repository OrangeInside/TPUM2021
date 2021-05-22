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
        Task<bool> AddVinyl(VinylDTO vinyl);
        Task<bool> RemoveVinyl(VinylDTO vinyl);
        Task<bool> UpdateVinyl (VinylDTO vinyl, int id);
    }
}
