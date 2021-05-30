using System.Collections.ObjectModel;
using System.ComponentModel;
using ClientLogic;
using System.Windows.Input;

namespace ClientPresentation.ViewModel
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshOrders() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Orders"));

        private IClientService clientsManager = null;
        private IVinylService vinylsManager = null;
        private IOrderService ordersManager = null;

        public ICommand AddOrderCmd { get; set; } = null;

        public OrdersViewModel()
        {

            AddOrderCmd = new CmdAddOrder(this);
        }

        ~OrdersViewModel()
        {

        }

        private VinylDTO selectedVinyl = null;

        public VinylDTO SelectedVinyl
        {
            get => selectedVinyl;
            set
            {
                selectedVinyl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedVinyl"));
            }
        }

        private ClientDTO selectedClient = null;

        public ClientDTO SelectedClient
        {
            get => selectedClient;
            set
            {
                selectedClient = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedClient"));
            }
        }

        public OrderDTO CreateOrderDTO()
        {
            return new OrderDTO
            {
                ClientID = selectedClient.ID,
                ClientName = selectedClient.Name,
                ClientAddress = selectedClient.Address,
                VinylID = selectedVinyl.ID,
                VinylBand = selectedVinyl.Band,
                VinylPrice = selectedVinyl.Price,
                VinylTitle = selectedVinyl.Title
            };
        }
    }
}
