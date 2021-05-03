using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Logic.DTO;
using Logic.Managers;

namespace GUI.ViewModel
{
    public class ClientsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ClientsManager clientsManager = null;

        public ClientsViewModel()
        {
            clientsManager = new ClientsManager();
        }

        public ObservableCollection<ClientDTO> Clients => new ObservableCollection<ClientDTO>(clientsManager?.GetAllClientsAsDTO());
    }
}
