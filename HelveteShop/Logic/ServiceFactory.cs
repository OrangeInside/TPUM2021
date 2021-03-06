using ClientData;
using ClientLogic;

namespace ClientLogic
{
    public class ServiceFactory
    {
        public static IVinylService CreateVinylService => new VinylService(VinylDataBase.Instance);
        public static IOrderService CreateOrderService => new OrderService(OrderDataBase.Instance);
        public static IClientService CreateClientService => new ClientService(ClientDataBase.Instance);
    }
}
