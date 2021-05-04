using System.Collections.ObjectModel;
using System.ComponentModel;
using Logic;
using System.Windows.Input;

namespace GUI.ViewModel
{
    public class ClientsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshClients() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Clients"));

        private IClientsManager clientsManager = null;
        public ICommand AddClientCmd { get; set; } = null;

        public ClientsViewModel()
        {
            clientsManager = Logic.Logic.GetClientsManager();

            clientsManager.OnRefreshClients += RefreshClients;

            AddClientCmd = new CmdAddClient(this);
        }

        ~ClientsViewModel()
        {
            clientsManager.OnRefreshClients -= RefreshClients;
        }

        public ObservableCollection<ClientDTO> Clients => new ObservableCollection<ClientDTO>(clientsManager?.GetAllClientsAsDTO());

        #region User Management

        private string name;
        private string address;

        public string Name
        {
            get => name;

            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public string Address
        {
            get => address;

            set
            {
                address = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Address"));
            }
        }

        public void ClearUserInputs()
        {
            Name = "";
            Address = "";
        }

        public ClientDTO CreateClientDTO()
        {
            return new ClientDTO
            {
                Name = this.Name,
                Address = this.Address
            };
        }

        #endregion
    }
}
