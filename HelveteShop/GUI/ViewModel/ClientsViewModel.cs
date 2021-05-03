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
        private VinylsManager vinylsManager = null;

        public ClientsViewModel()
        {
            clientsManager = new ClientsManager();
            vinylsManager = new VinylsManager();
        }

        public ObservableCollection<ClientDTO> Clients => new ObservableCollection<ClientDTO>(clientsManager?.GetAllClientsAsDTO());
        public ObservableCollection<VinylDTO> Vinyls => new ObservableCollection<VinylDTO>(vinylsManager?.GetAllVinylsAsDTO());
    }
}
