using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Logic.DTO;
using Logic.Managers;
using System.Windows.Input;

namespace GUI.ViewModel
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshOrders() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Orders"));

        private ClientsManager clientsManager = null;
        private VinylsManager vinylsManager = null;
        private OrdersManager ordersManager = null;

        public ICommand AddOrderCmd { get; set; } = null;

        public OrdersViewModel()
        {
            clientsManager = Logic.Logic.GetClientsManager();
            vinylsManager = Logic.Logic.GetVinylsManager();
            ordersManager = Logic.Logic.GetOrdersManager();

            ordersManager.OnRefreshOrders += RefreshOrders;

            SelectedClient = Clients[0];
            SelectedVinyl = Vinyls[0];

            AddOrderCmd = new CmdAddOrder(this);
        }

        ~OrdersViewModel()
        {
            ordersManager.OnRefreshOrders -= RefreshOrders;
        }

        public ObservableCollection<ClientDTO> Clients => new ObservableCollection<ClientDTO>(clientsManager?.GetAllClientsAsDTO());
        public ObservableCollection<VinylDTO> Vinyls => new ObservableCollection<VinylDTO>(vinylsManager?.GetAllVinylsAsDTO());
        public ObservableCollection<OrderDTO> Orders => new ObservableCollection<OrderDTO>(ordersManager?.GetAllOrdersAsDTO());

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
