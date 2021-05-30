using System;
using System.Threading.Tasks;

namespace ClientLogic.Services
{
    public interface IConnectionSerivce
    {
        Action<string> ConnectionLogger { get; set; }

        bool Connected { get; }
        Task<bool> Connect(Uri peerUri);
        Task Disconnect();
    }
}
